namespace PizzaResturantProject
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnStartOrder = new System.Windows.Forms.Button();
            this.BtnAboutUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(486, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(459, 387);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // BtnStartOrder
            // 
            this.BtnStartOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStartOrder.BackgroundImage")));
            this.BtnStartOrder.Font = new System.Drawing.Font("Aardvark", 20F, System.Drawing.FontStyle.Bold);
            this.BtnStartOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnStartOrder.Location = new System.Drawing.Point(577, 391);
            this.BtnStartOrder.Name = "BtnStartOrder";
            this.BtnStartOrder.Size = new System.Drawing.Size(276, 63);
            this.BtnStartOrder.TabIndex = 0;
            this.BtnStartOrder.Text = "Start Order";
            this.BtnStartOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnStartOrder.UseVisualStyleBackColor = true;
            this.BtnStartOrder.Click += new System.EventHandler(this.BtnStartOrder_Click);
            // 
            // BtnAboutUs
            // 
            this.BtnAboutUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAboutUs.BackgroundImage")));
            this.BtnAboutUs.Font = new System.Drawing.Font("Aardvark", 20F, System.Drawing.FontStyle.Bold);
            this.BtnAboutUs.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnAboutUs.Location = new System.Drawing.Point(577, 475);
            this.BtnAboutUs.Name = "BtnAboutUs";
            this.BtnAboutUs.Size = new System.Drawing.Size(276, 63);
            this.BtnAboutUs.TabIndex = 1;
            this.BtnAboutUs.Text = "About Us";
            this.BtnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAboutUs.UseVisualStyleBackColor = true;
            this.BtnAboutUs.Click += new System.EventHandler(this.BtnAboutUs_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 602);
            this.Controls.Add(this.BtnAboutUs);
            this.Controls.Add(this.BtnStartOrder);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "and ill ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnStartOrder;
        private System.Windows.Forms.Button BtnAboutUs;
    }
}

