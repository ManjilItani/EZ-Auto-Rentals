using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ARMSDALayer
{
    public abstract class DALObjectFactoryBase
    {
        //Public constant data members
        public const int SQLSERVER = 1;
        public const int ORACLE = 2;
        public const int MYSQL = 3;



        //public static methods

        public static DALObjectFactoryBase GetDataSourceDAOFactory(int targetDataSourceFactory) 
        {

            switch(targetDataSourceFactory)
                 {
                 case 1: //MS SQLServer Data Source
                    return new SQLServerDAOFactory();
                 case 2: //Oracle Data Source
                    throw new NotImplementedException();
                case 3: //MySQL Data Source
                    throw new NotImplementedException();
                                //case X: other data sources for this application here
                default: //Default valued returned when options not a case
                    return null;
                            }

        }

        public abstract CreditCardDAO GetCreditCardDAO();
       // public abstract USStateDAO GetUSStateDAO();
       // public abstract CountryDAO GetCountryDAO();

    }
}
