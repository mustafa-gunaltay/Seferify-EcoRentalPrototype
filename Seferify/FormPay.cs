using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Seferify.FormMain;

namespace Seferify
{
    public partial class FormPay : Form
    {
        
        string customerName;
        string customerLastName;
        int customerAge;
        long customerTC;
        bool customerDrivingLicenceState;
        
        

        Car selectedCar;
        DayTimeAndFullOrHalfDay rentingDateAndFullHalfDayState;

        public FormPay()
        {
            InitializeComponent();
        }

        public FormPay(string customerName,
                        string customerLastName,
                        int customerAge,
                        long customerTC,
                        bool customerDrivingLicenceState,
                        Car selectedCar,
                        DayTimeAndFullOrHalfDay rentingDateAndFullHalfDayState,
                        bool isNightMode)
        {
            InitializeComponent();

            this.customerName = customerName;
            this.customerLastName = customerLastName;
            this.customerAge = customerAge;
            this.customerDrivingLicenceState = customerDrivingLicenceState;
            this.selectedCar = selectedCar;
            this.rentingDateAndFullHalfDayState = rentingDateAndFullHalfDayState;
            this.customerTC = customerTC;

            if (isNightMode)
            {
                this.BackColor = Color.FromArgb(0, 0, 0); // Siyah arka plan
                this.ForeColor = Color.White; // Beyaz metin rengi

                // Paneldeki renklerin degistilmesi
                panel1.BackColor = Color.Green;
                panel1.ForeColor = SystemColors.ControlText;
            }
            else
            {
                this.BackColor = Color.White;

            }
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            int errorCount = 0;

            // Name LastName kontrolu
            if (string.IsNullOrWhiteSpace(txtBoxNameLastName.Text))
            {
                lblNameLastNameError.Text = "Kart sahibinin ismini giriniz.";
                errorCount++;
            }
            else
            {

                lblNameLastNameError.Text = "";
            }


            // CC No kontrolu
            if (!IsTextBoxValid(deleteDash(maskedTextBoxCCNo.Text)))
            {
                lblCCNoError.Text = "Boş bırakmayınız.";
                errorCount++;
            }
            else
            {

                lblCCNoError.Text = "";
            }


            // SKT kontrolu
            if (!IsTextBoxValid(deleteDash(maskedTextBoxCCNo.Text)))
            {
                lblSKTError.Text = "Lütfen geçerli bir Tarih \ngiriniz.";
                errorCount++;
            }
            else
            {

                lblSKTError.Text = "";
            }

            //CVV kontrolu
            if (!IsTextBoxValid(maskedTextBoxCvv.Text))
            {
                lblCvvError.Text = "CVV Kısmını boş bırakmayınız.";
                errorCount++;
            }
            else
            {

                lblCvvError.Text = "";
            }

            if (errorCount == 0)
            {
                pictureBox1.Visible = true;
                linkLabel1.Visible = true;
                lblInfo.Visible = true;
                label6.Visible = true;





                string summary = giveSummary();
                lblInfo.Text = summary;
            }

        }
        private string FormatDate(string date)
        {
            if (DateTime.TryParseExact(date, "MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate.ToString("MM/yyyy");
            }
            return date; 
        }

        private bool IsTextBoxValid(string str)
        {
            // 1. Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(str))
            {

                return false;
            }

            { // 2. Sayısal içerik kontrolü
                foreach (char c in str)
                {
                    if (!char.IsControl(c) && !string.IsNullOrWhiteSpace(c.ToString()) && !char.IsDigit(c))
                    {
                        return false;
                    }
                }
            }
            // Her iki kontrol de geçildiği durum
            return true;
        }

        private string deleteDash(string str)
        {

            string newStr = "";

            foreach (char c in str)
            {
                if (c == '-')
                {
                    continue;
                }

                newStr += c;
            }

            return newStr;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.app.goo.gl/nELtzw4GMR9SN2rb6?g_st=iw");
        }

        private string giveSummary()
        {
            string ehliyet;
            string result = "";
            result += customerName;
            result += "\n";
            result += customerLastName;
            result += "\n";
            result += customerAge;
            result += "\n";
            if (customerDrivingLicenceState)
            {
                ehliyet = "Ehliyet Durumu: Var";
            }
            else {
                ehliyet = "Ehliyet Durumu Yok";
            }
            result += ehliyet;
            result += "\n";
            result += selectedCar.ToString();
            result += "\n";
            result += rentingDateAndFullHalfDayState.ToString();
            result += "\n";


            return result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblPrice.Text = selectedCar.getPrice().ToString();
        }

        private void txtBoxNameLastName_TextChanged(object sender, EventArgs e)
        {
            lblCCName.Text = txtBoxNameLastName.Text.ToUpper();
        }

        private void maskedTextBoxSKT_TextChanged(object sender, EventArgs e)
        {
            lblCCDate.Text = FormatDate(maskedTextBoxSKT.Text).ToUpper();
        }

        private void maskedTextBoxCCNo_TextChanged(object sender, EventArgs e)
        {
            lblCCNumber.Text = deleteDash(maskedTextBoxCCNo.Text).ToUpper();
        }

        private void maskedTextBoxCvv_TextChanged(object sender, EventArgs e)
        {
            lblCCccv.Text = maskedTextBoxCvv.Text;
            
        }
    }
}
