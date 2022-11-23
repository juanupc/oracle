using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Oracle.ManagedDataAccess.Client;
namespace Datos
{
    public class RepositorioUsuario: BaseDatos
    {
        public string InsertarUsuario(Usuario usuario)
        {
            string ssql = string.Format("insert into usuario values('{0}','{1}','{2}')", usuario.Id, usuario.Nombre, usuario.Descripcion);
            OracleCommand cmd= new OracleCommand(ssql,cnn);
            cnn.Open();
            var resp= cmd.ExecuteNonQuery();
            return resp > 0 ? "se agrego" : "No agrego registro";
        }
        public List<Usuario> ConsultarUsuario()
        {
            List<Usuario> usuarios= new List<Usuario>();
            string ssql = string.Format("select * from usuario");
            OracleCommand cmd = new OracleCommand(ssql, cnn);
            cnn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                usuarios.Add(new Usuario(reader.GetString(0),reader.GetString(1),reader.GetString(2)));

            }


            cnn.Close();
            return usuarios;
        }
    }
}
