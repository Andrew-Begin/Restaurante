using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Transversal
{
    public class CacheLista
    {
        private int _ID;
        private string _Nombre;
        private string _Apellido;
        private string _Rut;
        private string _Usuario;
        private string _Contrasena;
        private string _Email;
        private string _Fono;
        private int _Rol_id;
        private string _Rol;
        private string _Estado;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }
            set
            {
                _Apellido = value;
            }
        }

        public string Rut
        {
            get
            {
                return _Rut;
            }
            set
            {
                _Rut = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }
            set
            {
                _Usuario = value;
            }
        }
        public string Contrasena
        {
            get
            {
                return _Contrasena;
            }
            set
            {
                _Contrasena = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Fono
        {
            get
            {
                return _Fono;
            }
            set
            {
                _Fono = value;
            }
        }
        public int Rol_id
        {
            get
            {
                return _Rol_id;
            }
            set
            {
                _Rol_id = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }
            set
            {
                _Rol = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }
            set
            {
                _Estado = value;
            }
        }



    }
}
