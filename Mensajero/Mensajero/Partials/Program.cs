using MensajeroModel.DAL;
using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajero.Partials
{
    public partial class Program
    {
        //1. Crear Menu
        //2. Dos metodos IngresarMensajes y MostrarMensajes
        //3. Al ingresar un mensjae definir el tipo como aplicacion

        static IMensajesDAL dal = MensajesDALFactory.CreateDal();

        static void IngresarMensaje()
        {
            string nombre, detalle;
            do
            {
                Console.WriteLine("Ingrese Nombre: ");
                nombre = Console.ReadLine().Trim();

            } while (nombre == string.Empty);

            do
            {
                Console.WriteLine("Ingrese Mensaje: ");
                detalle = Console.ReadLine().Trim();

            } while (detalle == string.Empty || detalle.Length > 20);

            Mensaje m = new Mensaje()
            {
                Nombre = nombre,
                Detalle = detalle,
                Tipo = "Aplicacion"
            };
            lock (dal)
            {
                dal.Save(m);
            }
        }

        static void MostrarMensajes()
        {
            List<Mensaje> mensajes = dal.GetAll();
            mensajes.ForEach(m =>
            {
                Console.Write("Nombre: {0} Detalle: {1} Tipo {2} \n", m.Nombre, m.Detalle, m.Tipo);
            });

        }

        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1. Ingrese Mensaje");
            Console.WriteLine("2. Mostrar Mensaje");
            Console.WriteLine("0. Salir");
            string opcion = Console.ReadLine().Trim();
            switch (opcion)
            {
                case "1":
                    IngresarMensaje();
                    break;
                case "2":
                    MostrarMensajes();
                    break;
                case "0":
                    continuar = false;
                    break;
            }
            return continuar;
        }

    }
}
