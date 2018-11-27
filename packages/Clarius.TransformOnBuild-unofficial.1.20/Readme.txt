Usage:

    Simply continue using `TextTemplatingFileGenerator` custom 
    tools associated with your .tt/.t4 files as usual. This package will add a .targets file that 
    will also transform them on build, without requiring the installation of any Visual Studio SDK.


Release Notes:

v1.20

* Add support for Visual Studio 2015 Update 1

* Fix path with spaces

v1.19

* Transform items with Build Action = Content

v1.18

* Ensure ResolveReferences and _CopyFilesMarkedCopyLocal will run during the main build

v1.17

* Transform before build and manually trigger ResolveReferences

v1.16

* Copy custom task assembly to the temp folder to prevent locking

v1.15

* Copy Local dlls to TargetDir before transformation to allow use of $(TargetDir)

v1.14

* Substitute MSBuild variables such as $(ProjectDir)

v1.1

* Disabled processing of T4 files with 'TextTemplatingFilePreprocessor' since they aren't supported by TextTemplating.exe according to http://stackoverflow.com/a/9198532.

v1.0

* Automatically transform on build all None files with one of the T4 custom tools assigned.
