using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Guia9Ejercicio8
{
    public partial class Form1 : Form
    {
        Division Palabra = new Division();
        public Form1()
        {
            InitializeComponent();
            ttAyuda.SetToolTip(btnInsert, "PRESIONE PARA INSERTAR UNA FRASE");
            ttAyuda.SetToolTip(btnClear, "PRESIONE PARA PODER LIMPIAR LOS DATOS INGRESADOS");
            ttAyuda.SetToolTip(btnClose, "PRESIONE PARA PODER CERRAR DEL PROGRAMA");
            ttAyuda.SetToolTip(lblFrasNor, "AQUI SE MOSTRA LA FRASE INGRESADA");
            ttAyuda.SetToolTip(lbFrasDes, "AQUI SE MUESTRA LA FRASE DESCOMPUESTA POR PALABRAS Y LA CANTIDAD DE LETRAS QUE TIENE CADA PALABRA");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lbFrasDes.Items.Clear();
            string frase = null;
            do
            {
                frase = Microsoft.VisualBasic.Interaction.InputBox("INSERTE LA FRASE QUE DESEE", "INSERTE FRASE");
            } while (frase == null);

            frase = frase.Trim().ToUpper();
            lblFrasNor.Text = frase;
            Palabra.Pikachu = frase;

            for (int i = 0; i < Palabra.DividirFrase().Length; i++)
            {
                lbFrasDes.Items.Add("PALABRA: " + Palabra.DividirFrase()[i] + " - LETRAS: " + Palabra.DividirFrase()[i].Length);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFrasNor.Text = "-";
            lbFrasDes.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cerrar;
            cerrar = MessageBox.Show("DESEA CERRAR EL PROGRAMA?", "ADVERTENCIA DE CERRADO",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cerrar == DialogResult.Yes)
                Close();
        }
    }
}
