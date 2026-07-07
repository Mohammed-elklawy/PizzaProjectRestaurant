using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PizzaResturantProject
{
    public partial class Order_Form1 : Form
    {

        protected 
        float _Price = 20.00f;  
        int _toppings = 0;
        
        public Order_Form1()
        {
            InitializeComponent();
            rdbSmall.Checked = true;
          
        }
        private void UpdatePrice()
        {
            int basePrice = 0;

            if (rdbSmall.Checked) basePrice = 20;
            else if (rdbMedium.Checked) basePrice = 30;
            else if (rdbLarge.Checked) basePrice = 40;

            int crustAddon = 0;
            if (rdbThick.Checked) crustAddon = 5;

            _Price = basePrice + crustAddon + _toppings;
            lblPrice.Text = "Price : " + _Price.ToString() + "$";
        }

        private void AddPuncitution()
        {
           if (tbToppings.Text != "")
            {
                tbToppings.Text += ", ";
            }
        }

        private void AddToppings(CheckBox cb)
        {
            if (!tbToppings.Text.Contains(cb.Text))
            {
                AddPuncitution();
                tbToppings.Text += cb.Text;
            }
        }

        private void RemoveTopping (CheckBox ch)
        {
            string item = ", " + ch.Text;

            if (tbToppings.Text.Contains(item))
            {
                tbToppings.Text = tbToppings.Text.Replace(item, "");
            }
            else if (tbToppings.Text.StartsWith(ch.Text))
            {
                tbToppings.Text = tbToppings.Text.Replace(ch.Text, "");
            }
            tbToppings.Text = tbToppings.Text.Trim().Trim(',');
        }
        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Sizelbl.Text = "Small";
            UpdatePrice();  
        }
     
        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Sizelbl.Text = "Medium";
            UpdatePrice();
        }
        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Sizelbl.Text = "Large";
            UpdatePrice();
        }
        private void rdbThick_CheckedChanged(object sender, EventArgs e)
        {
            CrustTypelbl.Text = rdbThick.Text;
            UpdatePrice();
        }  
        private void rdbThinC_CheckedChanged(object sender, EventArgs e)
        {
            CrustTypelbl.Text = rdbThinC.Text;
        }

        private void rdbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = rdbEatin.Text;
        }

        private void rdbTakeOut_CheckChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = rdbTakeOut.Text;
        }
        private void cBExtraChe_CheckedChanged(object sender, EventArgs e)
        {
            if (cBExtraChe.Checked)
            {
                _toppings += 5;
                AddToppings(cBExtraChe);
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cBExtraChe);
            }
               UpdatePrice();
        }

        private void cBMashroms_CheckedChanged(object sender, EventArgs e)
        {
            if (cBMashroms.Checked)
            {
                _toppings += 5;
                AddToppings(cBMashroms);
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cBMashroms);
            }
            UpdatePrice();
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnions.Checked)
            {
                _toppings += 5;
                AddToppings(cbOnions);    
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cbOnions);
            }
            UpdatePrice();

        }

        private void cBTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (cBTomatoes.Checked)
            {
                _toppings += 5;
                AddToppings(cBTomatoes);
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cBTomatoes);
            }
            UpdatePrice();

        }

        private void cBOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cBOlives.Checked)
            {
                _toppings += 5;
                AddToppings(cBOlives);
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cBOlives);
            }
            UpdatePrice();

        }

        private void cBGreenP_CheckedChanged(object sender, EventArgs e)
        {
            if (cBGreenP.Checked)
            {
                _toppings += 5;
                AddToppings(cBGreenP);
            }
            else
            {
                _toppings -= 5;
                RemoveTopping(cBGreenP);
            }
            UpdatePrice();
        }
        private void gbToppings_Paint(object sender, PaintEventArgs e)
        {
            gbToppings.BackColor = Color.FromArgb(40, Color.Black);

        }

        private void gbSummary_Paint(object sender, PaintEventArgs e)
        {
            gbSummary.BackColor = Color.FromArgb(40, Color.Black);

        }

        private void gbWhereToE_Paint(object sender, PaintEventArgs e)
        {
            gbWhereToE.BackColor = Color.FromArgb(40, Color.Black);

        }

        private void gbCrust_Paint(object sender, PaintEventArgs e)
        {
            gbCrust.BackColor = Color.FromArgb(40, Color.Black);

        }
        private void GBSize_Paint(object sender, PaintEventArgs e)
        {
            GBSize.BackColor = Color.FromArgb(40, Color.Black);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           if
            (MessageBox.Show("Do You Want To Confirm This Order ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {

                OrderSummary summary = new OrderSummary();
                summary.SetSummary(Sizelbl.Text,CrustTypelbl.Text,tbToppings.Text,lblWhereToEat.Text,lblPrice.Text);
                summary.Show();
                summary.SummaryClosedByButton += () =>
                {
                    ResetForm();
                    MessageBox.Show("Lets Start New Order!","Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                };

            }
            
        }

        private void ResetForm()
        {
            GBSize.Tag = "skip";
            foreach (Control group in this.Controls)
            {
                if (group is GroupBox && group.Tag != "skip" || group is Panel)
                {
                    foreach (Control ctrl in group.Controls)
                    {
                        // استثناء أي كنترول عليه Tag = "skip"
                        if (ctrl.Tag?.ToString() == "skip")
                            continue;

                        if (ctrl is System.Windows.Forms.TextBox)
                            ((System.Windows.Forms.TextBox)ctrl).Clear();

                        else if (ctrl is System.Windows.Forms.CheckBox)
                            ((CheckBox)ctrl).Checked = false;

                        else if (ctrl is System.Windows.Forms.RadioButton)
                            ((RadioButton)ctrl).Checked = false;
                    }
                }
                else if (group is System.Windows.Forms.Label)
                {
                    ((System.Windows.Forms.Label)group).Text = "--";
                }
            }
            CrustTypelbl.Text = "-";
            lblWhereToEat.Text = "-";
            _toppings = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
