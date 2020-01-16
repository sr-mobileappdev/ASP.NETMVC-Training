
It is a website of a fictional medical institution named Medio Clinic.

## How to run the project

To make the project work, follow these steps:

1. Extract either a database backup file out of [/Db/MedioClinic.zip](/Db/MedioClinic.zip) or, a database build script out of [/Db/MedioClinicSqlScript.zip](/Db/MedioClinicSqlScript.zip) (if you happen to have an older version of SQL Server).
2. Start your [SQL Server management studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) and restore the extracted MedioClinic.bak file.
3. Register both the [administration interface](/CMS) and the [Medio Clinic website](/MedioClinic) in IIS.
    * If you register the administration interface as an application that sits under `Default Web Site` and has a `Kentico12_Admin` alias, then you won't have to do any adjustments in Visual Studio.
    * The same applies to the Medio Clinic project: If you register it under `Default Web Site` as `Kentico12_MedioClinic`, then you should be ready to compile and run.
4. Open Visual Studio with elevated credentials, open the `WebApp.sln` solution and build it (`Ctrl+Shift+B`).
5. Open the `web.config` file and adjust the connection string to your SQL Server instance (if your database instance runs on a different machine).
6. Close the solution.
7. Open the `MedioClinic.sln` solution.
    * If you haven't opened Visual Studio with elevated credentials, then you may encounter an error message saying Visual Studio doesn't have access to your local IIS.
    * If you haven't registed the project under `Default Web Site` as `Kentico12_Admin`, then you might want to adjust debugging settings through the following steps:
        * Go to the solution explorer
        * Right-click the `MedioClinic` project
        * Go to the Web tab
        * Under the Servers section > Project Url, set the correct URL according to your IIS configuration.
8. Build the solution.
9. Open the `/Config/ConnectionStrings.config` file to eventually adjust the connection string (in the same way as you did with the administration interface project).
