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
    public partial class FormBuyer : Form
    {
        public FormBuyer()
        {
            InitializeComponent();
            ShowBuyer();
        }
        public void ShowBuyer()
        {
            listViewBuyer.Items.Clear();
            foreach (Buyer au in Program.AuDb.Buyer)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    au.ID.ToString(),
                    au.Name, au.LastName, au.MiddleName, au.Phone, au.Email
                });
                item.Tag = au;
                listViewBuyer.Items.Add(item);
            }

            listViewBuyer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Buyer bu = new Buyer();
            bu.Name = textBoxName.Text;
            bu.LastName = textBoxLastName.Text;
            bu.MiddleName = textBoxMiddleName.Text;
            bu.Phone = textBoxPhone.Text;
            bu.Email = textBoxMail.Text;
            Program.AuDb.Buyer.Add(bu);
            Program.AuDb.SaveChanges();
            ShowBuyer();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBuyer.SelectedItems.Count == 1)
            {
                Buyer bu = listViewBuyer.SelectedItems[0].Tag as Buyer;
                bu.Name = textBoxName.Text;
                bu.LastName = textBoxLastName.Text;
                bu.MiddleName = textBoxMiddleName.Text;
                bu.Phone = textBoxPhone.Text;
                bu.Email = textBoxMail.Text;
                Program.AuDb.SaveChanges();
                ShowBuyer();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBuyer.SelectedItems.Count == 1)
                {
                    Buyer bu = listViewBuyer.SelectedItems[0].Tag as Buyer;
                    Program.AuDb.Buyer.Remove(bu);
                    Program.AuDb.SaveChanges();
                    ShowBuyer();
                }
                textBoxName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxMail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void FormBuyer_Load(object sender, EventArgs e)
        {

        }
    }
}
