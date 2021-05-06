using MensajeroModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensajeroModel.DAL
{
    //INTERFAZ
    public interface IMensajesDAL
    {
        void Save(Mensaje m);

        List<Mensaje> GetAll();
    }
}
