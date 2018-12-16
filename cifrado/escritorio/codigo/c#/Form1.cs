using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodificacionCesar
{
    public partial class TexBoxTexto : Form
    {
        public TexBoxTexto()
        {
            InitializeComponent();
        }

        private void labelnxGru_Click(object sender, EventArgs e)
        {

        }

        private void labelGru_Click(object sender, EventArgs e)
        {

        }

      unsafe  private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sa = "";
            string des = "";
            string transpGrupo = "";
            char alid = ' ';
            procEncriptado encriptado = new procEncriptado();
            procDesencriptar desencriptado =  new procDesencriptar();
            TranXGrupo encrGrup =new TranXGrupo();
            int despl = 0;
            if (comboBoxDesp.SelectedItem.ToString() != "")
                despl = Convert.ToInt32(comboBoxDesp.SelectedItem.ToString());
            int grupo = Convert.ToInt32(comboBoxGr.SelectedItem.ToString());
            int pos = 0;
            /*Texto Cifrado*/
            for (int itera = 0; itera < textBoxTex.Text.Length; itera++)
            {
                sa = sa + encriptado.retornarCaracter(textBoxTex.Text[itera], despl);
                transpGrupo = encrGrup.traspoGrupo(textBoxTex.Text[itera], grupo, &pos, transpGrupo, &alid);
            }

            textBoxCifr.Text = sa;
            //EncriptadoInverso
            EncripInversa encrInversa =  new EncripInversa();
            textBoxInv.Text = encrInversa.encriptarInversa(textBoxTex.Text);
            //Transposicion por grupo
            textBoxGru.Text = transpGrupo;

            /*Texto Decifrado
            for (int itera = 0; itera < textBoxCifr.Text.Length; itera++)
            {
                des = des + desencriptado.retornarCaracter(textBoxCifr.
                    Text[itera], despl);
            }
            textB.Text = gcnew String(des.c_str());*/



        }
    }
}
