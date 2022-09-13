using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ARMSDALayer;


namespace ARMSBOLayer
{
    public class CreditCard
    {
        //Private Datas
        private string m_CreditCardNumber;
        private string m_CreditCardOwnerName;
        private string m_CreditCardIssuingCompany;
        private int m_MerchantCode;
        private DateTime m_ExpDate;
        private string m_AddressLine1;
        private string m_AddressLine2;
        private string m_City;
        private string m_State;
        private string m_ZipCode;
        private string m_Country;
        private Decimal m_CreditCardLimit;
        private Decimal m_CreditCardBalance;
        private bool m_ActivationStatus;

        //Public Constructors & Destructor Methods



        public CreditCard()
        {
            this.m_CreditCardNumber = "";
            this.m_CreditCardOwnerName = "";
            this.m_CreditCardIssuingCompany = "";
            this.m_MerchantCode = 0;
            this.m_ExpDate = new DateTime().Date;
            this.m_AddressLine1 = "";
            this.m_AddressLine2 = "";
            this.m_City = "";
            this.m_State = "";
            this.m_ZipCode = "";
            this.m_Country = "";
            this.m_CreditCardLimit = 3000.0M;
            this.m_CreditCardBalance = 3000.0M;
            this.m_ActivationStatus = true;
        }


        public CreditCard(string creditCardNumber, string creditCardOwnerName,string creditCardIssuingCompany, int merchantCode,
            string expDate, string addressLine1, string addressLine2, string city, string state, string zipCode,
            string country, decimal creditcardLimit =3000.0M, decimal creditCardBalance = 3000.0M)
        {

            this.m_CreditCardNumber = creditCardNumber;
            this.m_CreditCardOwnerName = creditCardOwnerName;
            this.m_CreditCardIssuingCompany = creditCardIssuingCompany;
            this.m_MerchantCode = merchantCode;
            this.m_ExpDate = DateTime.Parse(expDate);
            this.m_AddressLine1 = addressLine1;
            this.m_AddressLine2 = addressLine2;
            this.m_City = city;
            this.m_State = state;
            this.m_ZipCode = zipCode;
            this.m_Country = country;
            this.m_CreditCardLimit = creditcardLimit;
            this.m_CreditCardBalance = creditCardBalance;
            this.m_ActivationStatus = true;
        }

        ~CreditCard() { }

        //Public Properties
        public string CreditCardNumber { get => m_CreditCardNumber; set => m_CreditCardNumber = value; }
        public string CreditCardOwnerName { get => m_CreditCardOwnerName; set => m_CreditCardOwnerName = value; }

        public string CreditCardIssuingCompany { get => m_CreditCardIssuingCompany; set => m_CreditCardIssuingCompany = value; }
        public int MerchantCode { get => m_MerchantCode; set => m_MerchantCode = value; }
        public DateTime ExpDate { get => m_ExpDate; set => m_ExpDate = value; }
        public string AddressLine1 { get => m_AddressLine1; set => m_AddressLine1 = value; }
        public string AddressLine2 { get => m_AddressLine2; set => m_AddressLine2 = value; }
        public string City { get => m_City; set => m_City = value; }
        public string State { get => m_State; set => m_State = value; }
        public string ZipCode { get => m_ZipCode; set => m_ZipCode = value; }
        public string Country { get => m_Country; set => m_Country = value; }
        public decimal CreditCardLimit { get => m_CreditCardLimit; set => m_CreditCardLimit = value; }
        public decimal CreditCardBalance { get => m_CreditCardBalance; set => m_CreditCardBalance = value; }
        public bool ActivationStatus { get => m_ActivationStatus; }


        //Public Instance Methods:
        public void Print()
        {
            try
            {
                //Step 1-Create object to open/create file for appending
                StreamWriter objPrinterFile = new StreamWriter("Network_Printer.txt", true);
                //Step 2-Write person's data to printer file
                objPrinterFile.WriteLine("The Credit Card Information: ");
                objPrinterFile.WriteLine("Credit Card Number = {0}", this.m_CreditCardNumber);
                objPrinterFile.WriteLine("Credit Card Name = {0}", this.m_CreditCardOwnerName);
                objPrinterFile.WriteLine("Credit Card Issuing Company = {0}", m_CreditCardIssuingCompany);
                objPrinterFile.WriteLine("Merchant Company Code = {0}", this.m_MerchantCode);
                objPrinterFile.WriteLine("Expiration Date = {0}", this.m_ExpDate);
                objPrinterFile.WriteLine("Billing Address Line 1 = {0}", this.m_AddressLine1);
                objPrinterFile.WriteLine("Billing Address Line 2 = {0}", this.m_AddressLine2);
                objPrinterFile.WriteLine("Billing City = {0}", this.m_City);
                objPrinterFile.WriteLine("Billing State = {0}", this.m_State);
                objPrinterFile.WriteLine("Billing Zipcode = {0}", this.m_ZipCode);
                objPrinterFile.WriteLine("Billing Country = {0}", this.m_Country);
                objPrinterFile.WriteLine("Credit Limit = {0}", this.m_CreditCardLimit);
                objPrinterFile.WriteLine("Credit Balance = {0}", this.m_CreditCardBalance);
                objPrinterFile.WriteLine("Activation Status = {0}", this.ActivationStatus);
                
                objPrinterFile.WriteLine();
                objPrinterFile.WriteLine();

                //Step 3-Close file
                objPrinterFile.Close();

            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }

        }

