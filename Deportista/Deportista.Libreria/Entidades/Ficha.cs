using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Ficha
    {
        private string s_nombre;
        private string s_apellido;
        private int i_documento;
        private string s_tipoDoc;
        private string s_sexo;
        private Deporte[] deporte;
        private int i_altCM;
        private Club[] club;
        
        public Club clubActual
        {
            get;set;
        }

        public int Altura
        {
            get
            {
                return this.i_altCM;
            }
            set
            {
                this.i_altCM = value;
            }
        }

        public Deporte dep
        {
            get;set;
        }
        public string s_Nombre
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
        //s_apellido
        public string s_Apellido
        {
            get
            {
                return this.s_apellido;
            }
            set
            {
                this.s_apellido = value;
            }
        }
        //i_documento
        public int i_Documento
        {
            get
            {
                return this.i_documento;
            }
            set
            {
                this.i_documento = value;
            }
        }
        //s_tipodoc
        public string s_Tipodoc
        {
            get
            {
                return this.s_tipoDoc;
            }
            set
            {
                this.s_tipoDoc = value;
            }
        }
        //s_sexo
        public string s_Sexo
        {
            get
            {
                return this.s_sexo;
            }
            set
            {
                this.s_sexo = value;
            }
        }

 
    }
}
