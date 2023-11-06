using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class Frm_ArmasEstoque : Form
    {
        Util Utilidade = new Util();

        public Frm_ArmasEstoque()
        {
            InitializeComponent();
        }

        private void txt_Pesquisa_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_Pesquisa_Enter(object sender, EventArgs e)
        {
            txt_Pesquisa.Text = "";
            txt_Pesquisa.ForeColor = Color.Black;
        }

        private void txt_Pesquisa_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Pesquisa.Text))
            {
                txt_Pesquisa.Text = "Pesquisar...";
                txt_Pesquisa.ForeColor = Color.DimGray;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ArmasEstoque_Load(object sender, EventArgs e)
        {

        }

        private void tsmi_Home_Click(object sender, EventArgs e)
        {
            frm_FormPrincipal form = new frm_FormPrincipal();
            form.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
