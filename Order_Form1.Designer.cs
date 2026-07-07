namespace PizzaResturantProject
{
    partial class Order_Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being useI Island to you seven to whom should I d.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Form1));
            this.GBSize = new System.Windows.Forms.GroupBox();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rdbThick = new System.Windows.Forms.RadioButton();
            this.rdbThinC = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBGreenP = new System.Windows.Forms.CheckBox();
            this.cBOlives = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.cBTomatoes = new System.Windows.Forms.CheckBox();
            this.cBMashroms = new System.Windows.Forms.CheckBox();
            this.cBExtraChe = new System.Windows.Forms.CheckBox();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToppings = new System.Windows.Forms.TextBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.CrustTypelbl = new System.Windows.Forms.Label();
            this.toppings = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.Sizelbl = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbWhereToE = new System.Windows.Forms.GroupBox();
            this.rdbTakeOut = new System.Windows.Forms.RadioButton();
            this.rdbEatin = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.GBSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbSummary.SuspendLayout();
            this.gbWhereToE.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSize
            // 
            this.GBSize.BackColor = System.Drawing.Color.Transparent;
            this.GBSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GBSize.Controls.Add(this.rdbLarge);
            this.GBSize.Controls.Add(this.rdbMedium);
            this.GBSize.Controls.Add(this.rdbSmall);
            this.GBSize.Font = new System.Drawing.Font("Segoe UI", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GBSize.ForeColor = System.Drawing.Color.Ivory;
            this.GBSize.Location = new System.Drawing.Point(13, 7);
            this.GBSize.Name = "GBSize";
            this.GBSize.Size = new System.Drawing.Size(284, 273);
            this.GBSize.TabIndex = 5;
            this.GBSize.TabStop = false;
            this.GBSize.Text = "Size";
            this.GBSize.Paint += new System.Windows.Forms.PaintEventHandler(this.GBSize_Paint);
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.BackColor = System.Drawing.Color.Maroon;
            this.rdbLarge.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbLarge.FlatAppearance.BorderSize = 2;
            this.rdbLarge.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdbLarge.ForeColor = System.Drawing.Color.Ivory;
            this.rdbLarge.Location = new System.Drawing.Point(84, 199);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(102, 41);
            this.rdbLarge.TabIndex = 2;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = false;
            this.rdbLarge.CheckedChanged += new System.EventHandler(this.rdbLarge_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.BackColor = System.Drawing.Color.Maroon;
            this.rdbMedium.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbMedium.FlatAppearance.BorderSize = 2;
            this.rdbMedium.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdbMedium.ForeColor = System.Drawing.Color.Ivory;
            this.rdbMedium.Location = new System.Drawing.Point(68, 133);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(135, 41);
            this.rdbMedium.TabIndex = 1;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = false;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbSmall
            // 
            this.rdbSmall.AutoSize = true;
            this.rdbSmall.BackColor = System.Drawing.Color.Maroon;
            this.rdbSmall.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbSmall.FlatAppearance.BorderSize = 2;
            this.rdbSmall.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rdbSmall.ForeColor = System.Drawing.Color.Ivory;
            this.rdbSmall.Location = new System.Drawing.Point(84, 69);
            this.rdbSmall.Name = "rdbSmall";
            this.rdbSmall.Size = new System.Drawing.Size(104, 41);
            this.rdbSmall.TabIndex = 0;
            this.rdbSmall.Text = "Small";
            this.rdbSmall.UseVisualStyleBackColor = false;
            this.rdbSmall.CheckedChanged += new System.EventHandler(this.rdbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rdbThick);
            this.gbCrust.Controls.Add(this.rdbThinC);
            this.gbCrust.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbCrust.ForeColor = System.Drawing.SystemColors.Window;
            this.gbCrust.Location = new System.Drawing.Point(13, 292);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(284, 219);
            this.gbCrust.TabIndex = 6;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust";
            this.gbCrust.Paint += new System.Windows.Forms.PaintEventHandler(this.gbCrust_Paint);
            // 
            // rdbThick
            // 
            this.rdbThick.AutoSize = true;
            this.rdbThick.BackColor = System.Drawing.Color.Maroon;
            this.rdbThick.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbThick.FlatAppearance.BorderSize = 2;
            this.rdbThick.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThick.ForeColor = System.Drawing.Color.White;
            this.rdbThick.Location = new System.Drawing.Point(58, 137);
            this.rdbThick.Name = "rdbThick";
            this.rdbThick.Size = new System.Drawing.Size(153, 36);
            this.rdbThick.TabIndex = 4;
            this.rdbThick.Text = "Thick Crust";
            this.rdbThick.UseVisualStyleBackColor = false;
            this.rdbThick.CheckedChanged += new System.EventHandler(this.rdbThick_CheckedChanged);
            // 
            // rdbThinC
            // 
            this.rdbThinC.AutoSize = true;
            this.rdbThinC.BackColor = System.Drawing.Color.Maroon;
            this.rdbThinC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbThinC.FlatAppearance.BorderSize = 2;
            this.rdbThinC.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThinC.ForeColor = System.Drawing.Color.White;
            this.rdbThinC.Location = new System.Drawing.Point(58, 72);
            this.rdbThinC.Name = "rdbThinC";
            this.rdbThinC.Size = new System.Drawing.Size(143, 36);
            this.rdbThinC.TabIndex = 3;
            this.rdbThinC.Text = "Thin Crust";
            this.rdbThinC.UseVisualStyleBackColor = false;
            this.rdbThinC.CheckedChanged += new System.EventHandler(this.rdbThinC_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Orange;
            this.lblPrice.Font = new System.Drawing.Font("Aardvark", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(49, 484);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(154, 49);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price : ";
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbToppings.Controls.Add(this.label1);
            this.gbToppings.Controls.Add(this.cBGreenP);
            this.gbToppings.Controls.Add(this.cBOlives);
            this.gbToppings.Controls.Add(this.cbOnions);
            this.gbToppings.Controls.Add(this.cBTomatoes);
            this.gbToppings.Controls.Add(this.cBMashroms);
            this.gbToppings.Controls.Add(this.cBExtraChe);
            this.gbToppings.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbToppings.ForeColor = System.Drawing.Color.Ivory;
            this.gbToppings.Location = new System.Drawing.Point(312, 12);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(296, 256);
            this.gbToppings.TabIndex = 7;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings     ";
            this.gbToppings.Paint += new System.Windows.Forms.PaintEventHandler(this.gbToppings_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(158, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "😋";
            // 
            // cBGreenP
            // 
            this.cBGreenP.AutoSize = true;
            this.cBGreenP.BackColor = System.Drawing.Color.Maroon;
            this.cBGreenP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cBGreenP.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGreenP.ForeColor = System.Drawing.Color.Ivory;
            this.cBGreenP.Location = new System.Drawing.Point(15, 103);
            this.cBGreenP.Name = "cBGreenP";
            this.cBGreenP.Size = new System.Drawing.Size(159, 34);
            this.cBGreenP.TabIndex = 0;
            this.cBGreenP.Text = "Green Pepers";
            this.cBGreenP.UseVisualStyleBackColor = false;
            this.cBGreenP.CheckedChanged += new System.EventHandler(this.cBGreenP_CheckedChanged);
            // 
            // cBOlives
            // 
            this.cBOlives.AutoSize = true;
            this.cBOlives.BackColor = System.Drawing.Color.Maroon;
            this.cBOlives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cBOlives.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBOlives.ForeColor = System.Drawing.Color.Ivory;
            this.cBOlives.Location = new System.Drawing.Point(181, 199);
            this.cBOlives.Name = "cBOlives";
            this.cBOlives.Size = new System.Drawing.Size(91, 34);
            this.cBOlives.TabIndex = 0;
            this.cBOlives.Text = "Olives";
            this.cBOlives.UseVisualStyleBackColor = false;
            this.cBOlives.CheckedChanged += new System.EventHandler(this.cBOlives_CheckedChanged);
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.BackColor = System.Drawing.Color.Maroon;
            this.cbOnions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbOnions.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnions.ForeColor = System.Drawing.Color.Ivory;
            this.cbOnions.Location = new System.Drawing.Point(181, 140);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(99, 34);
            this.cbOnions.TabIndex = 0;
            this.cbOnions.Text = "Onions";
            this.cbOnions.UseVisualStyleBackColor = false;
            this.cbOnions.CheckedChanged += new System.EventHandler(this.cbOnions_CheckedChanged);
            // 
            // cBTomatoes
            // 
            this.cBTomatoes.AutoSize = true;
            this.cBTomatoes.BackColor = System.Drawing.Color.Maroon;
            this.cBTomatoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cBTomatoes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTomatoes.ForeColor = System.Drawing.Color.Ivory;
            this.cBTomatoes.Location = new System.Drawing.Point(15, 154);
            this.cBTomatoes.Name = "cBTomatoes";
            this.cBTomatoes.Size = new System.Drawing.Size(126, 34);
            this.cBTomatoes.TabIndex = 0;
            this.cBTomatoes.Text = "Tomatoes";
            this.cBTomatoes.UseVisualStyleBackColor = false;
            this.cBTomatoes.CheckedChanged += new System.EventHandler(this.cBTomatoes_CheckedChanged);
            // 
            // cBMashroms
            // 
            this.cBMashroms.AutoSize = true;
            this.cBMashroms.BackColor = System.Drawing.Color.Maroon;
            this.cBMashroms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cBMashroms.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMashroms.ForeColor = System.Drawing.Color.Ivory;
            this.cBMashroms.Location = new System.Drawing.Point(15, 199);
            this.cBMashroms.Name = "cBMashroms";
            this.cBMashroms.Size = new System.Drawing.Size(131, 34);
            this.cBMashroms.TabIndex = 0;
            this.cBMashroms.Text = "Mashroms";
            this.cBMashroms.UseVisualStyleBackColor = false;
            this.cBMashroms.CheckedChanged += new System.EventHandler(this.cBMashroms_CheckedChanged);
            // 
            // cBExtraChe
            // 
            this.cBExtraChe.AutoSize = true;
            this.cBExtraChe.BackColor = System.Drawing.Color.Maroon;
            this.cBExtraChe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cBExtraChe.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBExtraChe.ForeColor = System.Drawing.Color.Ivory;
            this.cBExtraChe.Location = new System.Drawing.Point(15, 59);
            this.cBExtraChe.Margin = new System.Windows.Forms.Padding(7);
            this.cBExtraChe.Name = "cBExtraChe";
            this.cBExtraChe.Size = new System.Drawing.Size(154, 34);
            this.cBExtraChe.TabIndex = 0;
            this.cBExtraChe.Text = "Extra Cheese";
            this.cBExtraChe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBExtraChe.UseVisualStyleBackColor = false;
            this.cBExtraChe.CheckedChanged += new System.EventHandler(this.cBExtraChe_CheckedChanged);
            // 
            // gbSummary
            // 
            this.gbSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbSummary.Controls.Add(this.lblWhereToEat);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.tbToppings);
            this.gbSummary.Controls.Add(this.lblToppings);
            this.gbSummary.Controls.Add(this.lblPrice);
            this.gbSummary.Controls.Add(this.CrustTypelbl);
            this.gbSummary.Controls.Add(this.toppings);
            this.gbSummary.Controls.Add(this.lblCrust);
            this.gbSummary.Controls.Add(this.Sizelbl);
            this.gbSummary.Controls.Add(this.lblSize);
            this.gbSummary.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbSummary.ForeColor = System.Drawing.Color.Ivory;
            this.gbSummary.Location = new System.Drawing.Point(628, 12);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(317, 568);
            this.gbSummary.TabIndex = 8;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Order Summary";
            this.gbSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.gbSummary_Paint);
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.BackColor = System.Drawing.Color.Maroon;
            this.lblWhereToEat.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWhereToEat.Location = new System.Drawing.Point(179, 427);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(24, 32);
            this.lblWhereToEat.TabIndex = 8;
            this.lblWhereToEat.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(19, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Where To Eat : ";
            // 
            // tbToppings
            // 
            this.tbToppings.BackColor = System.Drawing.Color.White;
            this.tbToppings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbToppings.Enabled = false;
            this.tbToppings.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToppings.Location = new System.Drawing.Point(24, 215);
            this.tbToppings.Multiline = true;
            this.tbToppings.Name = "tbToppings";
            this.tbToppings.Size = new System.Drawing.Size(258, 187);
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
            // CrustTypelbl
            // 
            this.CrustTypelbl.AutoSize = true;
            this.CrustTypelbl.BackColor = System.Drawing.Color.Maroon;
            this.CrustTypelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CrustTypelbl.Location = new System.Drawing.Point(164, 121);
            this.CrustTypelbl.Name = "CrustTypelbl";
            this.CrustTypelbl.Size = new System.Drawing.Size(24, 32);
            this.CrustTypelbl.TabIndex = 1;
            this.CrustTypelbl.Text = "-";
            // 
            // toppings
            // 
            this.toppings.AutoSize = true;
            this.toppings.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toppings.ForeColor = System.Drawing.Color.Snow;
            this.toppings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toppings.Location = new System.Drawing.Point(18, 166);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(138, 32);
            this.toppings.TabIndex = 0;
            this.toppings.Text = "Toppings : ";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCrust.ForeColor = System.Drawing.Color.Snow;
            this.lblCrust.Location = new System.Drawing.Point(18, 121);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(154, 32);
            this.lblCrust.TabIndex = 0;
            this.lblCrust.Text = "Crust Type : ";
            // 
            // Sizelbl
            // 
            this.Sizelbl.AutoSize = true;
            this.Sizelbl.BackColor = System.Drawing.Color.Maroon;
            this.Sizelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Sizelbl.Location = new System.Drawing.Point(101, 69);
            this.Sizelbl.Name = "Sizelbl";
            this.Sizelbl.Size = new System.Drawing.Size(34, 32);
            this.Sizelbl.TabIndex = 1;
            this.Sizelbl.Text = "--";
            this.Sizelbl.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSize.ForeColor = System.Drawing.Color.Snow;
            this.lblSize.Location = new System.Drawing.Point(18, 65);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(89, 37);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size : ";
            // 
            // gbWhereToE
            // 
            this.gbWhereToE.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToE.Controls.Add(this.rdbTakeOut);
            this.gbWhereToE.Controls.Add(this.rdbEatin);
            this.gbWhereToE.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbWhereToE.ForeColor = System.Drawing.Color.Ivory;
            this.gbWhereToE.Location = new System.Drawing.Point(312, 303);
            this.gbWhereToE.Name = "gbWhereToE";
            this.gbWhereToE.Size = new System.Drawing.Size(296, 208);
            this.gbWhereToE.TabIndex = 6;
            this.gbWhereToE.TabStop = false;
            this.gbWhereToE.Text = "Where To Eat ? ";
            this.gbWhereToE.Paint += new System.Windows.Forms.PaintEventHandler(this.gbWhereToE_Paint);
            // 
            // rdbTakeOut
            // 
            this.rdbTakeOut.AutoSize = true;
            this.rdbTakeOut.BackColor = System.Drawing.Color.Maroon;
            this.rdbTakeOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbTakeOut.FlatAppearance.BorderSize = 2;
            this.rdbTakeOut.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTakeOut.ForeColor = System.Drawing.Color.Ivory;
            this.rdbTakeOut.Location = new System.Drawing.Point(83, 130);
            this.rdbTakeOut.Name = "rdbTakeOut";
            this.rdbTakeOut.Size = new System.Drawing.Size(131, 36);
            this.rdbTakeOut.TabIndex = 4;
            this.rdbTakeOut.Text = "Take Out";
            this.rdbTakeOut.UseVisualStyleBackColor = false;
            this.rdbTakeOut.CheckedChanged += new System.EventHandler(this.rdbTakeOut_CheckChanged);
            // 
            // rdbEatin
            // 
            this.rdbEatin.AutoSize = true;
            this.rdbEatin.BackColor = System.Drawing.Color.Maroon;
            this.rdbEatin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdbEatin.FlatAppearance.BorderSize = 2;
            this.rdbEatin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEatin.ForeColor = System.Drawing.Color.Ivory;
            this.rdbEatin.Location = new System.Drawing.Point(43, 61);
            this.rdbEatin.Name = "rdbEatin";
            this.rdbEatin.Size = new System.Drawing.Size(94, 36);
            this.rdbEatin.TabIndex = 3;
            this.rdbEatin.Text = "Eat in";
            this.rdbEatin.UseVisualStyleBackColor = false;
            this.rdbEatin.CheckedChanged += new System.EventHandler(this.rdbEatIn_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Aardvark", 18F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConfirm.Location = new System.Drawing.Point(355, 524);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(211, 62);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReset.BackgroundImage = global::PizzaResturantProject.Properties.Resources.R_W;
            this.btnReset.Font = new System.Drawing.Font("Aardvark", 18F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReset.Location = new System.Drawing.Point(68, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(159, 43);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Order_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 599);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToE);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.GBSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order_Form1";
            this.Text = "me ? Out and ";
            this.GBSize.ResumeLayout(false);
            this.GBSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbWhereToE.ResumeLayout(false);
            this.gbWhereToE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBSize;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rdbThick;
        private System.Windows.Forms.RadioButton rdbThinC;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cBExtraChe;
        private System.Windows.Forms.CheckBox cBOlives;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cBTomatoes;
        private System.Windows.Forms.CheckBox cBMashroms;
        private System.Windows.Forms.CheckBox cBGreenP;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label CrustTypelbl;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.Label Sizelbl;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label toppings;
        private System.Windows.Forms.TextBox tbToppings;
        private System.Windows.Forms.GroupBox gbWhereToE;
        private System.Windows.Forms.RadioButton rdbTakeOut;
        private System.Windows.Forms.RadioButton rdbEatin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWhereToEat;
    }
}