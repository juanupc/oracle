using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Insertar(new Usuario(txtId.Text,txtNombre.Text, txtDescripcion.Text));
        }
        void Insertar(Usuario usuario)
        {
            var respuesta= new Datos.RepositorioUsuario().InsertarUsuario(usuario);
            MessageBox.Show(respuesta);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        void Consultar()
        {
            var usuarios= new Datos.RepositorioUsuario().ConsultarUsuario();
            GrillaUsuarios.DataSource=usuarios;
        }
    }
}
