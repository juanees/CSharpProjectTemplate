Contains all third-party libraries and packages used by the application(s) in this source tree, usually you should configure Nuget or another package manager to place downloaded packages in this folder.


By default, NuGet downloads all packages to a folder called packages. This folder is created in the same folder where the solution file resides. But according to this folder
structure, you want all of your external libraries to exist in the lib folder.

As such, you need to provide NuGet with an override for the packages location. To do this, there is a text file in the src folder (../src/nuget.config).