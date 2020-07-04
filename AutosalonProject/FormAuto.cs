using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutosalonProject
{
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
            if (FormAutorization.autoriz.type == "Покупатель")
            {
                buttonAdd.Enabled = false;
                buttonEdit.Enabled = false;
                buttonDel.Enabled = false;
                textBoxModel.Enabled = false;
                comboBoxColor.Enabled = false;
                textBoxPrice.Enabled = false;
                textBoxGosNumber.Enabled = false;
                textBoxYearRelease.Enabled = false;
            }
            ShowAuto();
        }
        public void ShowAuto()
        {
            listViewCar.Items.Clear();
            foreach (Auto au in Program.AuDb.Auto)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    au.ID.ToString(),
                    au.Model, au.Color, au.Price, au.GosNumber, au.YearRelease
                });
                item.Tag = au;
                listViewCar.Items.Add(item);
            }

            listViewCar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
 

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Auto au = new Auto();
            au.Model = textBoxModel.Text;
            au.Color = comboBoxColor.Text;
            au.Price = textBoxPrice.Text;
            au.GosNumber = textBoxGosNumber.Text;
            au.YearRelease = textBoxYearRelease.Text;
            Program.AuDb.Auto.Add(au);
            Program.AuDb.SaveChanges();
            ShowAuto();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 1)
            {
                Auto au = listViewCar.SelectedItems[0].Tag as Auto;
                au.Model = textBoxModel.Text;
                au.Color = comboBoxColor.Text;
                au.Price = textBoxPrice.Text;
                au.GosNumber = textBoxGosNumber.Text;
                au.YearRelease = textBoxYearRelease.Text;
                Program.AuDb.SaveChanges();
                ShowAuto();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCar.SelectedItems.Count == 1)
                {
                    Auto au = listViewCar.SelectedItems[0].Tag as Auto;
                    Program.AuDb.Auto.Remove(au);
                    Program.AuDb.SaveChanges();
                    ShowAuto();
                }
                textBoxModel.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                textBoxGosNumber.Text = "";
                textBoxYearRelease.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCar.SelectedItems.Count == 1)
            {
                Auto au = listViewCar.SelectedItems[0].Tag as Auto;
                textBoxModel.Text = au.Model;
                comboBoxColor.Text = au.Color;
                textBoxPrice.Text = au.Price;
                textBoxGosNumber.Text = au.GosNumber;
                textBoxYearRelease.Text = au.YearRelease;
            }
            else
            {
                textBoxModel.Text = "";
                comboBoxColor.Text = "";
                textBoxPrice.Text = "";
                textBoxGosNumber.Text = "";
                textBoxYearRelease.Text = "";
            }
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
