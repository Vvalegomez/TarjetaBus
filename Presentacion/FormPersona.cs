using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Encapsulamiento;

namespace Presentacion
{
    public partial class FormPersona : Form
    {
        public Persona objPersona = new Persona();
        
        public EncPersonas objEncPersona = new EncPersonas();
        public FormPersona()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            
            try
            {
              
                FormTarjeta formTarjeta = new FormTarjeta(int.Parse(txtBoxNdni.Text), txtBoxNombre.Text/*, int.Parse(dtFechaNac.Text)*/);
                this.Hide();
                formTarjeta.ShowDialog();
                this.Close();

            }
            catch (Exception)
            {
               
               MessageBox.Show("No se puede realizar la accion, Debe crear una persona");
                
            }
            
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Obj();

            nGrabados = objEncPersona.abmPersonas("Alta", objPersona);

            if (nGrabados == -1)
            { lblDato.Text = "  No pudo grabar la Persona en el sistema"; }
            else
            {
                lblDato.Text = "  Se grabó con éxito Persona.";
                
            }
        }

        private void TxtBox_a_Obj()
        {
            objPersona.pDni = int.Parse(txtBoxNdni.Text);
            objPersona.pCuilCuit = int.Parse(txtBoxCuil.Text);
            objPersona.pNombre = Convert.ToString(txtBoxNombre.Text);
            objPersona.pSexo = Convert.ToChar(cbSexo.SelectedItem);
            objPersona.pTipoDni = Convert.ToString(cbTdni.SelectedItem);
            objPersona.pFechaNacimiento = Convert.ToDateTime(dtFechaNac.Value);

        }

        private void ControlNumero(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ControlCaracter(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBoxNdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtBoxNtarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtBoxCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCaracter(e);
        }

        private void dtFechaNac_ValueChanged(object sender, EventArgs e)
        {
           /* DateTime pEdad = DateTime.Today;
            int edad = pEdad.Year - dtFechaNac.Value.Year;
            if (pEdad < dtFechaNac.Value.AddYears(edad)) edad--;*/
        }
    }
}
