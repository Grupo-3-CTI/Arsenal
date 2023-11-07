﻿using System;
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
    public partial class frm_FormPrincipal : Form
    {
        Util Utilidade = new Util();

        List<System.Windows.Forms.Label> Titulos = new List<System.Windows.
            Forms.Label>();
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection pfc = new PrivateFontCollection();

        Font capture_it;

        public frm_FormPrincipal()
        {
            InitializeComponent();
            byte[] capture_itData = Properties.Resources.Capture_it;
            IntPtr capture_itPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(capture_itData.Length);
            System.Runtime.InteropServices.Marshal.Copy(capture_itData, 0, capture_itPtr, capture_itData.Length);
            uint dummy = 0;
            pfc.AddMemoryFont(capture_itPtr, Properties.Resources.Capture_it.Length);
            AddFontMemResourceEx(capture_itPtr, (uint)Properties.Resources.Capture_it.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(capture_itPtr);
            capture_it = new Font(pfc.Families[0], 26, FontStyle.Regular);

            Titulos.Add(lbl_titulo1);
            Titulos.Add(lbl_titulo2);
            Titulos.Add(lbl_titulo3);
            Utilidade.usarFonteCustomizada(ref Titulos, capture_it);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormTestes_Resize(object sender, EventArgs e)
        {
            Utilidade.usarFonteCustomizada(ref Titulos, capture_it);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Frm_MuniçãoEstoque form = new Frm_MuniçãoEstoque();
            form.ShowDialog();
        }

        private void btn_Armas_Click(object sender, EventArgs e)
        {
            Frm_ArmasEstoque form = new Frm_ArmasEstoque();
            form.ShowDialog();


        }

        private void cadastroDeArmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ArmasEstoque form = new Frm_ArmasEstoque();
            form.ShowDialog();

        }

        private void cadastroDeMuniçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
