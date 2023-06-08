using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_Uygulaması_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void telefonRehberiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.telefonRehberiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.telefonrehberiDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telefonrehberiDataSet.TelefonRehberi' table. You can move, or remove it, as needed.
            this.telefonRehberiTableAdapter.Fill(this.telefonrehberiDataSet.TelefonRehberi);

        }
    }
}
