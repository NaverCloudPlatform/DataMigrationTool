using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS
{
    public class StatusEventArgs : EventArgs
    {
        public StatusEventArgs(Status status)
        {
            this.status = status;
        }
        public Status status { get; set; }
    }



    class Response
    {
        public string requestNo { get; set; }
        public string requestReturnCode { get; set; }
        public string returnCode { get; set; }
        public string returnCodeName { get; set; }

    }

    class getDmsObjectStorageBackupList
    {
        public getDmsObjectStorageBackupListResponse getDmsObjectStorageBackupListResponse { get; set; }
    }

    class getObjectStorageBackupList
    {
        public getObjectStorageBackupListResponse getObjectStorageBackupListResponse { get; set; }
    }

    class getDmsObjectStorageBackupListResponse
    {
        public string requestId { get; set; }
        public string returnMessage { get; set; }
        public int totalRows { get; set; }
        public List<DmsFileList> dmsFileList { get; set; }
    }

    class getObjectStorageBackupListResponse
    {
        public string requestId { get; set; }
        public string returnMessage { get; set; }
        public int totalRows { get; set; }
        public List<DmsFileList> dmsFileList { get; set; }
    }

    class Error
    {
        public responseError2 responseError { get; set; }
    }

    class responseError2
    {
        public string errorCode { get; set; }
        public string message { get; set; }
        public string details { get; set; }
    }

    class ResponseError
    {
        public responseError responseError { get; set; }
    }

    class responseError
    {
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
    }

    class DmsFileList
    {
        public string fileName { get; set; }
        public long fileLength { get; set; }
        public string lastWriteTime { get; set; }
    }

    class getZoneList
    {
        public getZoneListResponse getZoneListResponse { get; set; }
    }

    class getZoneListResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public List<zone> zoneList { get; set; }

    }

    class zone
    {
        public string zoneNo { get; set; }
        public string zoneName { get; set; }
        public string zoneCode { get; set; }
        public string zoneDescription { get; set; }
        public string regionNo { get; set; }
    }

    class getCloudDBInstanceList
    {
        public getCloudDBInstanceListResponse getCloudDBInstanceListResponse { get; set; }
    }

    class getCloudMssqlInstanceList
    {
        public getCloudMssqlInstanceListResponse getCloudMssqlInstanceListResponse { get; set; }
    }

    class getCloudMssqlInstanceListResponse
    {
        public string requestId { get; set; }
        public string returnMessage { get; set; }
        public int totalRows { get; set; }
        public List<CloudMssqlInstance> cloudMssqlInstanceList { get; set; }
    }

    class CloudMssqlInstance
    {
        public string cloudMssqlInstanceNo { get; set; }
    }

    class getCloudDBInstanceListResponse
    {
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public int totalRows { get; set; }
        public List<cloudDBInstanceList> cloudDBInstanceList { get; set; }
    }

    class cloudDBInstanceList
    {
        public string cloudDBInstanceNo { get; set; }
    }


    class accessControlGroupList
    {
        public string accessControlGroupConfigurationNo { get; set; }
        public string accessControlGroupName { get; set; }
        public string accessControlGroupDescription { get; set; }
        public bool isDefault { get; set; }
        public string createDate { get; set; }
    }
    class cloudDBConfigGroupList
    {
        public string configGroupNo { get; set; }
        public string configGroupType { get; set; }
        public string configGroupName { get; set; }
    }
    class region
    {
        public string regionNo { get; set; }
        public string regionCode { get; set; }
        public string regionName { get; set; }
    }

    public class dataStorageType
    {
        public string code { get; set; }
        public string codeName { get; set; }
    }


    class getDmsOperation
    {
        public getDmsOperationResponse getDmsOperationResponse { get; set; }
    }

    class getDmsOperationVP
    {
        public getDmsOperationResponse getDmsOperationResponse { get; set; }
    }

    class getDmsOperationResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public DmsStatus status { get; set; }
    }

    class DmsStatus
    {
        public string code { get; set; }
        public string codeName { get; set; }
    }

    class getBackupList
    {
        public getBackupListResponse getBackupListResponse { get; set; }
    }

    class getDmsBackupList
    {
        public getDmsBackupListResponse getDmsBackupListResponse { get; set; }
    }

    class getDmsBackupListResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public List<backupFileVP> backupFileList { get; set; }
    }

    class backupFileVP
    {
        public string cloudMssqlServerName { get; set; }
        public string fileName { get; set; }
        public long fileSize { get; set; }
        public string databaseName { get; set; }
        public string firstLsn { get; set; }
        public string lastLsn { get; set; }
        public backupType backupType { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
    }


    class backupFile
    {
        public string hostName { get; set; }
        public string fileName { get; set; }
        public string databaseName { get; set; }
        public string firstLsn { get; set; }
        public string lastLsn { get; set; }
        public backupType backupType { get; set; }
        public string backupStartTime { get; set; }
        public string backupEndTime { get; set; }
    }

    class getBackupListResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public List<backupFileList> backupFileList { get; set; }
    }

    class backupFileList
    {
        public string hostName { get; set; }
        public string fileName { get; set; }
        public string databaseName { get; set; }
        public string firstLsn { get; set; }
        public string lastLsn { get; set; }
        public backupType backupType { get; set; }
        public string backupStartTime { get; set; }
        public string backupEndTime { get; set; }
    }

    class backupType
    {
        public string code { get; set; }
        public string codeName { get; set; }
    }

    class restoreDmsDatabase
    {
        public restoreDmsDatabaseResponse restoreDmsDatabaseResponse { get; set; }
    }

    class restoreDmsDatabaseVP
    {
        public restoreDmsDatabaseResponse restoreDmsDatabaseResponse { get; set; }
    }

    class restoreDmsDatabaseResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public int requestNo { get; set; }
    }

    class restoreDmsTransactionLog
    {
        public restoreDmsTransactionLogResponse restoreDmsTransactionLogResponse { get; set; }
    }

    class restoreDmsTransactionLogVP
    {
        public restoreDmsTransactionLogResponse restoreDmsTransactionLogResponse { get; set; }
    }

    class restoreDmsTransactionLogResponse
    {
        public string requestId { get; set; }
        public string returnCode { get; set; }
        public string returnMessage { get; set; }
        public int requestNo { get; set; }
    }

    class ObjectStorageFile
    {
        public string Name { get; set; }
        public long Length { get; set; }
        public string LastWriteTime { get; set; }
    }
}
