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
    public class ConexionTarjeta : ConexionBD
    {
        public int abmTarjetas(string accion, Tarjeta objTarjeta)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
                orden = "insert into Tarjeta values (" + objTarjeta.tNroTarjeta +
                    "," + objTarjeta.tNroDni + "," + objTarjeta.tSaldo + ") ;";
            if (accion == "Modificar")
                orden = "update Tarjeta set tSaldo= " + objTarjeta.tSaldo + "where tNroTarjeta=" +
                    objTarjeta.tNroTarjeta + ";";

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Tarjetas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        #region MetodoListarTarjeta
        public DataSet listadoTarjetas(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Tarjeta where tNroTarjeta  = " + int.Parse(cual) + ";";
            else
                orden = "select * from Tarjeta;";

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

                throw new Exception("Error al listar tarjetas", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
        #endregion

        #region SumaRestaSaldo
        public int SaldoSyR(string accion, Tarjeta objTarjeta)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Sumar")
            { orden = "update Tarjeta set tSaldo= " + objTarjeta.tSaldo + "where tNroTarjeta =" + objTarjeta.tNroTarjeta ; }
            if (accion == "Restar")
            { orden = "update Tarjeta set tSaldo= " + objTarjeta.tSaldo + "where tNroTarjeta =" + objTarjeta.tNroTarjeta ; }

            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar o Restar Saldo", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;

        }
        #endregion

        #region verificacion
       
        #endregion

    }
}
