﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto5B
{
    public partial class FormPrincip : Form
    {
        public FormPrincip()
        {
            InitializeComponent();
        }

        private void btnNerucci_MouseClick(object sender, MouseEventArgs e)
        {
            FormNerucci frNerucci = new FormNerucci();
            frNerucci.Show();
        }

        private void btnGarcia_Click(object sender, EventArgs e)
        {
            FormGarcia frGarcia = new FormGarcia();
            frGarcia.Show();
        }

        private void btnSomigli_Click(object sender, EventArgs e)
        {
            FormSomigli FromSomigli = new FormSomigli();
            FromSomigli.Show();
        }

        private void btnCini_Click(object sender, EventArgs e)
        {
            FormCini FrCini = new FormCini();
            FrCini.Show();
        }

        private void btnVannozzi_Click(object sender, EventArgs e)
        {
            FormVannozzi frVannozzi = new FormVannozzi();
            frVannozzi.Show();
        }

        private void btnRusso_Click(object sender, EventArgs e)
        {
            FormRusso formRusso = new FormRusso();
            formRusso.Show();
        }

        private void btnDangelo_Click(object sender, EventArgs e)
        {
            FormDangelo frDangelo = new FormDangelo();
            frDangelo.Show();
        }

        private void btnNurul_Click(object sender, EventArgs e)
        {
            FormNurul formNurul = new FormNurul();
            formNurul.Show();
        }

        private void btnDuta_Click(object sender, EventArgs e)
        {
            FormDuta formDuta = new FormDuta();
            formDuta.Show();
        }

        private void BTN_Landi_Click(object sender, EventArgs e)
        {
            FormLandi formLandi = new FormLandi();
            formLandi.Show();
        }

        private void btnFlorindo_Click(object sender, EventArgs e)
        {
            FormFlorindo frFlo = new FormFlorindo();
            frFlo.Show();
        }

        private void btnPaolacci_Click(object sender, EventArgs e)
        {
            FormPaolacci frPopa = new FormPaolacci();
            frPopa.Show();
        }
    }
}
