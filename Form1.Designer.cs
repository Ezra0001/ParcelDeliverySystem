﻿namespace ParcelDeliverySystem
{
    partial class PDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDS));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.edtPage = new System.Windows.Forms.TabPage();
            this.closeBtn = new System.Windows.Forms.Button();
            this.edtBox = new System.Windows.Forms.GroupBox();
            this.timeCombo = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.rstBtn = new System.Windows.Forms.Button();
            this.calBtn = new System.Windows.Forms.Button();
            this.dpcTxtBox = new System.Windows.Forms.TextBox();
            this.opcTxtBox = new System.Windows.Forms.TextBox();
            this.DestCountryCombo = new System.Windows.Forms.ComboBox();
            this.OrigCountryCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pccPage = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pcBox = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.wtBox = new System.Windows.Forms.TextBox();
            this.estTxtResult = new System.Windows.Forms.TextBox();
            this.rstBtn1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rateCost = new System.Windows.Forms.Button();
            this.errorDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDPC = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.edtPage.SuspendLayout();
            this.edtBox.SuspendLayout();
            this.pccPage.SuspendLayout();
            this.pcBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDPC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.edtPage);
            this.tabControl.Controls.Add(this.pccPage);
            this.tabControl.Location = new System.Drawing.Point(12, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(610, 334);
            this.tabControl.TabIndex = 0;
            // 
            // edtPage
            // 
            this.edtPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edtPage.Controls.Add(this.closeBtn);
            this.edtPage.Controls.Add(this.edtBox);
            this.edtPage.Location = new System.Drawing.Point(4, 22);
            this.edtPage.Name = "edtPage";
            this.edtPage.Padding = new System.Windows.Forms.Padding(3);
            this.edtPage.Size = new System.Drawing.Size(602, 308);
            this.edtPage.TabIndex = 0;
            this.edtPage.Text = "Estimated Delivery Time";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(251, 267);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // edtBox
            // 
            this.edtBox.Controls.Add(this.timeCombo);
            this.edtBox.Controls.Add(this.datePicker);
            this.edtBox.Controls.Add(this.rstBtn);
            this.edtBox.Controls.Add(this.calBtn);
            this.edtBox.Controls.Add(this.dpcTxtBox);
            this.edtBox.Controls.Add(this.opcTxtBox);
            this.edtBox.Controls.Add(this.DestCountryCombo);
            this.edtBox.Controls.Add(this.OrigCountryCombo);
            this.edtBox.Controls.Add(this.label6);
            this.edtBox.Controls.Add(this.label5);
            this.edtBox.Controls.Add(this.label4);
            this.edtBox.Controls.Add(this.label3);
            this.edtBox.Controls.Add(this.label2);
            this.edtBox.Controls.Add(this.label1);
            this.edtBox.Location = new System.Drawing.Point(6, 6);
            this.edtBox.Name = "edtBox";
            this.edtBox.Size = new System.Drawing.Size(586, 239);
            this.edtBox.TabIndex = 0;
            this.edtBox.TabStop = false;
            this.edtBox.Text = "Estimated Delivery Time";
            // 
            // timeCombo
            // 
            this.timeCombo.DropDownHeight = 100;
            this.timeCombo.FormattingEnabled = true;
            this.timeCombo.IntegralHeight = false;
            this.timeCombo.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "07:30",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.timeCombo.Location = new System.Drawing.Point(436, 114);
            this.timeCombo.Name = "timeCombo";
            this.timeCombo.Size = new System.Drawing.Size(130, 21);
            this.timeCombo.Sorted = true;
            this.timeCombo.TabIndex = 6;
            this.timeCombo.Text = "00:00";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(135, 117);
            this.datePicker.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2010, 3, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(140, 20);
            this.datePicker.TabIndex = 5;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // rstBtn
            // 
            this.rstBtn.Location = new System.Drawing.Point(294, 195);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(75, 23);
            this.rstBtn.TabIndex = 8;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = true;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // calBtn
            // 
            this.calBtn.Location = new System.Drawing.Point(200, 195);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(75, 23);
            this.calBtn.TabIndex = 7;
            this.calBtn.Text = "Calculate";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.calBtn_Click);
            // 
            // dpcTxtBox
            // 
            this.dpcTxtBox.Location = new System.Drawing.Point(436, 79);
            this.dpcTxtBox.Name = "dpcTxtBox";
            this.dpcTxtBox.Size = new System.Drawing.Size(130, 20);
            this.dpcTxtBox.TabIndex = 4;
            this.dpcTxtBox.TextChanged += new System.EventHandler(this.dpcTxtBox_TextChanged);
            this.dpcTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpcTxtBox_KeyDown);
            // 
            // opcTxtBox
            // 
            this.opcTxtBox.Location = new System.Drawing.Point(436, 41);
            this.opcTxtBox.Name = "opcTxtBox";
            this.opcTxtBox.Size = new System.Drawing.Size(130, 20);
            this.opcTxtBox.TabIndex = 2;
            this.opcTxtBox.TextChanged += new System.EventHandler(this.opcTxtBox_TextChanged);
            this.opcTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.opcTxtBox_KeyDown);
            // 
            // DestCountryCombo
            // 
            this.DestCountryCombo.FormattingEnabled = true;
            this.DestCountryCombo.Items.AddRange(new object[] {
            "SIN",
            "MAS",
            "USA"});
            this.DestCountryCombo.Location = new System.Drawing.Point(135, 78);
            this.DestCountryCombo.Name = "DestCountryCombo";
            this.DestCountryCombo.Size = new System.Drawing.Size(140, 21);
            this.DestCountryCombo.TabIndex = 3;
            this.DestCountryCombo.Text = "SIN";
            // 
            // OrigCountryCombo
            // 
            this.OrigCountryCombo.FormattingEnabled = true;
            this.OrigCountryCombo.Items.AddRange(new object[] {
            "SIN",
            "MAS",
            "USA"});
            this.OrigCountryCombo.Location = new System.Drawing.Point(135, 41);
            this.OrigCountryCombo.Name = "OrigCountryCombo";
            this.OrigCountryCombo.Size = new System.Drawing.Size(140, 21);
            this.OrigCountryCombo.TabIndex = 1;
            this.OrigCountryCombo.Text = "SIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 117);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time (HH:MM):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 78);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Destination Postal Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 41);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Origin Postal Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date (DD/MM/YYYY):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " Origin Country:";
            // 
            // pccPage
            // 
            this.pccPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pccPage.Controls.Add(this.button3);
            this.pccPage.Controls.Add(this.pcBox);
            this.pccPage.Location = new System.Drawing.Point(4, 22);
            this.pccPage.Name = "pccPage";
            this.pccPage.Padding = new System.Windows.Forms.Padding(3);
            this.pccPage.Size = new System.Drawing.Size(602, 308);
            this.pccPage.TabIndex = 1;
            this.pccPage.Text = "Postage Charge Calculator";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(251, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pcBox
            // 
            this.pcBox.Controls.Add(this.label14);
            this.pcBox.Controls.Add(this.comboBox2);
            this.pcBox.Controls.Add(this.wtBox);
            this.pcBox.Controls.Add(this.estTxtResult);
            this.pcBox.Controls.Add(this.rstBtn1);
            this.pcBox.Controls.Add(this.button2);
            this.pcBox.Controls.Add(this.label10);
            this.pcBox.Controls.Add(this.label11);
            this.pcBox.Controls.Add(this.label12);
            this.pcBox.Location = new System.Drawing.Point(6, 6);
            this.pcBox.Name = "pcBox";
            this.pcBox.Size = new System.Drawing.Size(580, 239);
            this.pcBox.TabIndex = 1;
            this.pcBox.TabStop = false;
            this.pcBox.Text = "Postage Charge";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 100;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Items.AddRange(new object[] {
            "DHL",
            "Fedex",
            "SpeedPost"});
            this.comboBox2.Location = new System.Drawing.Point(135, 114);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 3;
            this.comboBox2.Text = "DHL";
            // 
            // wtBox
            // 
            this.wtBox.Location = new System.Drawing.Point(135, 78);
            this.wtBox.Name = "wtBox";
            this.wtBox.Size = new System.Drawing.Size(140, 20);
            this.wtBox.TabIndex = 2;
            // 
            // estTxtResult
            // 
            this.estTxtResult.Location = new System.Drawing.Point(135, 41);
            this.estTxtResult.Name = "estTxtResult";
            this.estTxtResult.ReadOnly = true;
            this.estTxtResult.Size = new System.Drawing.Size(140, 20);
            this.estTxtResult.TabIndex = 1;
            // 
            // rstBtn1
            // 
            this.rstBtn1.Location = new System.Drawing.Point(294, 195);
            this.rstBtn1.Name = "rstBtn1";
            this.rstBtn1.Size = new System.Drawing.Size(75, 23);
            this.rstBtn1.TabIndex = 5;
            this.rstBtn1.Text = "Reset";
            this.rstBtn1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Delivery Service:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Weight in grams:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 41);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label12.Size = new System.Drawing.Size(123, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estimated Delivery Time:";
            // 
            // rateCost
            // 
            this.rateCost.Location = new System.Drawing.Point(442, 9);
            this.rateCost.Name = "rateCost";
            this.rateCost.Size = new System.Drawing.Size(166, 23);
            this.rateCost.TabIndex = 1;
            this.rateCost.Text = "Local/Overseas Postage Rates";
            this.rateCost.UseVisualStyleBackColor = true;
            this.rateCost.Click += new System.EventHandler(this.rateCost_Click);
            // 
            // errorDate
            // 
            this.errorDate.ContainerControl = this;
            // 
            // errorPC
            // 
            this.errorPC.ContainerControl = this;
            // 
            // errorDPC
            // 
            this.errorDPC.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(530, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Note: Please complete filling in Estimated Delivery Time page before you calculat" +
                "e postage charge. Thank you.";
            // 
            // PDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.rateCost);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "PDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcel Delivery System";
            this.Load += new System.EventHandler(this.PDS_Load);
            this.tabControl.ResumeLayout(false);
            this.edtPage.ResumeLayout(false);
            this.edtBox.ResumeLayout(false);
            this.edtBox.PerformLayout();
            this.pccPage.ResumeLayout(false);
            this.pcBox.ResumeLayout(false);
            this.pcBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage edtPage;
        private System.Windows.Forms.TabPage pccPage;
        private System.Windows.Forms.Button rateCost;
        private System.Windows.Forms.GroupBox edtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DestCountryCombo;
        private System.Windows.Forms.ComboBox OrigCountryCombo;
        private System.Windows.Forms.TextBox dpcTxtBox;
        private System.Windows.Forms.TextBox opcTxtBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.ComboBox timeCombo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox pcBox;
        private System.Windows.Forms.Button rstBtn1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox wtBox;
        private System.Windows.Forms.TextBox estTxtResult;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ErrorProvider errorDate;
        private System.Windows.Forms.ErrorProvider errorPC;
        private System.Windows.Forms.ErrorProvider errorDPC;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label14;
    }
}

