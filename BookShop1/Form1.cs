using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        private void address_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox.AppendText("************Thank You************");

            string date = dateTextBox.Text;
            string customerName=nameTextBox.Text;
            string contactNo=contactNoTextBox.Text;
            string address = addressTextBox.Text ;
            string order = comboBox.Text;
            string quantity = quantityTextBox.Text;
            int totalPrice;
            if (date== dateTextBox.Text)
            {
                richTextBox.Text = ("Date : " + date);
            }
            richTextBox.Text += (Environment.NewLine);
          
            if (customerName == nameTextBox.Text)
            {
                richTextBox.AppendText("Customer Name :"+nameTextBox.Text);
            }
                richTextBox.Text += (Environment.NewLine);
          
           

            if (contactNo == contactNoTextBox.Text)
            {
                //richTextBox.Text = ("Contact No: "+contactNo);
                richTextBox.AppendText("Contact No :"+contactNoTextBox.Text);
            }
            richTextBox.Text += (Environment.NewLine);
            if (address == addressTextBox.Text)
            {
                //richTextBox.Text = ("Address : "+address);
                richTextBox.AppendText("Address :"+address);
                
            }
            richTextBox.Text += (Environment.NewLine);

            if(comboBox.Text=="Mathematics")
            {
                richTextBox.AppendText("Quantity:"+quantityTextBox.Text);
                richTextBox.Text += (Environment.NewLine);
                richTextBox.AppendText("Order : Mathematics");
                richTextBox.Text += (Environment.NewLine);
                int qty = Convert.ToInt32(quantityTextBox.Text);
                totalPrice = qty * 120;
                richTextBox.AppendText(Convert.ToString("TotalPrice :"+totalPrice));
            }
            if (comboBox.Text == "Bangla")
            {
                richTextBox.AppendText("Quantity:" + quantityTextBox.Text);
                richTextBox.Text += (Environment.NewLine);
                richTextBox.AppendText("Order : Bangla");
                richTextBox.Text += (Environment.NewLine);
                int qty = Convert.ToInt32(quantityTextBox.Text);
                totalPrice = qty * 90;
                richTextBox.AppendText(Convert.ToString("TotalPrice :" + totalPrice));
            }
            if (comboBox.Text == "English")
            {
                richTextBox.AppendText("Quantity:" + quantityTextBox.Text);
                richTextBox.Text += (Environment.NewLine);
                richTextBox.AppendText("Order : English");
                richTextBox.Text += (Environment.NewLine);
                int qty = Convert.ToInt32(quantityTextBox.Text);
                totalPrice = qty * 100;
                richTextBox.AppendText(Convert.ToString("TotalPrice :" + totalPrice));
            }
            if (comboBox.Text == "Art")
            {
                richTextBox.AppendText("Quantity:" + quantityTextBox.Text);
                richTextBox.Text += (Environment.NewLine);
                richTextBox.AppendText("Order : Art");
                richTextBox.Text += (Environment.NewLine);
                int qty = Convert.ToInt32(quantityTextBox.Text);
                totalPrice = qty * 80;
                richTextBox.AppendText(Convert.ToString("TotalPrice :" + totalPrice));
            }
            richTextBox.Text += (Environment.NewLine);
            richTextBox.Text += (Environment.NewLine);
            richTextBox.AppendText("************Thank You************");






        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
