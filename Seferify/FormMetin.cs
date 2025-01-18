using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seferify
{
    public partial class FormMetin : Form
    {
        private FormMain _form1;
        public FormMetin(FormMain form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form1.chkBoxKvkk.Checked = true;
            
            this.Close();
        }
    }
}
