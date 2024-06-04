using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace lab02
{
    public partial class Form1 : Form
    {

        private List<Pracownik> listaPracownikow = new List<Pracownik>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool isTextboxNotEmptyError(TextBox tb)
        {
            if(tb.Text=="")
            {
                errorProvider.SetError(tb,"Puste pole");
                return false;
            }
            else
            {
                errorProvider.SetError(tb, "");
                return true;
            }
        }

        private bool isBirthdayNotEmpty(DateTimePicker dt)
        {
            if(dt.Value==null)
            {
                errorProvider.SetError(dt, "Puste pole");
                return false;
            }
            else
            {
                errorProvider.SetError(dt, "");
                return true;
            }
        }

        private bool isSalaryNotEmpty(NumericUpDown nud)
        {
            if (nud.Value == null)
            {
                errorProvider.SetError(nud, "Puste pole");
                return false;
            }
            else
            {
                errorProvider.SetError(nud, "");
                return true;
            }
        }

        private bool isPositionNotEmpty(ComboBox cb)
        {
            if (cb.Text=="")
            {
                errorProvider.SetError(cb, "Puste pole");
                return false;
            }
            else
            {
                errorProvider.SetError(cb, "");
                return true;
            }
        }

        private bool isContractNotEmpty()
        {
            if (radioButtonContract1.Checked==false && radioButtonContract2.Checked == false && radioButtonContract3.Checked == false)
            {
                errorProvider.SetError(radioButtonContract1, "Puste pole");
                return false;
            }
            else
            {
                errorProvider.SetError(radioButtonContract1, "");
                return true;
            }
        }

        private string getActiveContract()
        {
            if(radioButtonContract1.Checked==true)
            {
                return radioButtonContract1.Text;
            }
            else if (radioButtonContract2.Checked == true)
            {
                return radioButtonContract2.Text;
            }
            else if (radioButtonContract3.Checked == true)
            {
                return radioButtonContract3.Text;
            }
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(isTextboxNotEmptyError(textBoxName) & isTextboxNotEmptyError(textBoxLastName) & isSalaryNotEmpty(numericUpDownSalary) &
                isBirthdayNotEmpty(dateTimePickerBirthday) & isPositionNotEmpty(comboBoxPosition) & isContractNotEmpty())
            {

                Pracownik p = new Pracownik(textBoxName.Text, textBoxLastName.Text, dateTimePickerBirthday.Value.Date, numericUpDownSalary.Value, comboBoxPosition.Text, getActiveContract());
                foreach(Pracownik p2 in listaPracownikow)
                {
                    if(p2.IsSameAs(p))
                    {
                        errorProvider.SetError(textBoxName, "Ten obiekt już istnieje.");
                        return;
                    }
                }
                listaPracownikow.Add(p);
                listBoxWorkers.Items.Add(listaPracownikow.Last());

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML file|*.xml|txt file|*.txt";
            sfd.RestoreDirectory = true;
            sfd.FileName = "pracownicy";
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                SaveState Save = new SaveState();
                if(sfd.FileName.EndsWith(".xml"))
                {
                    Save.SaveToXMLFile(listaPracownikow,sfd.FileName);
                }
                else if(sfd.FileName.EndsWith(".txt"))
                {
                    Save.SaveToTxtFile(listaPracownikow, sfd.FileName);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML file|*.xml|txt file|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadState Load = new LoadState();
                    if (ofd.FileName.EndsWith(".xml"))
                    {
                        listaPracownikow=Load.LoadFromXMLFile(ofd.FileName);
                    }
                    else if (ofd.FileName.EndsWith(".txt"))
                    {
                        listaPracownikow=Load.LoadFromTxtFile(ofd.FileName);
                    }
                    listBoxWorkers.Items.Clear();
                    foreach (Pracownik p in listaPracownikow)
                    {
                        listBoxWorkers.Items.Add(p);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Wystąpił błąd: "+exc.Message); 
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pracownik p = listBoxWorkers.SelectedItem as Pracownik;
            if(p!=null)
            {
                textBoxName.Text = p.Imie;
                textBoxLastName.Text = p.Nazwisko;
                dateTimePickerBirthday.Value = p.DataUrodzenia;
                numericUpDownSalary.Value = p.Pensja;
                comboBoxPosition.Text = p.Stanowisko;
                if(p.Umowa==radioButtonContract1.Text)
                {
                    radioButtonContract1.Checked = true;
                }
                else if(p.Umowa==radioButtonContract2.Text)
                {
                    radioButtonContract2.Checked = true;
                }
                else if (p.Umowa == radioButtonContract3.Text)
                {
                    radioButtonContract3.Checked = true;
                }
            }
        }
    }
}
