using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Conexion;
using System.Data;
using System.Data.SqlClient;

namespace Encapsulamiento
{
    public class EncTarjetas
    {
        #region Atributos
        ConexionTarjeta objDatosTarjeta = new ConexionTarjeta();
        #endregion

        #region Metodos
        public int abmTarjetas(string accion, Tarjeta objTarjeta)
        {
            return objDatosTarjeta.abmTarjetas(accion, objTarjeta);
        }

        public DataSet listadoTarjetas(string cual)
        {
            return objDatosTarjeta.listadoTarjetas(cual);
        }

        public int SumayResta(string accion, Tarjeta objTarjeta)
        { return objDatosTarjeta.SaldoSyR(accion, objTarjeta); }
        #endregion
    }
}
