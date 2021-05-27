using System;
using CustomerData;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * to calculate electricity bill for diffrent type of customers and store it in a file
 * it also auto increments the Account number and gives stastics about customer history
 * Author: Dhaval Shah
 * When: Dec 2020
 */
namespace lab1
{
    public partial class Form1 : Form
    {   //to give customer types to combobox
        string[] custType = { "Residential", "Commercial", "Industrial" };
        public string type;
        //list used for saving data
        List<CustomerM> customers;
        //to give charged amount to constructor
        decimal charge = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // combobox for selecting customer type
        private void cobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields();
            //to set background image and set other fileds visible at related customer type
            int s = cobox.SelectedIndex;
            //for residential
            if (s == 0)
            {
                this.BackgroundImage = Image.FromFile("..\\..\\images\\Residential.jpg");
                kwh.Text = "kilowatt-hour Used by your house";
                type = "R";
                kwh.Visible = true;
                txtKwh.Visible = true;
                txtoff.Visible = false;
                txtpick.Visible = false;
                pick.Visible = false;
                offpick.Visible = false;
            }
            //for commercial
            else if (s == 1)
            {
                this.BackgroundImage = Image.FromFile("..\\..\\images\\commercial.jpg");
                kwh.Text = "KWH Used by your Commercial business";
                type = "C";
                kwh.Visible = true;
                txtKwh.Visible = true;
                txtoff.Visible = false;
                txtpick.Visible = false;
                pick.Visible = false;
                offpick.Visible = false;
            }
            //for industrial
            else
            {
                this.BackgroundImage = Image.FromFile("..\\..\\images\\industrial.jpg");
                type = "I";
                kwh.Visible = false;
                txtKwh.Visible = false;
                txtoff.Visible = true;
                txtpick.Visible = true;
                pick.Visible = true;
                offpick.Visible = true;

            }
        }
        //to set by default image and by default customer type
        private void Form1_Load(object sender, EventArgs e)
        {
            cobox.Items.Clear();
            foreach (string size in custType)
            {
                cobox.Items.Add(size);
            }
            
            cobox.SelectedIndex = 0;
            //to read data from file and store it in list
            customers = DBacess.GetCustomers();
            //display in a listbox and update the stastics
            DisplayCustomers();
            Updatecounts();
        }
        // calculate button
        private void calculate_Click(object sender, EventArgs e)
        {
            int kwhused = 0;
            int kwhusedp=0;
            int kwhusedo=0;
            kwhused=assign(txtKwh.Text);
            kwhusedp=assign(txtpick.Text);
            kwhusedo=assign(txtoff.Text);
            //for residential
            if (type == "R")
            {
                if (txtKwh.Text != "")//if there is no input then calculate button is not going to work
                {
                    Resident r = new Resident(Accountnumber.Text, Custname.Text, type);
                    charge = r.Calculate(kwhused, kwhusedp, kwhusedo);
                    txtBill.Text = charge.ToString("c");
                    Resident.TotalRcust++;
                    Resident.TotalRcharge = Resident.TotalRcharge + charge;
                }
            }
            //for Commercial
            else if(type == "C")
            {
                if (txtKwh.Text != "")//if there is no input then calculate button is not going to work
                {
                    Commercial c = new Commercial(Accountnumber.Text, Custname.Text, type);
                    charge = c.Calculate(kwhused, kwhusedp, kwhusedo);
                    txtBill.Text = charge.ToString("c");
                    Commercial.TotalCcust++;
                    Commercial.TotalCcharge = Commercial.TotalCcharge + charge;
                }
            }
            //for industrial
            else
            {
                if (txtpick.Text != "" || txtoff.Text != "")//if both input is null then calculate button is not going to work
                {
                    Industrial i = new Industrial(Accountnumber.Text, Custname.Text, type);
                    charge = i.Calculate(kwhused, kwhusedp, kwhusedo);
                    txtBill.Text = charge.ToString("c");
                    Industrial.TotalIcust++;
                    Industrial.TotalIcharge = Industrial.TotalIcharge + charge;
                }
            }
            
            
        }
        //to assign textbox string in to variable 
        private int assign(string a)
        {
            int x;
            if (a == "")
            {
                x = 0; 
            }
            else
            {
                x = Convert.ToInt32(a);
            }
            return x;
        }
        // clear button
        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtKwh.Focus();
        }
        //exit button
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //to display in listbox
        public void DisplayCustomers()
        {
            ListCust.Items.Clear();
            foreach (CustomerM c in customers)
            {
                ListCust.Items.Add(c.ToDisplay());
            }
        }
        //to update stastics
        public void Updatecounts()
        {
            Accountnumber.Text = Convert.ToString(CustomerM.AutoAccNO);
            Rcust.Text = Convert.ToString(Resident.TotalRcust);
            Ccust.Text = Convert.ToString(Commercial.TotalCcust);
            Icust.Text = Convert.ToString(Industrial.TotalIcust);
            Tcust.Text = Convert.ToString(CustomerM.TotalCust);
            Rcharge.Text = Convert.ToString(Resident.TotalRcharge);
            Ccharge.Text = Convert.ToString(Commercial.TotalCcharge);
            Icharge.Text = Convert.ToString(Industrial.TotalIcharge);
            Tcharge.Text = Convert.ToString(CustomerM.TotalCharge);
        }
        //clear all fields
        public void ClearFields()
        {
            txtBill.Text = "";
            txtKwh.Text = "";
            txtpick.Text = "";
            txtoff.Text = "";
            Custname.Text = "";
        }
        // to limit the input with keypress event for kwh fields
        private void txtpick_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && // numbers are allowed
                e.KeyChar != (char)Keys.Back // backspace is allowed
                )
            {
                e.Handled = true;
            }
        }
        private void txtoff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && // numbers are allowed
                e.KeyChar != (char)Keys.Back // backspace is allowed
                )
            {
                e.Handled = true;
            }
        }
        private void txtkwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && // numbers are allowed
                e.KeyChar != (char)Keys.Back // backspace is allowed
                )
            {
                e.Handled = true;
            }
        }
        //to add new customer data in file
        private void add_Click(object sender, EventArgs e)
        {
            if (Custname.Text != "" && txtBill.Text != "")//if there is name and some charges in fields then save is going to work
            {
                CustomerM C = new CustomerM(Accountnumber.Text, Custname.Text, type, charge);
                CustomerM.AutoAccNO++;
                CustomerM.TotalCust++;
                CustomerM.TotalCharge = CustomerM.TotalCharge + C.ChargeAmount;
                customers.Add(C);
                DBacess.SaveCustomers(customers);
                Updatecounts();
                DisplayCustomers();
            }
        }
    }
}
