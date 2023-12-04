
using PatronState;

ServidorContext servidor = new ServidorContext();

servidor.State = new DisponibleServerState();
servidor.AtenderSolicitud();
servidor.AtenderSolicitud();

servidor.State = new SaturadoServerState();
servidor.AtenderSolicitud();
servidor.AtenderSolicitud();

servidor.State = new SuperSaturadoServerState();
servidor.AtenderSolicitud();
servidor.AtenderSolicitud();

servidor.State = new CaídoServerState();
servidor.AtenderSolicitud();
servidor.AtenderSolicitud();

servidor.State = new DisponibleServerState();
servidor.AtenderSolicitud();
servidor.AtenderSolicitud();
