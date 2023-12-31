﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_CDJ2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textoTelegrama;
            string []palabras;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
            
            textoTelegrama = txtTelegrama.Text;

            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
            else if (rbOrdinario.Checked)
                tipoTelegrama = 'o';
            
            palabras=textoTelegrama.Split(' ');
            numPalabras = palabras.Length;
            
            if (tipoTelegrama == 'o')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5+0.5 * (numPalabras-10);
            else
            
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
