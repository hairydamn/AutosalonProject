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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAutorization.autoriz.type == "Покупатель")
            {
                buttonBuyer.Enabled = false;
            }
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            Form formauto = new FormAuto();
            formauto.Show();
        }

        private void ButtonBuyer_Click(object sender, EventArgs e)
        {
            Form formbuyer = new FormBuyer();
            formbuyer.Show();
        }
    }
}
