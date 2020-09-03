using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaDeD.forms
{
    public partial class dado : Form
    {
        
        public dado()
        {
            InitializeComponent();
        }
        private void dadovinte()
        {
            Random randNum = new Random();
            for (int i = 0; i < Convert.ToInt32(cbo_Quanti.Text); i++)
                lb_Gerado.Items.Add(randNum.Next(1, Convert.ToInt32(cbo_Dado.Text)) + 1);
            lb_Gerado.Items.Add("-------------------------------------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_Dado.Text) && string.IsNullOrWhiteSpace(cbo_Quanti.Text)) MessageBox.Show("Preencha todas as informações a cima"); else dadovinte();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            lb_Gerado.Items.Clear();
            lb_Gerado.Visible = false;
        }
    }
}
