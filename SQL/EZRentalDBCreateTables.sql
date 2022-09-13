--Create database for EZRental
CREATE DATABASE EZRental;

USE EZRental;
--Create table to store Driver license information
CREATE TABLE DRIVERLICENSE
(
 DriverLicenseNumber     VARCHAR(25)     PRIMARY KEY,
 DriverLicenseExpDate    DATE            NOT NULL,
 DriverLicenseState      CHAR(2)         NOT NULL
);

--Create table to store Customer account information
CREATE TABLE CUSTOMERACCOUNT
(
 UserAccountID     UNIQUEIDENTIFIER    PRIMARY KEY DEFAULT NEWID(),
 UserName          VARCHAR(50)         UNIQUE NOT NULL,
 Password          VARCHAR(50)         NOT NULL,
 Email             VARCHAR(75)         UNIQUE NOT NULL
 );

 --Create table to store Customer's personal information
CREATE TABLE CUSTOMER 
(
CustomerID                 INT                PRIMARY KEY IDENTITY,
FirstName                  VARCHAR(50)        NOT NULL,
LastName                   VARCHAR(50)        NOT NULL,
BirthDate                  DATE               NOT NULL,
AddressLine1               VARCHAR(50)        NOT NULL,
AddressLine2               VARCHAR(50)        NULL,
City                       VARCHAR(30)        NOT NULL,
StateCode                  CHAR(2)            NOT NULL,
ZipCode                    VARCHAR(10)        NOT NULL,
Country                    VARCHAR(100)       NOT NULL,
Phone                      VARCHAR(20)        NOT NULL,
Email                      VARCHAR(75)        UNIQUE NOT NULL,
DriverLicenseNumber        VARCHAR(25)        FOREIGN KEY REFERENCES DRIVERLICENSE(DriverLicenseNumber) 
                                              ON DELETE CASCADE ON UPDATE CASCADE 
											  UNIQUE NOT NULL,
CustomerUserAccountID      UNIQUEIDENTIFIER   FOREIGN KEY REFERENCES CUSTOMERACCOUNT(UserAccountID) 
                                              ON DELETE CASCADE ON UPDATE CASCADE 
											  NULL,
CustomerType               CHAR(1)            NOT NULL
);

--Create table to store information Merchant's who deal with credit card transanction between customers and EZRentals Inc
CREATE TABLE CREDITCARDMERCHANT
(
MerchantCode  TINYINT       PRIMARY KEY  CHECK(MerchantCode >= 1 AND MerchantCode <= 15),
MerchantName  VARCHAR(50)   NOT NULL
);

--Create table to store  credit card information
CREATE TABLE CREDITCARD
(
CreditCardNumber              VARCHAR(16)     PRIMARY KEY,
CreditCardOwnerName           VARCHAR(100)    NOT NULL,
CreditCardIssuingCompany      VARCHAR(50)     NOT NULL,
MerchantCode                  TINYINT         FOREIGN KEY 
                                              REFERENCES CREDITCARDMERCHANT(MerchantCode) 
											  ON DELETE CASCADE ON UPDATE CASCADE  
											  CHECK(MerchantCode >= 1 AND MerchantCode <= 15)
											  NOT NULL,
ExpDate                       DATE            NOT NULL,
AddressLine1                  VARCHAR(50)     NOT NULL,
AddressLine2                  VARCHAR(50)     NULL,
City                          VARCHAR(30)     NOT NULL,
StateCode                     CHAR(2)         NOT NULL,
ZipCode                       VARCHAR(10)     NOT NULL,
Country                       VARCHAR(100)    NOT NULL,
CreditCardLimit               DECIMAL(8,2)    NOT NULL CHECK( CreditCardLimit >= 1000),
CreditCardBalance             DECIMAL(8,2)    NOT NULL CHECK(CreditCardBalance >= 1000),
ActivationStatus              BIT             NOT NULL
);

