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
                    int hobbi = listBoxHobbik.SelectedIndex;
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(nev + ";" + szulDatum + ";" + nem + ";" + hobbi);
                        File.WriteAllLines(fileName, listBoxHobbik.Items.Cast<string>().ToArray());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hiba nem sikerült a kiírás");
                }
            };
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    string adatok = sorok[0];
                    string[] listboxAdatok = new string[sorok.Length-1];
                    for (int i = 1; i < sorok.Length + 1; i++)
                    {
                        listboxAdatok[i - 1] = sorok[i];
                    }
                    string[] adat = adatok.Split(';');
                    txtboxNev.Text = adat[0];
                    txtboxSzul.Text = adat[1];
                    if (adat[2] == "Férfi")
                    {
                        radioFerfi.Checked = true;
                    }
                    if (adat[2] == "Nő")
                    {
                        radioNo.Checked = true;
                    }
                    int hobbi = Convert.ToInt32(adat[3]);
                    foreach (var item in listboxAdatok)
                    {
                        listBoxHobbik.Items.Add(item);
                    }
                    listBoxHobbik.SetSelected(hobbi, true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem sikerült megnyitni a fájlt");
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

        private void BtnBetolt_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
