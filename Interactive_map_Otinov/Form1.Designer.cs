namespace Interactive_map_Otinov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelWithOptions = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DrinksLabel = new System.Windows.Forms.Label();
            this.EnergyLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.medicalLabel = new System.Windows.Forms.Label();
            this.ToiletLabel = new System.Windows.Forms.Label();
            this.Toilet = new System.Windows.Forms.PictureBox();
            this.Medecine = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.PictureBox();
            this.EnergyBars = new System.Windows.Forms.PictureBox();
            this.Drinks = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Checkpoint = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.PictureBox();
            this.check1 = new System.Windows.Forms.PictureBox();
            this.check2 = new System.Windows.Forms.PictureBox();
            this.check3 = new System.Windows.Forms.PictureBox();
            this.check4 = new System.Windows.Forms.PictureBox();
            this.check5 = new System.Windows.Forms.PictureBox();
            this.check6 = new System.Windows.Forms.PictureBox();
            this.check7 = new System.Windows.Forms.PictureBox();
            this.check8 = new System.Windows.Forms.PictureBox();
            this.LongWay = new System.Windows.Forms.PictureBox();
            this.MidWay = new System.Windows.Forms.PictureBox();
            this.ShortWay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelWithOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toilet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medecine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelWithOptions
            // 
            this.PanelWithOptions.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelWithOptions.Controls.Add(this.CloseButton);
            this.PanelWithOptions.Controls.Add(this.DrinksLabel);
            this.PanelWithOptions.Controls.Add(this.EnergyLabel);
            this.PanelWithOptions.Controls.Add(this.InfoLabel);
            this.PanelWithOptions.Controls.Add(this.medicalLabel);
            this.PanelWithOptions.Controls.Add(this.ToiletLabel);
            this.PanelWithOptions.Controls.Add(this.Toilet);
            this.PanelWithOptions.Controls.Add(this.Medecine);
            this.PanelWithOptions.Controls.Add(this.Info);
            this.PanelWithOptions.Controls.Add(this.EnergyBars);
            this.PanelWithOptions.Controls.Add(this.Drinks);
            this.PanelWithOptions.Controls.Add(this.label1);
            this.PanelWithOptions.Controls.Add(this.Checkpoint);
            this.PanelWithOptions.Location = new System.Drawing.Point(617, 12);
            this.PanelWithOptions.Name = "PanelWithOptions";
            this.PanelWithOptions.Size = new System.Drawing.Size(447, 564);
            this.PanelWithOptions.TabIndex = 1;
            this.PanelWithOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(377, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(52, 25);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "CLOSE";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DrinksLabel
            // 
            this.DrinksLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DrinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrinksLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DrinksLabel.Location = new System.Drawing.Point(108, 189);
            this.DrinksLabel.Name = "DrinksLabel";
            this.DrinksLabel.Size = new System.Drawing.Size(172, 41);
            this.DrinksLabel.TabIndex = 11;
            this.DrinksLabel.Text = "Стенд питья";
            this.DrinksLabel.Click += new System.EventHandler(this.DrinksLabel_Click);
            // 
            // EnergyLabel
            // 
            this.EnergyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EnergyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EnergyLabel.Location = new System.Drawing.Point(108, 250);
            this.EnergyLabel.Name = "EnergyLabel";
            this.EnergyLabel.Size = new System.Drawing.Size(226, 69);
            this.EnergyLabel.TabIndex = 10;
            this.EnergyLabel.Text = "Энергетические\r\nбатончики";
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InfoLabel.Location = new System.Drawing.Point(108, 402);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(253, 66);
            this.InfoLabel.TabIndex = 9;
            this.InfoLabel.Text = "Информационный стенд";
            // 
            // medicalLabel
            // 
            this.medicalLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.medicalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medicalLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.medicalLabel.Location = new System.Drawing.Point(108, 481);
            this.medicalLabel.Name = "medicalLabel";
            this.medicalLabel.Size = new System.Drawing.Size(240, 70);
            this.medicalLabel.TabIndex = 8;
            this.medicalLabel.Text = "Медицинский центр";
            // 
            // ToiletLabel
            // 
            this.ToiletLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToiletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToiletLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToiletLabel.Location = new System.Drawing.Point(108, 337);
            this.ToiletLabel.Name = "ToiletLabel";
            this.ToiletLabel.Size = new System.Drawing.Size(114, 41);
            this.ToiletLabel.TabIndex = 7;
            this.ToiletLabel.Text = "Туалет";
            this.ToiletLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Toilet
            // 
            this.Toilet.Image = ((System.Drawing.Image)(resources.GetObject("Toilet.Image")));
            this.Toilet.Location = new System.Drawing.Point(11, 323);
            this.Toilet.Name = "Toilet";
            this.Toilet.Size = new System.Drawing.Size(76, 67);
            this.Toilet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Toilet.TabIndex = 6;
            this.Toilet.TabStop = false;
            // 
            // Medecine
            // 
            this.Medecine.Image = ((System.Drawing.Image)(resources.GetObject("Medecine.Image")));
            this.Medecine.Location = new System.Drawing.Point(11, 481);
            this.Medecine.Name = "Medecine";
            this.Medecine.Size = new System.Drawing.Size(76, 69);
            this.Medecine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Medecine.TabIndex = 5;
            this.Medecine.TabStop = false;
            // 
            // Info
            // 
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.Location = new System.Drawing.Point(11, 403);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(76, 65);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Info.TabIndex = 4;
            this.Info.TabStop = false;
            // 
            // EnergyBars
            // 
            this.EnergyBars.Image = ((System.Drawing.Image)(resources.GetObject("EnergyBars.Image")));
            this.EnergyBars.Location = new System.Drawing.Point(11, 250);
            this.EnergyBars.Name = "EnergyBars";
            this.EnergyBars.Size = new System.Drawing.Size(76, 67);
            this.EnergyBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnergyBars.TabIndex = 3;
            this.EnergyBars.TabStop = false;
            // 
            // Drinks
            // 
            this.Drinks.Image = ((System.Drawing.Image)(resources.GetObject("Drinks.Image")));
            this.Drinks.Location = new System.Drawing.Point(11, 174);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(76, 70);
            this.Drinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Drinks.TabIndex = 2;
            this.Drinks.TabStop = false;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 107);
            this.label1.TabIndex = 1;
            this.label1.Text = "Особенности:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Checkpoint
            // 
            this.Checkpoint.AutoSize = true;
            this.Checkpoint.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Checkpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Checkpoint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Checkpoint.Location = new System.Drawing.Point(3, 9);
            this.Checkpoint.Name = "Checkpoint";
            this.Checkpoint.Size = new System.Drawing.Size(197, 37);
            this.Checkpoint.TabIndex = 0;
            this.Checkpoint.Text = "Checkpoint ";
            this.Checkpoint.Click += new System.EventHandler(this.Checkpoint_Click);
            // 
            // finish
            // 
            this.finish.Image = ((System.Drawing.Image)(resources.GetObject("finish.Image")));
            this.finish.Location = new System.Drawing.Point(181, 38);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(31, 88);
            this.finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finish.TabIndex = 2;
            this.finish.TabStop = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // check1
            // 
            this.check1.Image = ((System.Drawing.Image)(resources.GetObject("check1.Image")));
            this.check1.Location = new System.Drawing.Point(345, 29);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(58, 62);
            this.check1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check1.TabIndex = 3;
            this.check1.TabStop = false;
            this.check1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // check2
            // 
            this.check2.Image = ((System.Drawing.Image)(resources.GetObject("check2.Image")));
            this.check2.Location = new System.Drawing.Point(410, 198);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(56, 56);
            this.check2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check2.TabIndex = 4;
            this.check2.TabStop = false;
            this.check2.Click += new System.EventHandler(this.check2_Click);
            // 
            // check3
            // 
            this.check3.Image = ((System.Drawing.Image)(resources.GetObject("check3.Image")));
            this.check3.Location = new System.Drawing.Point(394, 309);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(60, 58);
            this.check3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check3.TabIndex = 5;
            this.check3.TabStop = false;
            this.check3.Click += new System.EventHandler(this.check3_Click);
            // 
            // check4
            // 
            this.check4.Image = ((System.Drawing.Image)(resources.GetObject("check4.Image")));
            this.check4.Location = new System.Drawing.Point(538, 436);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(60, 58);
            this.check4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check4.TabIndex = 6;
            this.check4.TabStop = false;
            this.check4.Click += new System.EventHandler(this.check4_Click);
            // 
            // check5
            // 
            this.check5.Image = ((System.Drawing.Image)(resources.GetObject("check5.Image")));
            this.check5.Location = new System.Drawing.Point(312, 518);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(60, 58);
            this.check5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check5.TabIndex = 7;
            this.check5.TabStop = false;
            this.check5.Click += new System.EventHandler(this.check5_Click);
            // 
            // check6
            // 
            this.check6.Image = ((System.Drawing.Image)(resources.GetObject("check6.Image")));
            this.check6.Location = new System.Drawing.Point(126, 460);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(60, 58);
            this.check6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check6.TabIndex = 8;
            this.check6.TabStop = false;
            this.check6.Click += new System.EventHandler(this.check6_Click);
            // 
            // check7
            // 
            this.check7.Image = ((System.Drawing.Image)(resources.GetObject("check7.Image")));
            this.check7.Location = new System.Drawing.Point(72, 358);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(60, 58);
            this.check7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check7.TabIndex = 9;
            this.check7.TabStop = false;
            this.check7.Click += new System.EventHandler(this.check7_Click);
            // 
            // check8
            // 
            this.check8.Image = ((System.Drawing.Image)(resources.GetObject("check8.Image")));
            this.check8.Location = new System.Drawing.Point(56, 186);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(60, 58);
            this.check8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check8.TabIndex = 10;
            this.check8.TabStop = false;
            this.check8.Click += new System.EventHandler(this.check8_Click);
            // 
            // LongWay
            // 
            this.LongWay.Image = ((System.Drawing.Image)(resources.GetObject("LongWay.Image")));
            this.LongWay.Location = new System.Drawing.Point(208, 50);
            this.LongWay.Name = "LongWay";
            this.LongWay.Size = new System.Drawing.Size(66, 59);
            this.LongWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LongWay.TabIndex = 11;
            this.LongWay.TabStop = false;
            this.LongWay.Click += new System.EventHandler(this.LongWay_Click);
            // 
            // MidWay
            // 
            this.MidWay.Image = ((System.Drawing.Image)(resources.GetObject("MidWay.Image")));
            this.MidWay.Location = new System.Drawing.Point(378, 517);
            this.MidWay.Name = "MidWay";
            this.MidWay.Size = new System.Drawing.Size(66, 59);
            this.MidWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MidWay.TabIndex = 12;
            this.MidWay.TabStop = false;
            this.MidWay.Click += new System.EventHandler(this.MidWay_Click);
            // 
            // ShortWay
            // 
            this.ShortWay.Image = ((System.Drawing.Image)(resources.GetObject("ShortWay.Image")));
            this.ShortWay.Location = new System.Drawing.Point(56, 250);
            this.ShortWay.Name = "ShortWay";
            this.ShortWay.Size = new System.Drawing.Size(60, 59);
            this.ShortWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShortWay.TabIndex = 13;
            this.ShortWay.TabStop = false;
            this.ShortWay.Click += new System.EventHandler(this.ShortWay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1058, 614);
            this.Controls.Add(this.ShortWay);
            this.Controls.Add(this.MidWay);
            this.Controls.Add(this.LongWay);
            this.Controls.Add(this.check8);
            this.Controls.Add(this.check7);
            this.Controls.Add(this.check6);
            this.Controls.Add(this.check5);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.PanelWithOptions);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelWithOptions.ResumeLayout(false);
            this.PanelWithOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Toilet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Medecine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MidWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortWay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelWithOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Checkpoint;
        private System.Windows.Forms.PictureBox finish;
        private System.Windows.Forms.PictureBox check1;
        private System.Windows.Forms.PictureBox Medecine;
        private System.Windows.Forms.PictureBox Info;
        private System.Windows.Forms.PictureBox EnergyBars;
        private System.Windows.Forms.PictureBox Drinks;
        private System.Windows.Forms.PictureBox check2;
        private System.Windows.Forms.PictureBox check3;
        private System.Windows.Forms.PictureBox check4;
        private System.Windows.Forms.PictureBox check5;
        private System.Windows.Forms.PictureBox check6;
        private System.Windows.Forms.PictureBox check7;
        private System.Windows.Forms.PictureBox check8;
        private System.Windows.Forms.Label ToiletLabel;
        private System.Windows.Forms.PictureBox Toilet;
        private System.Windows.Forms.Label DrinksLabel;
        private System.Windows.Forms.Label EnergyLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label medicalLabel;
        private System.Windows.Forms.PictureBox LongWay;
        private System.Windows.Forms.PictureBox MidWay;
        private System.Windows.Forms.PictureBox ShortWay;
        private System.Windows.Forms.Button CloseButton;
    }
}

