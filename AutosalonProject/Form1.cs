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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void ButtonReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Name = textBoxName.Text;
            reg.Login = textBoxLogin.Text;
            reg.Password = textBoxPassword.Text;
            Autorization aut = new Autorization();
            aut.Name = textBoxName.Text;
            aut.Login = textBoxLogin.Text;
            aut.Password = textBoxPassword.Text;
            aut.Type = comboBoxType.Text;
            Program.AuDb.Registration.Add(reg);
            Program.AuDb.Autorization.Add(aut);
            Program.AuDb.SaveChanges();
            this.Close();
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