        public bool Activate()
        {
            m_ActivationStatus = true;
            return m_ActivationStatus;
        }

        public bool Deactivate()
        {
            m_ActivationStatus = false;
            return m_ActivationStatus;
        }


        //Public Instance & Static Data Access Methods:
        public bool Load(string key)
        {
            //Step 1 - Calls DALayer_Load(key) method to do the work
            return DALayer_Load(key);
        }

        public bool Insert()
        {
            //Step 1 - Calls DALayer_Inser() method to do the work
            return DALayer_Insert();
        }

        public bool Update()
        {
            //Step 1 - Calls DALayer_Update(key) method to do the work
            return DALayer_Update();
        }

        public bool Delete(string key)
        {
            //Step 1 - Calls DALayer_Delete(key) method to do the work
            return DALayer_Delete(key);
        }

        public static List<CreditCard> GetAllCreditCards()
        {
            return DALayer_GetAllCreditCards();
        }


        //Protected instance & Static data access methods:
        protected bool DALayer_Load(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                CreditCardDTO objCreditCardDTO = objCreditCardDAO.GetRecordByID(key);
                //Step 4- test if DTO object exists & populate this object with DTO object's properties
                //and return a true or return a False if no DTO object exists.
                if (objCreditCardDTO != null)
                {
                    //Step 4a-get the data from the Data Transfer Object
                    this.m_CreditCardNumber = objCreditCardDTO.CreditCardNumber;
                    this.m_CreditCardOwnerName = objCreditCardDTO.CreditCardOwnerName;
                    this.CreditCardIssuingCompany = objCreditCardDTO.CreditCardIssuingCompany;
                    this.m_MerchantCode = objCreditCardDTO.MerchantCode;
                    this.m_ExpDate = objCreditCardDTO.ExpDate;
                    this.m_AddressLine1 = objCreditCardDTO.AddressLine1;
                    this.m_AddressLine2 = objCreditCardDTO.AddressLine2;
                    this.m_City = objCreditCardDTO.City;
                    this.m_State = objCreditCardDTO.State;
                    this.m_ZipCode = objCreditCardDTO.ZipCode;
                    this.m_Country = objCreditCardDTO.Country;
                    this.m_CreditCardLimit = objCreditCardDTO.CreditCardLimit;
                    this.m_CreditCardBalance = objCreditCardDTO.CreditCardBalance;

                    //Handle activation status accordingly using methods
                    //since ActivationStutus property is read only
                    if (objCreditCardDTO.ActivationStatus == true)
                        this.Activate();
                    else
                        this.Deactivate();

                    //Step 4c-Returns a true since this class object has been populated.
                    return true;
                }
                else
                {
                    //Step 5- No object returned from DALayer, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Load(key) Method: {0} " + objE.Message);
            }
        }//End of metho



        protected bool DALayer_Insert()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.CreditCardIssuingCompany = this.CreditCardIssuingCompany;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.State = this.State;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;
                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool inserted = objCreditCardDAO.Insert(objCreditCardDTO);
                //Step 6- test if insert to database was successful return true,
                //otherwise return false
                if (inserted == true)
                {
                    //Step 6b-Returns a true since this class object has been inserted & marked as old.
                    return true;
                }
                else
                {
                    //Step 7- No record inserted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Insert() Method: {0} " + objE.Message);
            }
        }

