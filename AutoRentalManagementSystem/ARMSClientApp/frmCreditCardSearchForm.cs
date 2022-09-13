using ARMSBOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSClientApp
{
    public partial class frmCreditCardSearch : Form
    {
        //Declare CreditCard object POINTER that can be seen by the entire form
        CreditCard objCreditCard;
        public frmCreditCardSearch()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                objCreditCard = new CreditCard();

                bool success = objCreditCard.Load(txtCardNum.Text.Trim());

                if (success)
                {
                    txtCreditCardNumber.Text = objCreditCard.CreditCardNumber;
                    txtCreditCardOwnerName.Text = objCreditCard.CreditCardOwnerName;
                    txtCreditCardCompany.Text = objCreditCard.CreditCardIssuingCompany;
                    txtMerchantCode.Text = Convert.ToString(objCreditCard.MerchantCode);
                    txtExpirationDate.Text = Convert.ToString(objCreditCard.ExpDate);
                    txtAddress1.Text = objCreditCard.AddressLine1;
                    txtAddress2.Text = objCreditCard.AddressLine2;
                    txtCity.Text = objCreditCard.City;
                    txtState.Text = objCreditCard.State;
                    txtZip.Text = objCreditCard.ZipCode;
                    txtCountry.Text = objCreditCard.Country;
                    txtCreditCardLimit.Text = Convert.ToString(objCreditCard.CreditCardLimit);
                    txtCreditLimitBalance.Text = Convert.ToString(objCreditCard.CreditCardBalance);
                    txtActivationStatus.Text = Convert.ToString(objCreditCard.ActivationStatus);

                }
                else
                {
                    MessageBox.Show("Customer Not Found");

                    txtCreditCardNumber.Text = "";
                    txtCreditCardOwnerName.Text = "";
                    txtCreditCardCompany.Text = "";
                    txtMerchantCode.Text = "";
                    txtExpirationDate.Text = "";
                    txtAddress1.Text = "";
                    txtAddress2.Text = "";
                    txtCity.Text = "";
                    txtState.Text = "";
                    txtZip.Text = "";
                    txtCountry.Text = "";
                    txtCreditCardLimit.Text = "";
                    txtCreditLimitBalance.Text = "";
                    txtActivationStatus.Text = "";
                }

            }
            catch(System.Exception)
            {

                MessageBox.Show("Error in Search");
                
            }
            

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(objCreditCard != null)
            {
                objCreditCard.Print();
                MessageBox.Show("Card information has been saved to Network_Printer.txt");
            }
            else
            {
                MessageBox.Show("Enter Credit Card Number in \"Credit Card Search\" Section");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
