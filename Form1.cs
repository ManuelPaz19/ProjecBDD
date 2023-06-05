using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appProyectoBDD.Logica;

namespace appProyectoBDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (cbxCategoria.Items.Count > 0)
            {
                cbxCategoria.SelectedIndex = 0;
            }
                
                
        }
        //Creo un objeto de la clase Biblioteca
        Biblioteca miBiblioteca = new Biblioteca();

        private void btnGuardarBib_Click(object sender, EventArgs e)
        {
            //Capturo las variables 
            int nitBib,r;
            string nomBib;                    
            nitBib = int.Parse(txtNitBib.Text);
            nomBib = txtNomBib.Text;

            //Envio las variables a la capa de la logica
            r =miBiblioteca.ingresarBiblioteca(nitBib, nomBib);
            if (r > 0)
            {
                MessageBox.Show("Biblioteca registrada", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Biblioteca no registrada", "Mensanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //limpiar cajas de texto
            txtNitBib.Clear();
            txtNomBib.Clear();
        }

        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            //Capturo las variables
            int codLib, numpag, n;
            string libTitulo, libCategoria;

            codLib = int.Parse(txtCodLibro.Text);
            libTitulo = txtTituloLibro.Text;
            numpag = int.Parse(txtNumPag.Text);
            libCategoria = cbxCategoria.SelectedItem.ToString();

            //Envio las variables a la capa de logica
            n = miBiblioteca.ingresarLibro(codLib,libTitulo, numpag ,libCategoria);
            if (n > 0)
            {
                MessageBox.Show("Libro registrado", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Libro no registrado", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //limpiar cajas de texto
            txtCodLibro.Clear();
            txtNumPag.Clear();
            txtTituloLibro.Clear();
        }

        private void btnBuscarLibroAventura_Click(object sender, EventArgs e)
        {
            DataSet miDS = new DataSet();
            miDS = miBiblioteca.consultarLibrosAventura();
            lbConsultaAventura.Text = miDS.Tables[0].Rows[0]["COUNT(libcod)"].ToString();

        }

        private void btnGuardarLibroEnBiblioteca_Click(object sender, EventArgs e)
        {
            int codLib, nitBib,f;
            codLib = int.Parse(txtCodLibroReg.Text);
            nitBib = int.Parse(txtnitBibliotecaReg.Text);
            
            string fechaIn = dtFechaIn.Value.ToShortDateString();
            string fechaFin = dtFechaFin.Value.ToShortDateString();
 

            //Envio las variables
            f = miBiblioteca.ingresarRegistro(nitBib, codLib,fechaIn, fechaFin );
            if (f > 0)
            {
                MessageBox.Show("Libro registrado en la biblioteca", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Libro no registrado en la biblioteca", "Mesanje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtnitBibliotecaReg.Clear();
            txtCodLibroReg.Clear();
        }

        private void btnConsultarNitBibliotecaYFecha_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();

            int nitBibConsulta;
            nitBibConsulta = int.Parse(txtNitBuscarBiblioteca.Text);
            string fechaFinConsulta = dtFechaInConsulta.Value.ToShortDateString();
            dsResultado = miBiblioteca.consultarNitYFecha(nitBibConsulta , fechaFinConsulta);
            dvgConsulta.DataSource = dsResultado;
            dvgConsulta.DataMember = "ResultadoDatos";
            //limpiar caja de texto
            txtNitBuscarBiblioteca.Clear();

        }
        /**
         * validaciones de textBox
         */
        ErrorProvider error = new ErrorProvider();//para mostrar mensaje de advertencia o error en caja de texto

        private static bool esNumero(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
        private static bool NoEsNumero(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return false;
            }
            else
                return true;
        }
        private static bool textosVacios(TextBox texto)
        {
            if(texto.Text == string.Empty)
            {
                texto.Focus();
                return true;
            }
            else
                return false;
        }
        
        private void txtNitBib_KeyPress(object sender, KeyPressEventArgs e)
        {
           bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtNitBib, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtNitBuscarBiblioteca_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtNitBuscarBiblioteca, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtCodLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtCodLibro, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtNumPag_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtNumPag, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtnitBibliotecaReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtnitBibliotecaReg, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtCodLibroReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.esNumero(e);
            if (!valida)
                error.SetError(txtCodLibroReg, "Sólo se admiten números");
            else
                error.Clear();
        }

        private void txtNitBib_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtNitBib))
                error.SetError(txtNitBib, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtNomBib_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtNomBib))
                error.SetError(txtNomBib, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtCodLibro_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtCodLibro))
                error.SetError(txtCodLibro, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtTituloLibro_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtTituloLibro))
                error.SetError(txtTituloLibro, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtNumPag_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtNumPag))
                error.SetError(txtNumPag, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtNitBuscarBiblioteca_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtNitBuscarBiblioteca))
                error.SetError(txtNitBuscarBiblioteca, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtnitBibliotecaReg_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtnitBibliotecaReg))
                error.SetError(txtnitBibliotecaReg, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtCodLibroReg_Leave(object sender, EventArgs e)
        {
            if (Form1.textosVacios(txtCodLibroReg))
                error.SetError(txtCodLibroReg, "No se puede dejar el campo vacío");
            else
                error.Clear();
        }

        private void txtNomBib_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Form1.NoEsNumero(e);
            if (!valida)
                error.SetError(txtNomBib, "No se admiten números");
            else
                error.Clear();
        }

        private void pnlRegistroBib_Paint(object sender, PaintEventArgs e)
        {
            if(txtNitBib.TextLength != 0 && txtNomBib.TextLength != 0)
                btnGuardarBib.Enabled = true;
            else
                btnGuardarBib.Enabled = false;
        }

        private void pnlLibro_Paint(object sender, PaintEventArgs e)
        {
            if (txtTituloLibro.TextLength != 0 && txtCodLibro.TextLength != 0 && 
                txtNumPag.TextLength != 0)

                btnGuardarLibro.Enabled = true;

            else
                btnGuardarLibro.Enabled = false;
        }

        private void tpConsultas_Paint(object sender, PaintEventArgs e)
        {
            if (txtNitBuscarBiblioteca.TextLength != 0)
                btnConsultarNitBibliotecaYFecha.Enabled = true;
            else
                btnConsultarNitBibliotecaYFecha.Enabled = false;
        }

        private void pnlRegistrarLibroEnBiblioteca_Paint(object sender, PaintEventArgs e)
        {
            if (txtnitBibliotecaReg.TextLength != 0 && txtCodLibroReg.TextLength != 0)
                btnGuardarLibroEnBiblioteca.Enabled = true;
            else
                btnGuardarLibroEnBiblioteca.Enabled = false;
        }
    }
}
