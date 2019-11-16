using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta
    {
        #region Atributos
        private int Saldo, NroTarjeta, NroDni;
        #endregion

        #region Constructor
        public void Tarjetas()
        {
            Saldo = 0;
            NroDni = 0;
            NroTarjeta = 0;
        }
        #endregion

        #region Prop/Enc
        public int tSaldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
        public int tNroTarjeta
        {
            get { return NroTarjeta; }
            set { NroTarjeta = value; }
        }
        public int tNroDni
        {
            get { return NroDni; }
            set { NroDni = value; }
        }
        #endregion

        #region MetodoSyR
        public int Sumar(int monto)
        {
            Saldo += monto;
            return Saldo;
        }

        public int Restar(int monto)
        {
            Saldo -= monto;
            return monto;
        }
        #endregion

        #region verficiacion
        
        
        #endregion
    }
}
