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
        PersonaProveedorService PersonaProveedor;
        public RegistrarUsuario()
        {
            
            personaService = new PersonaClienteService(ExtraerCadena.connectionString);
            PersonaProveedor = new PersonaProveedorService(ExtraerCadena.connectionString);
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
            if (TipoPersonaCbx.SelectedIndex==0)
            {
                Cliente cliente = new Cliente();
                cliente.Persona.NumeroIdentificacion = IdentificacionTxt.Text;
                cliente.Persona.PrimerNombre = NombreUserTxt.Text;
                cliente.Persona.PrimerApellido = PrimerApeTxt.Text;
                cliente.Persona.SegundoApellido = SegundoApeTxt.Text;
                cliente.Persona.DireccionPersona = $"{ViaTxt.Text} {ViaNum1Txt.Text} {ViaNum2Txt.Text}";
                cliente.Persona.NumeroTelefonico = NumTelefonoTxt.Text;
                cliente.Persona.Email = EmailTxt.Text;
                string mensaje = personaService.Guardar(cliente);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Persona.NumeroIdentificacion = IdentificacionTxt.Text;
                proveedor.Persona.PrimerNombre = NombreUserTxt.Text;
                proveedor.Persona.PrimerApellido = PrimerApeTxt.Text;
                proveedor.Persona.SegundoApellido = SegundoApeTxt.Text;
                proveedor.Persona.DireccionPersona = $"{ViaTxt.Text} {ViaNum1Txt.Text} {ViaNum2Txt.Text}";
                proveedor.Persona.NumeroTelefonico = NumTelefonoTxt.Text;
                proveedor.Persona.Email = EmailTxt.Text;
                proveedor.NombreEmpresa = Nom_EmpresaTxt.Text;
                string mensaje = PersonaProveedor.Guardar(proveedor);
                MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                LimpiarCampos();
            }

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
            EmailTxt.Text = " ";
            TipoPersonaCbx.Text = "";
            Nom_EmpresaTxt.Text = "";
            label10.Visible = false;
            Nom_EmpresaTxt.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoPersonaCbx.SelectedIndex==1)
            {
                label10.Visible = true;
                Nom_EmpresaTxt.Visible = true;
            }
            else
            {
                label10.Visible = false;
                Nom_EmpresaTxt.Visible = false;
            }
        }
    }
}
