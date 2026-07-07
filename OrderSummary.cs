using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaResturantProject
{
    public partial class OrderSummary : Form
    {
        public event Action SummaryClosedByButton;
        public OrderSummary()
        {
            InitializeComponent();
        }

        public void SetSummary(string size, string crust, string toppings, string whereToEat, string price)
        {
            lblSizes.Text = size;
            CrustTypelbl.Text = crust;
            tbToppings.Text = toppings;
            lblWhereToEat.Text = whereToEat;
            lblPrice.Text = price;
        }

        private void gbSummary_Paint(object sender, PaintEventArgs e)
        {
            gbSummary.BackColor = Color.FromArgb(40, Color.Black);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Order Placed Successfully :)", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SummaryClosedByButton?.Invoke(); 
            this.Close();
        }
    }
}
