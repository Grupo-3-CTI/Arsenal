using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Arsenal_Nacional_de_Armas_e_Logística
{
    public partial class Frm_Ajuda : Form
    {
        Util Utilidade = new Util();
        private PrivateFontCollection pfc = new PrivateFontCollection();
        public Frm_Ajuda()
        {
            InitializeComponent();
        }
        private void llb_Email_Fernando_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + llb_Email_Fernando.Text);
        }

        private void tsmi_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
