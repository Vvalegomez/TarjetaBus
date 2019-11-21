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
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class FormTarjeta : Form
    {
        public Tarjeta objTarjeta = new Tarjeta();
        public EncTarjetas objEncTarjetas = new EncTarjetas();
        public FormTarjeta()
        {
            InitializeComponent();
            ArmarDGV();
            LlenarDGV();
        }

        public FormTarjeta(int pDni, string pNombre, DateTime pEdad)
        {

            InitializeComponent();
            ArmarDGV();
            LlenarDGV();
            txtDtarjeta.Text = pDni.ToString();
            lblNombre.Text = "Nombre: " + pNombre;
            lblEdad.Text = "Fecha de Nacimiento: " + pEdad.ToString();
            
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

        private void ArmarDGV()
        {
            dgvTarjeta.ColumnCount = 3;
            dgvTarjeta.Columns[0].HeaderText = "Nro Tarjeta";
            dgvTarjeta.Columns[1].HeaderText = "Dni Tarjeta";
            dgvTarjeta.Columns[2].HeaderText = "Saldo";
            dgvTarjeta.Columns[0].Width = 70;
            dgvTarjeta.Columns[1].Width = 70;
            dgvTarjeta.Columns[2].Width = 70;
        }


        private void Limpiar()
        {
            txtDtarjeta.Text = string.Empty;
            txtNtarjeta.Text = string.Empty;
            txtSaldo.Text = string.Empty;
        }

        private void LlenarDGV()
        {
            dgvTarjeta.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objEncTarjetas.listadoTarjetas("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que se quiera mostrar se pone acá.
                    dgvTarjeta.Rows.Add(dr[0].ToString(), dr[1], dr[2]);
                }
            }
            else
                lblMensaje.Text = "No hay tarjetas cargados en el sistema";
        }

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            try
            {
                objTarjeta.tNroTarjeta = int.Parse(txtNtarjeta.Text);
                objTarjeta.tNroDni = int.Parse(txtDtarjeta.Text);
                objTarjeta.tSaldo = int.Parse(txtSaldo.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Error.");
            }

        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txtNtarjeta.Text = ds.Tables[0].Rows[0]["tNroTarjeta"].ToString();
            txtDtarjeta.Text = ds.Tables[0].Rows[0]["tNroDni"].ToString();
            txtSaldo.Text = ds.Tables[0].Rows[0]["tSaldo"].ToString();
            txtNtarjeta.Enabled = false;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int nGrabados = -1;
                //llamo al método que carga los datos del objeto
                TxtBox_a_Obj();
                nGrabados = objEncTarjetas.abmTarjetas("Agregar", objTarjeta); //invoco a la capa de negocio

                if (nGrabados == -1)
                    lblMensaje.Text = " No pudo grabar tarjeta en el sistema";
                else
                {
                    lblMensaje.Text = " Se grabó con éxito tarjeta.";
                    LlenarDGV();
                    Limpiar();
                }
            }
            catch { MessageBox.Show("No hay una persona, debe crear una"); }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int nResultado = -1;
                TxtBox_a_Obj();
                nResultado = objEncTarjetas.abmTarjetas("Modificar", objTarjeta); //invoco a la capa de negocio
                if (nResultado == -1)
                {
                    MessageBox.Show("Aviso", "La tarjeta fue Modificada con éxito");
                    Limpiar();
                    LlenarDGV();
                    txtNtarjeta.Enabled = true;
                }
                else
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar la tarjeta");
            }
            catch
            {
                MessageBox.Show("No se puede modificar sin valores.");
            }
        }

        private void dgvTarjeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            objTarjeta.tNroTarjeta = Convert.ToInt32(dgvTarjeta.CurrentRow.Cells[0].Value);
            ds = objEncTarjetas.listadoTarjetas(objTarjeta.tNroTarjeta.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBox(ds);
                btGrabar.Visible = false;
                lblMensaje.Text = string.Empty;
            }
        }

        private void btAgregarPers_Click(object sender, EventArgs e)
        {
            FormPersona nuevaPersona = new FormPersona();
            this.Hide();
            nuevaPersona.ShowDialog();
            this.Close();

        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            try
            {
                int nResultado = -1;

                objTarjeta.Sumar(int.Parse(txtBoxMonto.Text));
                nResultado = objEncTarjetas.SumayResta("Sumar", objTarjeta);
                if (nResultado != -1)
                {
                    MessageBox.Show("Aviso", "La Suma fue hecha con éxito");
                    Limpiar();
                    LlenarDGV();
                    txtNtarjeta.Enabled = true;
                    txtSaldo.Enabled = true;
                }
                else
                    MessageBox.Show("Error", "Se produjo un error al intentar Sumar saldo a la tarjeta");
            }
            catch
            {
                MessageBox.Show("Error, debe asignar un valor.");
            }
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            try
            {
                int nResultado = -1;

                objTarjeta.Restar(int.Parse(txtBoxMonto.Text));
                nResultado = objEncTarjetas.SumayResta("Restar", objTarjeta);

                if (nResultado != -1)
                {
                    MessageBox.Show("Aviso", "El Descuento fue hecho con éxito");
                    Limpiar();
                    LlenarDGV();
                    txtNtarjeta.Enabled = true;
                }
                else
                    MessageBox.Show("Error", "Se produjo un error al intentar descontar saldo de la tarjeta");
            }
            catch
            {
                MessageBox.Show("Error, debe asignar un valor.");
            }
        }

        private void txtNtarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
            
        }

        private void txtDtarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void txtBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlNumero(e);
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
