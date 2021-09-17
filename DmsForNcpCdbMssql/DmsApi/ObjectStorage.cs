using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NLog;
using Amazon.S3;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Amazon.S3.Model;
using Amazon.S3.Transfer;

namespace DMS
{

    class ObjectStorage
    {
        private static Logger nlog = LogManager.GetCurrentClassLogger();

        public static ObjectStorage Instance { get { return lazy.Value; } }
        private static readonly Lazy<ObjectStorage> lazy =
            new Lazy<ObjectStorage>(
                () => new ObjectStorage()
                , LazyThreadSafetyMode.ExecutionAndPublication
                );

        AmazonS3Config s3config;
        Config config;
        
        public ObjectStorage()
        {
            config = Config.Instance;

            System.Net.ServicePointManager.ServerCertificateValidationCallback +=
            delegate (
                object sender,
                X509Certificate certificate,
                X509Chain chain,
                SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
        }

        public async Task<string> CreateBucketAsync(string BucketName)
        {
            string returnValue = "create bucket failed";
            try
            {
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl;
                string Message = await CheckBucket(BucketName);

                if (Message == CallResult.Success.ToString())
                {
                    returnValue = "bucket exists";
                }
                else if (Message != CallResult.Success.ToString())
                {
                    var putBucketRequest = new PutBucketRequest
                    {
                        BucketName = BucketName,
                        UseClientRegion = true
                    };

                    using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                    {
                        var putBucketResponse = await client.PutBucketAsync(putBucketRequest);
                        returnValue = CallResult.Success.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                returnValue = ex.Message;
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", ex.Message, ex.StackTrace));
            }
            return returnValue; 
        }



        public async Task<string> CheckBucket(string BucketName)
        {
            string returnValue = "bucket does not exists!";
            
            try
            {
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl;
                using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                {
                    ListBucketsResponse response = await client.ListBucketsAsync();
                    foreach (S3Bucket o in response.Buckets)
                    {
                        if (o.BucketName == BucketName)
                        {
                            returnValue = CallResult.Success.ToString();
                            break;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", ex.Message, ex.StackTrace));
                returnValue = ex.Message;
            }
            return returnValue;
        }

        public async Task upload(string sourceFullName, string bucketName, string targetFullName)
        {
            nlog.Warn(string.Format("sourceFullName : {0}, bucketName {1}, targetFullName {2}", sourceFullName, bucketName, targetFullName));
            try
            {
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl;
                using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                {
                    TransferUtility t = new TransferUtility(client);
                    await t.UploadAsync(sourceFullName, bucketName, targetFullName);
                }
                nlog.Warn("upload completed!");
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", e.Message, e.StackTrace));
            }
        }
        
        public async Task download(string sourceFullName, string bucketName, string targetFullName)
        {
            nlog.Warn(string.Format("sourceFullName : {0}, bucketName {1}, targetFullName {2}", sourceFullName, bucketName, targetFullName));
            try
            {
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl;
                using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                {
                    TransferUtility t = new TransferUtility(client);
                    await t.DownloadAsync(targetFullName, bucketName, sourceFullName);
                }
                nlog.Warn("download completed!");
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", e.Message, e.StackTrace));
            }
        }

        public async Task<List<ObjectStorageFile>> list (string bucketName)
        {
            List<ObjectStorageFile> objectStorageFiles = new List<ObjectStorageFile>();
            try
            {
                objectStorageFiles.Clear();
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl; 
                using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                {
                    ListObjectsRequest request = new ListObjectsRequest
                    {
                        BucketName = bucketName,
                        MaxKeys = 2
                    };
                    do
                    {
                        ListObjectsResponse response = await client.ListObjectsAsync(request);
                        foreach (var o in response.S3Objects)
                        {
                            objectStorageFiles.Add(
                                new ObjectStorageFile
                                {
                                    Name = o.Key,
                                    Length = o.Size,
                                    LastWriteTime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", o.LastModified)
                                });
                        }
                        if (response.IsTruncated)
                        {
                            request.Marker = response.NextMarker;
                        }
                        else
                        {
                            request = null;
                        }
                    } while (request != null);
                }
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", e.Message, e.StackTrace));
            }
            return objectStorageFiles;
        }

        public async void delete(string bucketName, string fullFilename)
        {
            try
            {
                s3config = new AmazonS3Config();
                string endpointUrl = config.GetEnumValue(Category.Config, Key.UseSSLObjectStorage) == "1" ? @"https://" : @"http://";
                endpointUrl = endpointUrl + config.GetEnumValue(Category.Config, Key.ObjectEndPoint);
                s3config.ServiceURL = endpointUrl;
                using (IAmazonS3 client = new AmazonS3Client(config.GetEnumValue(Category.Config, Key.ObjectAccessKey), config.GetEnumValue(Category.Config, Key.ObjectSecretKey), s3config))
                {
                    var deleteObjectRequest = new DeleteObjectRequest
                    {
                        BucketName = bucketName,
                        Key = fullFilename
                    };
                    await client.DeleteObjectAsync(deleteObjectRequest);
                    nlog.Warn(string.Format("bucket {0}, key {1} was deleted!", bucketName, fullFilename));
                }
            }
            catch (Exception e)
            {
                nlog.Error(string.Format("Message : {0}, StackTrace : {1}", e.Message, e.StackTrace));
            }
        }

    }
}