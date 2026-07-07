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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private void BtnStartOrder_Click (object sender, EventArgs e)
        {
            Form StartOrderForm = new Order_Form1();
            StartOrderForm.Show();
        }
        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            Form AboutUsForm = new About_Us_Form();
            AboutUsForm.Show();
        }
    }
}
