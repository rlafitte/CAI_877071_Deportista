using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Deporte
    {
        private string s_nombre;
        private int i_cantJugadores;
        private bool b_eSport;

        public string Nombre
        {
            get
            {
                return this.s_nombre;
            }
            set
            {
                this.s_nombre = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.i_cantJugadores;
            }
            set
            {
                this.i_cantJugadores = value;
            }
        }

        public bool ESport
        {
            get
            {
                return this.b_eSport;
            }
            set
            {
                this.b_eSport = value;
            }
        }

        
    }
}
