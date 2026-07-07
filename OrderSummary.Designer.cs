namespace PizzaResturantProject
{
    partial class OrderSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSummary));
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToppings = new System.Windows.Forms.TextBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.CrustTypelbl = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizes = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSummary
            // 
            this.gbSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbSummary.Controls.Add(this.lblSizes);
            this.gbSummary.Controls.Add(this.lblWhereToEat);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.tbToppings);
            this.gbSummary.Controls.Add(this.lblToppings);
            this.gbSummary.Controls.Add(this.lblPrice);
            this.gbSummary.Controls.Add(this.CrustTypelbl);
            this.gbSummary.Controls.Add(this.toppings);
            this.gbSummary.Controls.Add(this.lblCrust);
            this.gbSummary.Controls.Add(this.lblSize);
            this.gbSummary.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbSummary.ForeColor = System.Drawing.Color.Ivory;
            this.gbSummary.Location = new System.Drawing.Point(78, 24);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(434, 550);
            this.gbSummary.TabIndex = 9;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            this.gbSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.gbSummary_Paint);
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.Maroon;
            this.lblWhereToEat.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWhereToEat.Location = new System.Drawing.Point(242, 409);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(39, 37);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(18, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Where To Eat : ";
            // 
            // tbToppings
            // 
            this.tbToppings.BackColor = System.Drawing.Color.White;
            this.tbToppings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbToppings.Enabled = false;
            this.tbToppings.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToppings.ForeColor = System.Drawing.Color.Maroon;
            this.tbToppings.Location = new System.Drawing.Point(25, 223);
            this.tbToppings.Multiline = true;
            this.tbToppings.Name = "tbToppings";
            this.tbToppings.Size = new System.Drawing.Size(276, 167);
            this.tbToppings.TabIndex = 2;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblToppings.Location = new System.Drawing.Point(20, 210);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(0, 30);
            this.lblToppings.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Orange;
            this.lblPrice.Font = new System.Drawing.Font("Aardvark", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(79, 475);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(167, 54);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price : ";
            // 
            // CrustTypelbl
            // 
            this.CrustTypelbl.AutoSize = true;
            this.CrustTypelbl.BackColor = System.Drawing.Color.Maroon;
            this.CrustTypelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CrustTypelbl.Location = new System.Drawing.Point(205, 115);
            this.CrustTypelbl.Name = "CrustTypelbl";
            this.CrustTypelbl.Size = new System.Drawing.Size(39, 37);
            this.CrustTypelbl.TabIndex = 1;
            this.CrustTypelbl.Text = "--";
            // 
            // toppings
            // 
            this.toppings.AutoSize = true;
            this.toppings.Font = new System.Drawing.Font("Segoe UI", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toppings.ForeColor = System.Drawing.Color.Snow;
            this.toppings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toppings.Location = new System.Drawing.Point(19, 165);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(177, 42);
            this.toppings.TabIndex = 0;
            this.toppings.Text = "Toppings : ";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Segoe UI", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCrust.ForeColor = System.Drawing.Color.Snow;
            this.lblCrust.Location = new System.Drawing.Point(18, 115);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(181, 38);
            this.lblCrust.TabIndex = 0;
            this.lblCrust.Text = "Crust Type : ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 23F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSize.ForeColor = System.Drawing.Color.Snow;
            this.lblSize.Location = new System.Drawing.Point(19, 55);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(102, 42);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size : ";
            // 
            // lblSizes
            // 
            this.lblSizes.AutoSize = true;
            this.lblSizes.BackColor = System.Drawing.Color.Maroon;
            this.lblSizes.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSizes.Location = new System.Drawing.Point(127, 60);
            this.lblSizes.Name = "lblSizes";
            this.lblSizes.Size = new System.Drawing.Size(39, 37);
            this.lblSizes.TabIndex = 9;
            this.lblSizes.Text = "--";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Aardvark", 18F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.Location = new System.Drawing.Point(574, 565);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(175, 62);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm ";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 639);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToppings;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label CrustTypelbl;
        private System.Windows.Forms.Label toppings;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizes;
        private System.Windows.Forms.Button btnConfirm;
    }
}