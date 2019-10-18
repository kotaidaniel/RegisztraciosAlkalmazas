using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztraciosAlkalmazas
{
    public partial class RegisztraciosAlkalmazas : Form
    {
        public RegisztraciosAlkalmazas()
        {
            InitializeComponent();
            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    string nev = txtboxNev.Text;
                    string szulDatum = txtboxSzul.Text;
                    string nem = "";
                    if (radioFerfi.Checked == true)
                    {
                        nem = radioFerfi.Text;
                    }
                    else if (radioNo.Checked == true)
                    {
                        nem = radioNo.Text;
                    }
                    string hobbi = (string)listBoxHobbik.SelectedItem;
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(nev + ";" + szulDatum + ";" + nem + ";" + hobbi);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba nem sikerült a kiírás");
                }
            };
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            listBoxHobbik.Items.Add(txtboxHobbi.Text);
            txtboxHobbi.Clear();
        }

        private void BtnMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
