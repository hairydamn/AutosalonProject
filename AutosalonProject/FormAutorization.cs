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
    public struct User
    {
        public string name;
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAutorization : Form
    {
        public static User autoriz = new User();
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form formreg = new FormRegistration();
            formreg.Show();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool k = false;
                foreach (Autorization user in Program.AuDb.Autorization)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password && textBoxName.Text == user.Name && comboBoxType.Text == user.Type)
                    {
                        k = true;
                        autoriz.name = user.Name;
                        autoriz.login = user.Login;
                        autoriz.password = user.Password;
                        autoriz.type = user.Type;
                    }
                }
                if (!k)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    textBoxName.Text = "";
                    comboBoxType.Text = "";
                }
                else
                {
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide();
                }
            }
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }

        public void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
