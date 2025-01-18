using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Seferify
{
    public partial class FormMain : Form
    {

        private void ToggleNightMode(bool isNightMode)
        {
            if (isNightMode)
            {
                
                this.BackColor = Color.FromArgb(0, 0, 0); // Siyah arka plan
                this.ForeColor = Color.White; // Beyaz metin rengi
                lblRadıoBtnError.BackColor = Color.Black;
                lblCarInformatıonsError.BackColor = Color.Black;

                
                panel1.BackColor = Color.Green;
                panel1.ForeColor = SystemColors.ControlText;


            }
            else
            {
                
                this.BackColor = SystemColors.ControlLightLight;
                this.ForeColor = SystemColors.ControlText;
                lblRadıoBtnError.BackColor = Color.White;
                lblCarInformatıonsError.BackColor = Color.White;

                
                panel1.BackColor = Color.Green;
                panel1.ForeColor = SystemColors.ControlText;


            }
        }

        
        List<Car> carStorage;

        string customerName;
        string customerLastName;
        int customerAge;
        bool customerDrivingLicenceState;
        long customerTC;
        long customerPhone;
        

        Car selectedCar;

        DayTimeAndFullOrHalfDay rentingDateAndFullHalfDayState;
        public class Car
        {
            string brand;
            string model;
            int year;
            int id;
            DayTimeAndFullOrHalfDay rentState;

            double price;

            public Car(string brand, string model, int year, int id)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.id = id;
                this.rentState = new DayTimeAndFullOrHalfDay();

                int tempPrice = 2000;

                if (brand == "Tesla")
                    tempPrice = 4000;
                else if (brand == "Mercedes")
                    tempPrice = 7000;
                else if (brand == "Citroen Ami 2022")
                    tempPrice = 1000;
                else if (brand == "Citroen Ami 2023")
                    tempPrice = 1400;
                else if (brand == "TOGG")
                    tempPrice = 3000;
                else if (brand == "Volkswagen")
                    tempPrice = 2000;

                this.price = tempPrice;
            }

            public Car(string brand, string model, int year, int id, DayTimeAndFullOrHalfDay rentState)
            {
                this.brand = brand;
                this.model = model;
                this.year = year;
                this.id = id;
                this.rentState = rentState;
            }

            public override string ToString()
            {
                return $"{brand} - {model} - {id} - {year}";
            }
            public void updatePrice(int lengthState)
            {
                double rate = 0.5;

                if (lengthState == 1) // tam gün
                {
                    price = price * (1 + rate);
                }
                else if (lengthState == 2) // yarim gun
                {
                    price = price * 2 / 3;
                }
            }

            public void setRentState(int sayi)
            {
                rentState.setLengthState(sayi);
            }

            public double getPrice()
            {
                return price;
            }
            public string getBrand() { return brand; }
            public string getModel() { return model; }
            public int getYear() { return year; }

            public int getId() { return id; }
            public DayTimeAndFullOrHalfDay getRentState() { return rentState; }

        }

        public class DayTimeAndFullOrHalfDay
        {
            DateTime selectedDate; // if it's MaxValue it is available
                                   // if it is MinValue, Customer hasn't select a date yet

            int lengthState; // 0 -> bosta
                             // 1 -> tam gun
                             // 2 -> yarim gun

            public DayTimeAndFullOrHalfDay()
            {
                selectedDate = DateTime.MaxValue;
                lengthState = 0;

            }
            public DayTimeAndFullOrHalfDay(DateTime selectedDate, int lengthState)
            {
                this.selectedDate = selectedDate;
                this.lengthState = lengthState;
            }

            public override string ToString()
            {
                string length = "";
                if (lengthState == 0)
                {
                    length = "Bosta";
                }
                else if (lengthState == 1)
                {
                    length = "Tam Gun";
                }
                else if (lengthState == 2)
                {
                    length = "Yarım Gun";
                }
               
               return selectedDate.ToString() + " - " + length;
            }
            public int getLengthState()
            {
                return lengthState;
            }

            public void setLengthState(int lState)
            {
                lengthState = lState;
            }
        }

        public class Customer
        {
            string name;
            string lastName;
            int age;
            bool drivingLicence;
            long tcNO;
            //long phoneNumber;

            public Customer(string name, string lastName, int age, bool drivingLicence, long tcNO)
            {
                this.name = name;
                this.lastName = lastName;
                this.age = age;
                this.drivingLicence = drivingLicence;
                this.tcNO = tcNO;
            }
        }


        public FormMain()
        {
            InitializeComponent();

        }

        // Initiazlizer Methods
        void initializeCarStorage()
        {
            carStorage = new List<Car>();

            carStorage.Add(new Car("Tesla", "Model S", 1, 2023));
            carStorage.Add(new Car("Tesla", "Model 3", 1, 2022));
            carStorage.Add(new Car("Mercedes", "EQE", 1, 2024));
            carStorage.Add(new Car("Citroen", "Ami", 1, 2023));
            carStorage.Add(new Car("Citroen", "Ami", 2, 2023));
            carStorage.Add(new Car("Citroen", "Ami", 3, 2022));
            carStorage.Add(new Car("Citroen", "Ami", 4, 2022));
            carStorage.Add(new Car("TOGG", "T10X", 1, 2024));
            carStorage.Add(new Car("TOGG", "T10X", 2, 2024));
            carStorage.Add(new Car("Volkswagen", "ID.3", 1, 2023));
        }

        void initializeCmbBoxCarInformations()
        {
            cmbBoxCarInformations.Items.AddRange(carStorage.ToArray());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeCarStorage();
            initializeCmbBoxCarInformations();
            dateTimePicker1.MinDate = DateTime.Today;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";

            //testIcinInitialize();

        }

        private void testIcinInitialize()
        {
            txtBoxName.Text = "ahmet";
            txtBoxLastName.Text = "kilic";
            txtTC.Text = "12345678910";
            txtBoxAge.Text = "20";
            radioBtnFullDay.Checked = true;
            radioBtnYes.Checked = true;
            chkBoxKvkk.Checked = true;
            maskedPhoneNumber.Text = "5336503456";

            cmbBoxCarInformations.Text = "Tesla - Model S - 2023 - 1";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";


        }

        private void cmbBoxCarInformations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pictureBox1 deki resim secilen aracin resimi olacak
           
               
                int selectedIndex = cmbBoxCarInformations.SelectedIndex;

                
                if (selectedIndex == -1)
                {
                    pictureBoxCar.Image = null;
                    return;
                }

                
                string imageName = $"car{selectedIndex + 1}";

                // PictureBox'a seçilen resmi ayarla
                pictureBoxCar.Image = (System.Drawing.Image)Properties.Resources.ResourceManager.GetObject(imageName);
            
        }

        

        
        private void btnPaymentForm_Click(object sender, EventArgs e)
        {
            int errorCount = 0; //max 7

            // ARABA VE TARIH BILGILERININ KONTROLU
            if (cmbBoxCarInformations.SelectedItem == null || cmbBoxCarInformations.SelectedIndex == -1)
            {
                lblCarInformatıonsError.Text = "Lütfen bir araba seçiniz";
                errorCount++;
            }
            else
            {
                selectedCar = carStorage[cmbBoxCarInformations.SelectedIndex];
                lblCarInformatıonsError.Text = "";
            }

            bool isBothRadioButtonsNotSelected = !radioBtnFullDay.Checked && !radioBtnHalfDay.Checked;
            if (dateTimePicker1.Value == DateTime.MinValue || isBothRadioButtonsNotSelected)
            {
                lblRadıoBtnError.Text = "Lütfen Tarih kısmını ve Tüm gün mü yoksa yarım gün mü kiralama yaptığınız kısmı boş bırakmayınız";
                errorCount++;
            }
            else
            {
                int lengthState = radioBtnFullDay.Checked ? 1 : 2;
                rentingDateAndFullHalfDayState = new DayTimeAndFullOrHalfDay(dateTimePicker1.Value, lengthState);
                lblRadıoBtnError.Text = "";
            }

            // MUSTERI BILGILERININ KONTROLU
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                lblNameError.Text = "Lütfen İsminizi giriniz";
                errorCount++;
            }
            else
            {
                customerName = txtBoxName.Text;
                lblNameError.Text = "";
            }

            if (string.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                lblLastNameError.Text = "Lütfen Soyisminizi giriniz";
                errorCount++;
            }
            else
            {
                customerLastName = txtBoxLastName.Text;
                lblLastNameError.Text = "";
            }

            if (!IsTextBoxValid(txtBoxAge) || int.Parse(txtBoxAge.Text) < 18)
            {
                lblAgeError.Text = "Yaş 18'den küçük olamaz veya geçerli bir sayı olmalıdır.";
                errorCount++;
            }
            else
            {
                customerAge = int.Parse(txtBoxAge.Text);
                lblAgeError.Text = "";
            }
            if (!IsTCValid(txtTC))
            {
                lblTcError.Visible = true;
                lblTcError.Text = "TC Kimlik Numaranızı uygun şekilde giriniz.";

                errorCount++;
            }
            else
            {
                customerTC = (int)long.Parse(txtTC.Text);


                lblTcError.Text = "";
            }


            if (!IsPhoneNumberValid(maskedPhoneNumber.Text))
            {
                lblPhoneError.Text = "Telefon numaranızı uygun şekilde giriniz.";
                errorCount++;
            }
            else
            {
                // Maskelenmiş telefon numarasından sadece rakamları alıp temizlenmiş metin elde ediyoruz.
                string phoneText = new string(maskedPhoneNumber.Text.Where(char.IsDigit).ToArray());

                // Temizlenmiş metni kullanarak telefon numarasını kontrol ediyoruz.
                if (phoneText.Length != 10) // Telefon numarasının 10 karakter olması gerektiğini varsayıyoruz.
                {
                    lblPhoneError.Text = "Telefon numaranızı uygun şekilde giriniz.";
                    errorCount++;
                }
                else
                {
                    customerPhone = Convert.ToInt64(phoneText);
                    lblPhoneError.Text = "";
                }
            }

            if (!radioBtnYes.Checked && !radioBtnNo.Checked)
            {
                lblDrıvıngLıcenceErrror.Text = "Lütfen Ehliyet durumunuzu belirtiniz";
                errorCount++;
            }
            else if (radioBtnNo.Checked)
            {
                Close();
            }
            else
            {
                customerDrivingLicenceState = radioBtnYes.Checked;
                lblDrıvıngLıcenceErrror.Text = "";
            }

            if (!chkBoxKvkk.Checked)
            {
                //errorMessages.Add("KVKK onaylamadan bir sonraki asamaya gecemessiniz");
                MessageBox.Show("Aydınlatma Metni'ni ve Açık Rıza Metni'ni kabul etmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorCount++;
            }

            if (errorCount == 0)
            {
                FormPay form2 = new FormPay(customerName,
                                        customerLastName,
                                        customerAge,
                                        customerTC,
                                        customerDrivingLicenceState,
                                        selectedCar,
                                        rentingDateAndFullHalfDayState, isNightMode);
                form2.Show();

                //csv dosyasına kaydetme
                SaveToCsv();
                SaveToXml();

                //writeToTextFile(); // deneme amacli

                errorCount = 0;

            }


            


        }
        

        private bool IsTextBoxValid(System.Windows.Forms.TextBox textBox)
        {
            // 1. Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {

                return false;
            }

            { // 2. Sayısal içerik kontrolü
                foreach (char c in textBox.Text)
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
        private bool IsTCValid(System.Windows.Forms.TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text.Length != 11)
            {
                return false;
            }

            foreach (char c in textBox.Text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            

            // Telefon numarası formatı: (999) 000-0000
            string pattern = @"^\(\d{3}\)\s*\d{3}-\d{4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

        private void chkBoxKvkk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxKvkk.Checked)
            {
                FormMetin frmetin = new FormMetin(this);
                frmetin.Show();

                
            }
            else
            {
                FormMetin frmetin = new FormMetin(this);
                frmetin.Close();
            }
        }
        private bool isNightMode = false;

        private void btnTema_Click(object sender, EventArgs e)
        {
            isNightMode = !isNightMode;

            // Gece modunu güncelle
            ToggleNightMode(isNightMode);
        }



        private void SaveToCsv()
        {
            // Projenin çalıştığı dizini al
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectDirectory, "Musteri_Bilgisi.csv");

            var csv = new StringBuilder();

            // Başlık satırı ekleyin
            if (!File.Exists(filePath))
            {
                var csvHeader = "Ad,Soyad,Yas,TC No,Ehliyet,Araba,Tarih ve Tum Yarim-Gun\n";
                File.WriteAllText(filePath, csvHeader);
            }

            // Verileri ekleyin
            var newLine = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                                        customerName,
                                        customerLastName,
                                        customerAge,
                                        customerTC,
                                        customerDrivingLicenceState,
                                        selectedCar.ToString(),
                                        rentingDateAndFullHalfDayState.ToString());
            File.AppendAllText(filePath, newLine);

            Console.WriteLine("Dosya başarıyla kaydedildi: " + filePath);
        }


        private void SaveToXml()
        {
            // FilePathin alinmasis
            string documentsPath = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(documentsPath, "Musteri_Bilgisi.xml");

            XDocument doc;

            // Eğer XML dosyasınin mevcut olmamasinin kontrolu
            if (File.Exists(filePath))
            {
                doc = XDocument.Load(filePath);
            }
            else
            {
                doc = new XDocument(new XElement("Customers"));
            }

            
            XElement newCustomer = new XElement("Customer",
                new XElement("Ad", customerName),
                new XElement("Soyad", customerLastName),
                new XElement("Yas", customerAge),
                new XElement("TCNumarasi", customerTC),
                new XElement("Ehliyet", customerDrivingLicenceState),
                new XElement("Araba", selectedCar.ToString()),
                new XElement("TarihveTumYarimGun", rentingDateAndFullHalfDayState.ToString())
            );

            doc.Element("Customers").Add(newCustomer);

            // Dosyanin kaydedilmesi
            doc.Save(filePath);
        }


        private void lblHakkimizda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHakkimizda frm1 =new FormHakkimizda();
            frm1.Show();
        }

        private void radioBtnFullDay_CheckedChanged(object sender, EventArgs e)
        {
            // Seçilen arabanın fiyatını güncelle ve lblPrice etiketini güncelle
            if (cmbBoxCarInformations.SelectedItem != null)
            {
                int selectedIndex = cmbBoxCarInformations.SelectedIndex;
                selectedCar = carStorage[selectedIndex];

                if (radioBtnFullDay.Checked)
                {
                    selectedCar.updatePrice(1); // tam gün
                }
                else if (radioBtnHalfDay.Checked)
                {
                    selectedCar.updatePrice(2); // yarım gün
                }

                lblPrice.Text = selectedCar.getPrice().ToString("F1") + " ₺";
            }
            else
            {
                MessageBox.Show("Combo Box`da Lutfen bir item seciniz");
            }
        }

        private void radioBtnHalfDay_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbBoxCarInformations.SelectedItem != null)
            {
                int selectedIndex = cmbBoxCarInformations.SelectedIndex;
                selectedCar = carStorage[selectedIndex];

                if (radioBtnFullDay.Checked)
                {
                    selectedCar.updatePrice(1); // tam gün
                }
                else if (radioBtnHalfDay.Checked)
                {
                    selectedCar.updatePrice(2); // yarım gün
                }

                lblPrice.Text = selectedCar.getPrice().ToString("F1") + " ₺";
            }
            else
            {
                MessageBox.Show("Combo Box`da Lutfen bir item seciniz");
            }
        }
    }
}
    