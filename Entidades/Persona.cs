using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        #region Atributos
        private int Dni, NroTarjeta, CuilCuit;
        private string Nombre, TipoDni;
        private DateTime? FechaNacimiento;
        private char Sexo;
        #endregion

        #region Constructor
        public void Personas()
        {
            Dni = 0;
            NroTarjeta = 0;
            CuilCuit = 0;
            Nombre = string.Empty;
            FechaNacimiento = null;
            Sexo = ' ';
            TipoDni = string.Empty;
        }
        #endregion

        #region Propiedades
        public int pDni
        {
            get { return Dni; }
            set { Dni = value; }
        }
        public int pNroTarjeta
        {
            get { return NroTarjeta; }
            set { NroTarjeta = value; }
        }
        public int pCuilCuit
        {
            get { return CuilCuit; }
            set { CuilCuit = value; }
        }
        public string pNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public DateTime? pFechaNacimiento
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }
        public char pSexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public string pTipoDni
        {
            get { return TipoDni; }
            set { TipoDni = value; }
        }
        #endregion


    }
}