        protected bool DALayer_Update()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-Create new Data Transfer Object to send to DA Later for DATA ACCESS LAYER
                CreditCardDTO objCreditCardDTO = new CreditCardDTO();
                //Step 4- POPULATE the Data Transfer Object with data from THIS OBJECT to send to database
                objCreditCardDTO.CreditCardNumber = this.CreditCardNumber;
                objCreditCardDTO.CreditCardOwnerName = this.CreditCardOwnerName;
                objCreditCardDTO.MerchantCode = this.MerchantCode;
                objCreditCardDTO.ExpDate = this.ExpDate;
                objCreditCardDTO.AddressLine1 = this.AddressLine1;
                objCreditCardDTO.AddressLine2 = this.AddressLine2;
                objCreditCardDTO.City = this.City;
                objCreditCardDTO.State = this.State;
                objCreditCardDTO.ZipCode = this.ZipCode;
                objCreditCardDTO.Country = this.Country;
                objCreditCardDTO.CreditCardLimit = this.CreditCardLimit;
                objCreditCardDTO.CreditCardBalance = this.CreditCardBalance;
                objCreditCardDTO.ActivationStatus = this.ActivationStatus;
                //Step 5-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool updated = objCreditCardDAO.Update(objCreditCardDTO);
                //Step 6- test if update to database was successful & MARK the object as old return true,
                //otherwise return false
                if (updated == true)
                {
                    //Step 6b-Returns a true since this class object has been updated.
                    return true;
                }
                else
                {
                    //Step 7- No record updated, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }

        protected bool DALayer_Delete(string key)
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the sql FACTORY data access object 
                //call the correct Data Access Object to perform the Data Access
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-Call DATA ACCESS LAYER CreditCardDAO Data Access Object to do the work
                bool deleted = objCreditCardDAO.Delete(key);
                //Step 4- Test if delete to database was successful & MARK the object as NEW since
                //deleted from database and NEW in memory and return a true, otherwise return false
                if (deleted == true)
                {
                    //Step 4b-Returns a true since this class object has been deleted & marked as NEW.
                    return true;
                }
                else
                {
                    //Step 5-No record deleted, return a false
                    return false;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw an general exceptions
                throw new Exception("Unexpected Error in DALayer_Update() Method: {0} " + objE.Message);
            }
        }


        protected static List<CreditCard> DALayer_GetAllCreditCards()
        {
            //Step A-Start Error Trapping
            try
            {
                //Step 1-Use DAL object Factory to get the SQL Server FACTORY Data Access Object
                //using POLYMORPHISM.
                DALObjectFactoryBase objDAOFactory =
                DALObjectFactoryBase.GetDataSourceDAOFactory(DALObjectFactoryBase.SQLSERVER);
                //Step 2-now that you have the SQL FACTORY object GET DAO object to do the work
                CreditCardDAO objCreditCardDAO = objDAOFactory.GetCreditCardDAO();
                //Step 3-call CreditCardDAO DAO to do the work & return COLLECTION of Data Transfer Objects
                List<CreditCardDTO> objCreditCardDTOList = objCreditCardDAO.GetAllRecords();
                //Step 4- test if List<CreditCardDTO> DTO collection exists 
                if (objCreditCardDTOList != null)
                {
                    //Step 5-Create a LIST Collection of CreditCard object to get copy of DTO collection
                    List<CreditCard> objCreditCardList = new List<CreditCard>();
                    //Step 6-Loop through List<CreditCardDTO> objCreditCardDTOList collection
                    foreach (CreditCardDTO objDTO in objCreditCardDTOList)
                    {
                        //Step 6a-Create new CreditCard object
                        CreditCard objCreditCard = new CreditCard();
                        //Step 6b-get the data from DTO object and SET CreditCard object
                        objCreditCard.CreditCardNumber = objDTO.CreditCardNumber;
                        objCreditCard.CreditCardOwnerName = objDTO.CreditCardOwnerName;
                        objCreditCard.MerchantCode = objDTO.MerchantCode;
                        objCreditCard.ExpDate = objDTO.ExpDate;
                        objCreditCard.AddressLine1 = objDTO.AddressLine1;
                        objCreditCard.AddressLine2 = objDTO.AddressLine2;
                        objCreditCard.City = objDTO.City;
                        objCreditCard.State = objDTO.State;
                        objCreditCard.ZipCode = objDTO.ZipCode;
                        objCreditCard.Country = objDTO.Country;
                        objCreditCard.CreditCardLimit = objDTO.CreditCardLimit;
                        objCreditCard.CreditCardBalance = objDTO.CreditCardBalance;

                        //Handle activation status accordingly since ActivationStutus property is read only
                        if (objDTO.ActivationStatus == true)
                            objCreditCard.Activate();
                        else
                            objCreditCard.Deactivate();

                        //Step 6c-Add CreditCard Object to the objCreditCardList List<CreditCard> COLLECTION 
                        objCreditCardList.Add(objCreditCard);
                    }//End of foreach
                     //Step 6d-once copy process ends, Return objCreditCardList List<CreditCard> COLLECTION
                    return objCreditCardList;
                }
                else
                {
                    //Step 6e- No DTO collection object returned from DALayer, return a null
                    return null;
                }
            }//End of try
             //Step B-Traps for general exception. 
            catch (Exception objE)
            {
                //Step C-Re-Throw a general exceptions
                throw new Exception("Unexpected Error in DALayer_GetAllCreditCards(key) Method: {0} " +
                objE.Message);
            }
        }
    } 
}





