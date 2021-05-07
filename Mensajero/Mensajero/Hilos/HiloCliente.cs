using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensajeroModel.DAL;
using MensajeroModel.DTO;
using SocketUtils;

namespace Mensajero.Hilos
{
    public class HiloCliente
    {
        private ClienteSocket clienteSocket;
        private IMensajesDAL dal = MensajesDALFactory.CreateDal();

        public HiloCliente(ClienteSocket clienteSocket)
        {
            this.clienteSocket = clienteSocket;
        }


        public void Ejecutar()
        {
            string nombre, detalle;
            do
            {
                clienteSocket.Escribir("Ingrese Nombre: ");
                nombre = clienteSocket.Leer().Trim();

            } while (nombre == string.Empty);

            do
            {
                clienteSocket.Escribir("Ingrese Mensaje: ");
                detalle = clienteSocket.Leer().Trim();

            } while (detalle == string.Empty || detalle.Length > 20);

            Mensaje m = new Mensaje()
            {
                Nombre = nombre,
                Detalle = detalle,
                Tipo = "TCP"
            };
            dal.Save(m);
            clienteSocket.CerrarConexion();
        }

    }
}
