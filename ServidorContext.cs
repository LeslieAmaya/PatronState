using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronState
{
    public class ServidorContext
    {
        private ServerState _state;
        public ServerState State
        {
            get { return _state; }
            set { _state = value; } 
        }

        public void AtenderSolicitud()
        {
            _state.Respuesta();
        }
    }
}
