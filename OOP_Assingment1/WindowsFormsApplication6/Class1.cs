using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication6
{
    class AccountDetail
    {
        private double dollar
        {
            get
            {
                return 110.74;
            }
        }
        private double yen{
             get
            {
                return 0.98;
            }
        }
        private double dinar{
     get
            {
                return 10.62;
            }
        }
        private double pound {
     get
            {
                return 157.05;
            }
        }
        
        private string[,] arr;
        public void ClearTexboxes(TextBox acc_Title, TextBox netAmmount, TextBox afterSalesTaxDeduction, TextBox todayTaxRate, TextBox inDollar, TextBox inYen, TextBox inDinar, TextBox inPounds)
        {
            acc_Title.Clear();
            netAmmount.Clear();
            afterSalesTaxDeduction.Clear();
            todayTaxRate.Clear();
            inDollar.Clear();
            inDinar.Clear();
            inYen.Clear();
            inPounds.Clear();
        }
        public void ShowDetail(TextBox acc_Title, TextBox netAmmount, TextBox afterSalesTaxDeduction,TextBox todayTaxRate,TextBox inDollar, TextBox inYen , TextBox inDinar , TextBox inPounds)
        {
            try
            {

                arr = new string[5, 2];
                arr[0, 0] = "amir";
                arr[0, 1] = "5000";
                arr[1, 0] = "yosuf";
                arr[1, 1] = "3000";
                arr[2, 0] = "hiba";
                arr[2, 1] = "6000";
                arr[3, 0] = "Ali";
                arr[3, 1] = "4000";
                arr[4, 0] = "shahrukh";
                arr[4, 1] = "100000";
                bool check = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == 5)
                    {
                        break;
                    }

                    if (acc_Title.Text == arr[i, 0])
                    {
                        netAmmount.Text = arr[i, 1];
                        double temp = double.Parse(netAmmount.Text) - double.Parse(todayTaxRate.Text);
                        afterSalesTaxDeduction.Text = temp.ToString();
                        double temp2 = double.Parse(afterSalesTaxDeduction.Text) / dollar;

                        double temp3 = double.Parse(afterSalesTaxDeduction.Text) * yen;
                        double temp4 = double.Parse(afterSalesTaxDeduction.Text) * dinar;
                        double temp5 = double.Parse(afterSalesTaxDeduction.Text) / pound;
                        inDollar.Text = temp2.ToString();
                        inYen.Text = temp3.ToString();
                        inDinar.Text = temp4.ToString();
                        inPounds.Text = temp5.ToString();


                        check = true;
                        break;

                    }
                    

                }
                if (check == false)
                {
                    MessageBox.Show("Error: No User Found");
                    ClearTexboxes(acc_Title, netAmmount, afterSalesTaxDeduction, todayTaxRate, inDollar, inYen, inDinar, inPounds);
                }

            }

            catch(Exception)//For Catching SaleTax Calucation Runtime error (usally occurs when following textbox=null)
            {
                string msg = "*Dear You User You may have not Fill All required field properly or you have Input wrong value in Tax Rate*".ToUpper();
                MessageBox.Show(msg);
            }

                //if (acc_Title.Text.ToString().ToLower()=="irfan")
                //{
                //    netAmmount.Text = irfan_Balance.ToString();
                //    netAmmount.Show();
                //    double temp = irfan_Balance-int.Parse(todayTaxRate.Text);
                //    afterSalesTaxDeduction.Text = temp.ToString();
                //}
                //else if(acc_Title.Text.ToString().ToLower()=="imran")
                //{
                //    netAmmount.Text = imran_Balance.ToString();
                //    netAmmount.Show();
                //    double temp = imran_Balance - int.Parse(todayTaxRate.Text);
                //    afterSalesTaxDeduction.Text = temp.ToString();
                //}
                //else if (acc_Title.Text.ToString().ToLower()=="zakir")
                //{
                //    netAmmount.Text = zakir_Balance.ToString();
                //    netAmmount.Show();
                //    double temp = zakir_Balance - int.Parse(todayTaxRate.Text);
                //    afterSalesTaxDeduction.Text = temp.ToString();
                //}
                //else if (acc_Title.Text.ToString().ToLower()=="hiba")
                //{
                //    netAmmount.Text = hiba_Balance.ToString();
                //    netAmmount.Show();
                //    double temp = hiba_Balance - int.Parse(todayTaxRate.Text);
                //    afterSalesTaxDeduction.Text = temp.ToString();
                //}
                //else if (acc_Title.Text.ToString().ToLower()=="sami")
                //{
                //    netAmmount.Text = sami_Balance.ToString();
                //    netAmmount.Show();
                //    double temp = sami_Balance - int.Parse(todayTaxRate.Text);
                //    afterSalesTaxDeduction.Text = temp.ToString();
                //}
                //else
                //{
                //    MessageBox.Show("user Not Found");
                //}
              
       
       
            }


        public void disableTexboxes(TextBox a, TextBox b, TextBox inDollar, TextBox inYen, TextBox inDinar, TextBox inPound)//Method For Disabling TextBoxes
        {
            a.Enabled = false;
            b.Enabled = false;
            inDollar.Enabled = false;
            inYen.Enabled = false;
            inDinar.Enabled = false;
            inPound.Enabled = false;
           
            
        }
        
        
    }
}
