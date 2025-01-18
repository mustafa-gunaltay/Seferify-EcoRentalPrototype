namespace Seferify
{
    partial class FormPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtBoxNameLastName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxCCNo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCvv = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSKT = new System.Windows.Forms.MaskedTextBox();
            this.lblNameLastNameError = new System.Windows.Forms.Label();
            this.lblCvvError = new System.Windows.Forms.Label();
            this.lblCCNoError = new System.Windows.Forms.Label();
            this.lblSKTError = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCCName = new System.Windows.Forms.Label();
            this.lblCCDate = new System.Windows.Forms.Label();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblCCccv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credit Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expiration Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 107);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(60, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payment Page";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CVV";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPay.Location = new System.Drawing.Point(46, 442);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(239, 61);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Complete Payment";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtBoxNameLastName
            // 
            this.txtBoxNameLastName.Location = new System.Drawing.Point(46, 181);
            this.txtBoxNameLastName.Name = "txtBoxNameLastName";
            this.txtBoxNameLastName.Size = new System.Drawing.Size(239, 27);
            this.txtBoxNameLastName.TabIndex = 6;
            this.txtBoxNameLastName.TextChanged += new System.EventHandler(this.txtBoxNameLastName_TextChanged);
            // 
            // maskedTextBoxCCNo
            // 
            this.maskedTextBoxCCNo.Location = new System.Drawing.Point(46, 317);
            this.maskedTextBoxCCNo.Mask = "0000-0000-0000-0000";
            this.maskedTextBoxCCNo.Name = "maskedTextBoxCCNo";
            this.maskedTextBoxCCNo.Size = new System.Drawing.Size(239, 27);
            this.maskedTextBoxCCNo.TabIndex = 7;
            this.maskedTextBoxCCNo.TextChanged += new System.EventHandler(this.maskedTextBoxCCNo_TextChanged);
            // 
            // maskedTextBoxCvv
            // 
            this.maskedTextBoxCvv.Location = new System.Drawing.Point(410, 317);
            this.maskedTextBoxCvv.Mask = "000";
            this.maskedTextBoxCvv.Name = "maskedTextBoxCvv";
            this.maskedTextBoxCvv.Size = new System.Drawing.Size(43, 27);
            this.maskedTextBoxCvv.TabIndex = 8;
            this.maskedTextBoxCvv.ValidatingType = typeof(int);
            this.maskedTextBoxCvv.TextChanged += new System.EventHandler(this.maskedTextBoxCvv_TextChanged);
            // 
            // maskedTextBoxSKT
            // 
            this.maskedTextBoxSKT.Location = new System.Drawing.Point(410, 175);
            this.maskedTextBoxSKT.Mask = "00-0000";
            this.maskedTextBoxSKT.Name = "maskedTextBoxSKT";
            this.maskedTextBoxSKT.Size = new System.Drawing.Size(76, 27);
            this.maskedTextBoxSKT.TabIndex = 9;
            this.maskedTextBoxSKT.TextChanged += new System.EventHandler(this.maskedTextBoxSKT_TextChanged);
            // 
            // lblNameLastNameError
            // 
            this.lblNameLastNameError.AutoSize = true;
            this.lblNameLastNameError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNameLastNameError.Location = new System.Drawing.Point(46, 215);
            this.lblNameLastNameError.Name = "lblNameLastNameError";
            this.lblNameLastNameError.Size = new System.Drawing.Size(0, 20);
            this.lblNameLastNameError.TabIndex = 10;
            // 
            // lblCvvError
            // 
            this.lblCvvError.AutoSize = true;
            this.lblCvvError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCvvError.Location = new System.Drawing.Point(410, 347);
            this.lblCvvError.Name = "lblCvvError";
            this.lblCvvError.Size = new System.Drawing.Size(0, 20);
            this.lblCvvError.TabIndex = 11;
            // 
            // lblCCNoError
            // 
            this.lblCCNoError.AutoSize = true;
            this.lblCCNoError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCCNoError.Location = new System.Drawing.Point(46, 347);
            this.lblCCNoError.Name = "lblCCNoError";
            this.lblCCNoError.Size = new System.Drawing.Size(0, 20);
            this.lblCCNoError.TabIndex = 12;
            // 
            // lblSKTError
            // 
            this.lblSKTError.AutoSize = true;
            this.lblSKTError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSKTError.Location = new System.Drawing.Point(406, 205);
            this.lblSKTError.Name = "lblSKTError";
            this.lblSKTError.Size = new System.Drawing.Size(0, 20);
            this.lblSKTError.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.Green;
            this.linkLabel1.Location = new System.Drawing.Point(457, 666);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 20);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to see location";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(718, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Payment Successful!";
            this.label6.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(726, 458);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(46, 388);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 25);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "label7";
            this.lblPrice.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 578);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(406, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Seferify.Properties.Resources.ccseferify;
            this.pictureBox3.Location = new System.Drawing.Point(619, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(579, 377);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // lblCCName
            // 
            this.lblCCName.AutoSize = true;
            this.lblCCName.BackColor = System.Drawing.Color.ForestGreen;
            this.lblCCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCCName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCCName.Location = new System.Drawing.Point(665, 289);
            this.lblCCName.Name = "lblCCName";
            this.lblCCName.Size = new System.Drawing.Size(0, 20);
            this.lblCCName.TabIndex = 22;
            // 
            // lblCCDate
            // 
            this.lblCCDate.AutoSize = true;
            this.lblCCDate.BackColor = System.Drawing.Color.ForestGreen;
            this.lblCCDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.799999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCCDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCCDate.Location = new System.Drawing.Point(808, 293);
            this.lblCCDate.Name = "lblCCDate";
            this.lblCCDate.Size = new System.Drawing.Size(0, 16);
            this.lblCCDate.TabIndex = 23;
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.BackColor = System.Drawing.Color.ForestGreen;
            this.lblCCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCCNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCCNumber.Location = new System.Drawing.Point(703, 231);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(0, 18);
            this.lblCCNumber.TabIndex = 24;
            // 
            // lblCCccv
            // 
            this.lblCCccv.AutoSize = true;
            this.lblCCccv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCCccv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCCccv.Location = new System.Drawing.Point(1120, 217);
            this.lblCCccv.Name = "lblCCccv";
            this.lblCCccv.Size = new System.Drawing.Size(0, 18);
            this.lblCCccv.TabIndex = 25;
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 714);
            this.Controls.Add(this.lblCCccv);
            this.Controls.Add(this.lblCCNumber);
            this.Controls.Add(this.lblCCDate);
            this.Controls.Add(this.lblCCName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSKTError);
            this.Controls.Add(this.lblCCNoError);
            this.Controls.Add(this.lblCvvError);
            this.Controls.Add(this.lblNameLastNameError);
            this.Controls.Add(this.maskedTextBoxSKT);
            this.Controls.Add(this.maskedTextBoxCvv);
            this.Controls.Add(this.maskedTextBoxCCNo);
            this.Controls.Add(this.txtBoxNameLastName);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPay";
            this.Text = "Ödeme Sayfası";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtBoxNameLastName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCCNo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCvv;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSKT;
        private System.Windows.Forms.Label lblNameLastNameError;
        private System.Windows.Forms.Label lblCvvError;
        private System.Windows.Forms.Label lblCCNoError;
        private System.Windows.Forms.Label lblSKTError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCCName;
        private System.Windows.Forms.Label lblCCDate;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.Label lblCCccv;
    }
}