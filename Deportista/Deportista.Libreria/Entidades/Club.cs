using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Club
    {
        private string s_nombreClub;
        private string s_fechaCreacion;
        private string s_ubicacion;
        private int i_cantSocios;
        private int i_cantTrofeos;
        private Deporte[] depPracticados;

        public Deporte deportepracticado
        {
            get;set;
        }
        public int CantidadTrofeos
        {
            get
            {
                return this.i_cantTrofeos;
            }
            set
            {
                this.i_cantTrofeos = value;
            }
        }
        public int CantidadSocios
        {
            get
            {
                return this.i_cantSocios;
            }
            set
            {
                this.i_cantSocios = value;
            }
        }
        public string Ubicacion
        {
            get
            {
                return this.s_ubicacion;
            }
            set
            {
                this.s_ubicacion = value;
            }
        }

        public string Creacion
        {
            get
            {
                return this.s_fechaCreacion;
            }
            set
            {
                this.s_fechaCreacion = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.s_nombreClub;
            }
            set
            {
                this.s_nombreClub = value;
            }
        }

    }
}