--Create table to store Customer's credit card information
CREATE TABLE CUSTOMER_CREDITCARD
(
CreditCardNumber  VARCHAR (16),
CustomerID        INT

CONSTRAINT pk_Customer_CreditCard
PRIMARY KEY (CreditCardNumber, CustomerID), -- Syntax #2-Create composite key

CONSTRAINT fk_Customer_CC_CardNumber -- Syntax #3-Create relationship to CreditCard table 
FOREIGN KEY (CreditCardNumber) 
REFERENCES CreditCard(CreditCardNumber) 
ON DELETE CASCADE ON UPDATE CASCADE,

CONSTRAINT fk_Customer_CC_CustomerID -- Syntax #3-Create relationship to customer table 
FOREIGN KEY(CustomerID) 
REFERENCES Customer(CustomerID) 
ON DELETE CASCADE ON UPDATE CASCADE
);

--Create table to store information about all the discount codes/coupns generated by EZRentals Inc.
CREATE TABLE DISCOUNT
(
  DiscountID        INT            PRIMARY KEY IDENTITY,
  DiscountCode      VARCHAR(10)    UNIQUE  NOT NULL,
  DiscountCodeDesc  VARCHAR(150)   NOT NULL
);

--Create table to store Customers EZPlus information
CREATE TABLE EZPLUS 
(
EZPlusID                    INT             PRIMARY KEY  IDENTITY,
EZPlusRewardsCode           VARCHAR(13)     UNIQUE  NOT NULL,
EZPlusRewardsEarnedPoints   INT             NULL
);

--Create table to store Retail customers information
CREATE TABLE RETAILCUSTOMER
(
CustomerID   INT   PRIMARY KEY,
DiscountID   INT   FOREIGN KEY 
             REFERENCES DISCOUNT(DiscountID) 
			 ON DELETE CASCADE ON UPDATE CASCADE
			 NULL,
EZPlusID     INT   FOREIGN KEY
             REFERENCES EZPLUS(EZPlusID) 
			 ON DELETE CASCADE ON UPDATE CASCADE 
			 NULL,

CONSTRAINT fk_RetailCustomer_CC_CustomerID 
FOREIGN KEY(CustomerID) 
REFERENCES Customer(CustomerID) 
ON DELETE CASCADE ON UPDATE CASCADE
);
--Create table to store information about Company associated to EZRentalInc
CREATE TABLE COMPANY
(
CompanyID                          SMALLINT            PRIMARY KEY   CHECK(CompanyID >= 1 and CompanyID <= 20000),
CompanyName                        VARCHAR(100)        UNIQUE   NOT NULL,
AddressLine1                       VARCHAR(50)         NOT NULL,
AddressLine2                       VARCHAR(50)         NULL,
City                               VARCHAR(30)         NOT NULL,
StateCode                          CHAR(2)             NOT NULL,
ZipCode                            VARCHAR(10)         NOT NULL,
Country                            VARCHAR(100)        NOT NULL,
CompanyRepName                     VARCHAR(100)        NOT NULL,
ContactPhone                       VARCHAR(20)         NOT NULL,
ContactEmail                       VARCHAR(75)         NOT NULL  UNIQUE,
CorporateDiscountPercentageRate    DECIMAL(3,2)        NOT NULL
);

--Create table to store information about Corporate Customers
CREATE TABLE CORPORATECUSTOMER
(
CustomerID       INT       PRIMARY KEY,
CompanyID        SMALLINT  
                 FOREIGN KEY REFERENCES COMPANY(CompanyID)
				 ON DELETE CASCADE ON UPDATE CASCADE
				 CHECK(CompanyID >= 1 and CompanyID <= 20000)
				 NOT NULL,

CONSTRAINT fk_CorporateCustomer_CC_CustomerID 
FOREIGN KEY(CustomerID) 
REFERENCES Customer(CustomerID) 
ON DELETE CASCADE ON UPDATE CASCADE
);

--Create table to store information US states
CREATE TABLE USSTATE
(
StateID             TINYINT       PRIMARY KEY  CHECK( StateID >= 1 and StateID <= 56),
StateCode2Char      CHAR(2)       UNIQUE NOT NULL,
StateName           VARCHAR(20)   NOT NULL
);

--Create table to store information about all the countries that EZRental provide service to
CREATE TABLE COUNTRY
(
CountryID                TINYINT        PRIMARY KEY  CHECK(CountryID >= 1 AND CountryID <= 200),
CountryCode2Char         CHAR(2)        UNIQUE NOT NULL,
CountryCode3Char         CHAR (3)       UNIQUE NOT NULL,
CountryName              VARCHAR(100)   NOT NULL
);