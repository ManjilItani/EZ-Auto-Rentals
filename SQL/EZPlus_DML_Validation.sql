--Name of database to perform operations
USE EZRental;

--#1 A)
--insert into CREDITCARDMERCHANT table
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(1,'Stax by Fattmerchant');
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(2,'Helcim');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(3,'Dharma Merchant Services');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(4,'Payment Depot');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(5,'National Processing');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(6,'Block');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(7,'Intuit Quickbooks');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(8,'PayPal');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(9,'Stripe');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(10,'Flagship Merchant Services');	
INSERT INTO CREDITCARDMERCHANT(MerchantCode,MerchantName) VALUES(11,'Clover');	

--show data in CREDITCARDMERCHANT table;
SELECT * FROM CREDITCARDMERCHANT;


--#1 B)
--insert into CREDITCARD table
INSERT INTO CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany, MerchantCode, ExpDate, AddressLine1,
AddressLine2, City, StateCode, ZipCode, Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES('375678962002379','Max Vin','Amex',4,'2030-9-1','222 Broadway St','Apt 277','West Village','36','50537','US',10000.00,5000.00,1);

INSERT INTO CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany, MerchantCode, ExpDate, AddressLine1,
AddressLine2, City, StateCode, ZipCode, Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES('4845691230024699','Randy Rox','Visa',7,'2030-7-13','123 Brian Ave','Apt 9','West Village','36','50537','US',20000.00,6000.00,1);

INSERT INTO CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany, MerchantCode, ExpDate, AddressLine1,
AddressLine2, City, StateCode, ZipCode, Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES('375756910023649','John Doe','Amex',9,'2025-2-11','123 Mery Blvd','2fl','Cooker','36','29782','US',30000.00,7000.00,1);

INSERT INTO CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany, MerchantCode, ExpDate, AddressLine1,
AddressLine2, City, StateCode, ZipCode, Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES('6450004987603246','Kane Page','Discover',4,'2023-7-14','150 Yates Blvd','Apt 69','Jamaica','36','11456','US',40000.00,8000.00,1);

INSERT INTO CREDITCARD(CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany, MerchantCode, ExpDate, AddressLine1,
AddressLine2, City, StateCode, ZipCode, Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES('1111111111111111','Bill Cape','Amex',4,'2022-12-25','333 Washington Ave','15fl','East Village','36','51489','US',50000.00,9000.00,1);


--show data in CREDITCARD table;
SELECT * FROM CREDITCARD;



--#3
--SELECT data with MATCHING parameter from CREDITCARD table
SELECT * FROM CREDITCARD WHERE CreditCardNumber='375678962002379';



--#4
--UPDATE all the columns in CREDITCARD table except CreditCardNumber
UPDATE CREDITCARD SET CreditCardNumber='1111111111111111', CreditCardIssuingCompany = 'Discover', MerchantCode = 9,
ExpDate = '2027-02-01', AddressLine1 = '5789 S BlackStoen Ave', AddressLine2 = 'Apt 107', City='Chicago', StateCode='17',
ZipCode = '60637', Country='US', CreditCardLimit=20000.00, CreditCardBalance=17000.00, ActivationStatus = 0
WHERE CreditCardOwnerName = 'Bill Cape';

--Selects all data from CREDITCARD table
SELECT * FROM CREDITCARD;



--#5
--DELETE record with selected criteria
DELETE FROM CREDITCARD WHERE CreditCardNumber='375678962002379'

--Selects all data from CREDITCARD table
SELECT * FROM CREDITCARD;