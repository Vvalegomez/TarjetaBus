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
    public class EncPersonas
    {
        #region Atributos
        ConexionPersona objDatosPersona = new ConexionPersona();
        #endregion

        #region Metodos
        public int abmPersonas(string accion, Persona objPersona)
        {
            return objDatosPersona.abmPersonas(accion, objPersona);
        }

        public DataSet listadoTarjetas(string cual)
        {
            return objDatosPersona.listadoPersonas(cual);
        }
        #endregion
    }
}
