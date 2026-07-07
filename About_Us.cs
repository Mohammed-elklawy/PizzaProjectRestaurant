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
    public partial class About_Us_Form : Form
    {
        public About_Us_Form()
        {
            InitializeComponent();
        }

        private void About_Us_Form_Load(object sender, EventArgs e)
        {
            lblAboutUs.Text = "🍕 Welcome to Pizza Hunters!\n\n" +
                   "At Pizza Hunters, we believe pizza is more than food – " +
                   "it's an adventure. Our mission is to hunt down the freshest " +
                   "ingredients and craft mouth‑watering pizzas that bring people together.\n\n" +
                   "From classic Margherita to bold new flavors, every slice tells " +
                   "a story of passion, taste, and fun.\n\n" +
                   "Join the hunt. Taste the adventure!";
            lblAboutUs.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblAboutUs.ForeColor = Color.White;
            lblAboutUs.BackColor = Color.FromArgb(100, Color.Maroon); // خلفية شفافة بسيطة
            lblAboutUs.AutoSize = false;
            lblAboutUs.Size = new Size(450, 450);
            lblAboutUs.Padding = new Padding(10);
            lblAboutUs.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
