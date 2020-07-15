namespace studiosoftware
{
    partial class Employee_Management
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Management));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mobileNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.joinedDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dobDatepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mobileNumErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileNumErrorProvider)).BeginInit();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 710);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(15, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(177, 45);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Photography Partner";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::studiosoftware.Properties.Resources.logonew;
            this.pictureBox1.Location = new System.Drawing.Point(11, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1200, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registration Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(187, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 37);
            this.panel2.TabIndex = 11;
            // 
            // mobileNumber
            // 
            this.mobileNumber.BackColor = System.Drawing.Color.RosyBrown;
            this.mobileNumber.ForeColor = System.Drawing.Color.White;
            this.mobileNumber.Location = new System.Drawing.Point(344, 517);
            this.mobileNumber.Mask = "(+99) 999 999 999";
            this.mobileNumber.Name = "mobileNumber";
            this.mobileNumber.Size = new System.Drawing.Size(155, 20);
            this.mobileNumber.TabIndex = 7;
            this.mobileNumber.Leave += new System.EventHandler(this.mobileNumber_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label10.Location = new System.Drawing.Point(211, 516);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 53;
            this.label10.Text = "Mobile Number:";
            // 
            // joinedDatepicker
            // 
            this.joinedDatepicker.BackColor = System.Drawing.Color.RosyBrown;
            this.joinedDatepicker.BorderRadius = 0;
            this.joinedDatepicker.ForeColor = System.Drawing.Color.White;
            this.joinedDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.joinedDatepicker.FormatCustom = null;
            this.joinedDatepicker.Location = new System.Drawing.Point(344, 462);
            this.joinedDatepicker.Name = "joinedDatepicker";
            this.joinedDatepicker.Size = new System.Drawing.Size(155, 28);
            this.joinedDatepicker.TabIndex = 6;
            this.joinedDatepicker.Value = new System.DateTime(2020, 7, 10, 13, 6, 16, 551);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label9.Location = new System.Drawing.Point(211, 462);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 52;
            this.label9.Text = "Joined Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label8.Location = new System.Drawing.Point(211, 401);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Gender:";
            // 
            // dobDatepicker
            // 
            this.dobDatepicker.BackColor = System.Drawing.Color.RosyBrown;
            this.dobDatepicker.BorderRadius = 0;
            this.dobDatepicker.ForeColor = System.Drawing.Color.White;
            this.dobDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDatepicker.FormatCustom = null;
            this.dobDatepicker.Location = new System.Drawing.Point(344, 269);
            this.dobDatepicker.Name = "dobDatepicker";
            this.dobDatepicker.Size = new System.Drawing.Size(155, 28);
            this.dobDatepicker.TabIndex = 3;
            this.dobDatepicker.Value = new System.DateTime(2020, 7, 10, 13, 6, 16, 551);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.HintForeColor = System.Drawing.Color.Silver;
            this.address.HintText = "address";
            this.address.isPassword = false;
            this.address.LineFocusedColor = System.Drawing.Color.PaleVioletRed;
            this.address.LineIdleColor = System.Drawing.Color.PaleVioletRed;
            this.address.LineMouseHoverColor = System.Drawing.Color.PaleVioletRed;
            this.address.LineThickness = 3;
            this.address.Location = new System.Drawing.Point(215, 336);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(667, 29);
            this.address.TabIndex = 4;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address.Leave += new System.EventHandler(this.bunifuMaterialTextbox4_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label7.Location = new System.Drawing.Point(211, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label6.Location = new System.Drawing.Point(211, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Date of Birth:";
            // 
            // lastName
            // 
            this.lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastName.ForeColor = System.Drawing.Color.White;
            this.lastName.HintForeColor = System.Drawing.Color.Silver;
            this.lastName.HintText = "last name";
            this.lastName.isPassword = false;
            this.lastName.LineFocusedColor = System.Drawing.Color.PaleVioletRed;
            this.lastName.LineIdleColor = System.Drawing.Color.PaleVioletRed;
            this.lastName.LineMouseHoverColor = System.Drawing.Color.PaleVioletRed;
            this.lastName.LineThickness = 3;
            this.lastName.Location = new System.Drawing.Point(531, 134);
            this.lastName.Margin = new System.Windows.Forms.Padding(4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(222, 29);
            this.lastName.TabIndex = 1;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lastName.Leave += new System.EventHandler(this.lastName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label5.Location = new System.Drawing.Point(527, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Last Name:";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HintForeColor = System.Drawing.Color.Silver;
            this.email.HintText = "email";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.PaleVioletRed;
            this.email.LineIdleColor = System.Drawing.Color.PaleVioletRed;
            this.email.LineMouseHoverColor = System.Drawing.Color.PaleVioletRed;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(215, 211);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(284, 29);
            this.email.TabIndex = 2;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.Validating += new System.ComponentModel.CancelEventHandler(this.email_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label4.Location = new System.Drawing.Point(211, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 48;
            this.label4.Text = "Email:";
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstName.ForeColor = System.Drawing.Color.White;
            this.firstName.HintForeColor = System.Drawing.Color.DarkGray;
            this.firstName.HintText = "first name";
            this.firstName.isPassword = false;
            this.firstName.LineFocusedColor = System.Drawing.Color.PaleVioletRed;
            this.firstName.LineIdleColor = System.Drawing.Color.PaleVioletRed;
            this.firstName.LineMouseHoverColor = System.Drawing.Color.PaleVioletRed;
            this.firstName.LineThickness = 3;
            this.firstName.Location = new System.Drawing.Point(215, 134);
            this.firstName.Margin = new System.Windows.Forms.Padding(4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(222, 29);
            this.firstName.TabIndex = 0;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.firstName.Leave += new System.EventHandler(this.firstName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label3.Location = new System.Drawing.Point(211, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "First Name:";
            // 
            // firstNameErrorProvider
            // 
            this.firstNameErrorProvider.ContainerControl = this;
            // 
            // lastNameErrorProvider
            // 
            this.lastNameErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // mobileNumErrorProvider
            // 
            this.mobileNumErrorProvider.ContainerControl = this;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.saveButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(513, 588);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 44);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.viewButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(666, 588);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(133, 44);
            this.viewButton.TabIndex = 9;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.updateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(819, 588);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(133, 44);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gender
            // 
            this.gender.Controls.Add(this.radioButton2);
            this.gender.Controls.Add(this.radioButton1);
            this.gender.Location = new System.Drawing.Point(344, 391);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(170, 47);
            this.gender.TabIndex = 5;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(99, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 21);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(3, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Employee_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mobileNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.joinedDatepicker);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dobDatepicker);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileNumErrorProvider)).EndInit();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox mobileNumber;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDatepicker joinedDatepicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDatepicker dobDatepicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lastName;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider firstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider lastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider mobileNumErrorProvider;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Panel gender;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}