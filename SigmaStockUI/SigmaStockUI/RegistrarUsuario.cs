using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entity;
using BLL;
using System.Configuration;

namespace SigmaStockUI
{
    public partial class RegistrarUsuario : Form
    {
        PersonaClienteService personaService;
        PersonaProveedorService ProveedorService;
        public RegistrarUsuario()
        {
            
            personaService = new PersonaClienteService(ExtraerCadena.connectionString);
            ProveedorService = new PersonaProveedorService(ExtraerCadena.connectionString);
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int iParam);

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf12, 0);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {


            if (TipoPersonaCbx.SelectedIndex == 1)
            {
                Proveedor persona = new Proveedor();
                persona.Persona.NumeroIdentificacion = IdentificacionTxt.Text;
                persona.Persona.PrimerNombre = NombreUserTxt.Text;
                persona.Persona.PrimerApellido = PrimerApeTxt.Text;
                persona.Persona.SegundoApellido = SegundoApeTxt.Text;
                persona.Persona.DireccionPersona = $"{ViaTxt.Text} {ViaNum1Txt.Text} {ViaNum2Txt.Text}";
                persona.Persona.NumeroTelefonico = NumTelefonoTxt.Text;
                persona.NombreEmpresa = nom_empresatxt.Text;
                string mensaje = ProveedorService.Guardar(persona);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                Cliente persona = new Cliente();
                persona.Persona.NumeroIdentificacion = IdentificacionTxt.Text;
                persona.Persona.PrimerNombre = NombreUserTxt.Text;
                persona.Persona.PrimerApellido = PrimerApeTxt.Text;
                persona.Persona.SegundoApellido = SegundoApeTxt.Text;
                persona.Persona.DireccionPersona = $"{ViaTxt.Text} {ViaNum1Txt.Text} {ViaNum2Txt.Text}";
                persona.Persona.NumeroTelefonico = NumTelefonoTxt.Text;

                string mensaje = personaService.Guardar(persona);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();

            }      
            
            //SaveFileDialog saveFileDialog = new SaveFileDialog();

            //saveFileDialog.Title = "Guardar Informe";

            //saveFileDialog.InitialDirectory = @"c:/document";

            //saveFileDialog.DefaultExt = "pdf";
            //string filename = "";

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    RespuestaConsulta respuestaC = new RespuestaConsulta();
            //    respuestaC = personaService.Consultar();

            //    filename = saveFileDialog.FileName;

            //    if (filename != "" && respuestaC.Personas.Count > 0)

            //    {

            //        string mensajeC = personaService.GenerarPdf(respuestaC.Personas, filename);

            //        MessageBox.Show(mensajeC, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }

            //    else

            //    {

            //        MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);

            //    }
            //}

        }
    


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimpiarCampos()
        {
            IdentificacionTxt.Clear();
            NombreUserTxt.Clear();
            PrimerApeTxt.Clear();
            SegundoApeTxt.Clear();
            NumTelefonoTxt.Clear();
            ViaTxt.Text = "";
            ViaNum1Txt.Text = "";
            ViaNum2Txt.Text = " ";
            DatoAdicionalDirTxt.Text = " ";
            nom_empresatxt.Text = "";
            label11.Visible = false;
            nom_empresatxt.Visible = false;
            TipoPersonaCbx.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoPersonaCbx.SelectedIndex == 1)
            {
                label11.Visible = true;
                nom_empresatxt.Visible = true;
            }
            else
            {
                label11.Visible = false;
                nom_empresatxt.Visible = false;
            }
        }
    }
}
