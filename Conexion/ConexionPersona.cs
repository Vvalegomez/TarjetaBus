using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using Conexion;

namespace Conexion
{
    public class ConexionPersona : ConexionBD
    {
        public int abmPersonas(string accion, Persona objPersona)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
                orden = "insert into Persona values (" + objPersona.pDni + "," + objPersona.pCuilCuit + ",'" + objPersona.pNombre + "','" + objPersona.pSexo + "','" + objPersona.pTipoDni + "','" + objPersona.pFechaNacimiento + "');";
            

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar persona", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoPersonas(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Persona where pNroTarjeta  = " + int.Parse(cual) + ";";
            else
                orden = "select * from Persona;";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar personas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
