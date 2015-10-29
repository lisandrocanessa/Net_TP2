using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IDModulo;
        private int _IDUsuario;
        private bool _PermiteBaja;
        private bool _PermiteModificacion;
        private bool _PermiteAlta;
        private bool _PermiteConsulta;

        public int IDModulo
        {
            get
            {
                return _IDModulo;
            }
            set
            {
                _IDModulo = value;
            }
        }

        public int IDUsuario
        {
            get
            {
                return _IDUsuario;
            }
            set
            {
                _IDUsuario = value;
            }
        }

        public bool PermiteBaja
        {
            get
            {
                return _PermiteBaja;
            }
            set
            {
                _PermiteBaja = value;
            }
        }

        public bool PermiteAlta
        {
            get
            {
                return _PermiteAlta;
            }
            set
            {
                _PermiteAlta = value;
            }
        }

        public bool PermiteModificacion
        {
            get
            {
                return _PermiteModificacion;
            }
            set
            {
                _PermiteModificacion = value;
            }
        }

        public bool PermiteConsulta
        {
            get
            {
                return _PermiteConsulta;
            }
            set
            {
                _PermiteConsulta = value;
            }
        }
    }

}
