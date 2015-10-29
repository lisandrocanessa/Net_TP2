using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class BusinessEntity
    {
        private int _ID;
        private States _State;

        public BusinessEntity()
        {
            this.State = States.New;
        }

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

        public States State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
            }
        }

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }

        public enum TiposCargos
        {
            Titular,
            Adjunto,
            Ayudante,
            Suplente
        }

        public enum TiposPersonas
        {
            Default,
            Administrador,
            Alumno,
            Docente
        }
    }


}
