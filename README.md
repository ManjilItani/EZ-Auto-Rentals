# 1. EZ-Rentals-Management System

Windows application build in 3-tier architecture system with **.Net** & **C#** to host customer & business infromation during day-to-day work.

### To run on your system

- Set up SQL server on your machine,
  - run ./SQL/EZRentalDBCreateTables.sql (to create the database), then run ./SQL/EZRental_DML_Validation.sql to validate database contentes (optional)
- Open AutoRentalManagementSystem folder in **Visual Studio 2019** and run the application.
- 3-tier Architecture breakdown /AutoRentalManagementSystem
  - ARMSBOLayer - Object mapping
  - ARMSDALayer - Configuration to ORM and connection to database (_if you change name of the database change in line-13 of SQLServerDAOFactory.cs_)
  - ARMSClientApp - Presentation Layer (_for users_)

### ** Indepth documentation in **EZRental Inc. Customer Documentatioin .pdf\*\*
