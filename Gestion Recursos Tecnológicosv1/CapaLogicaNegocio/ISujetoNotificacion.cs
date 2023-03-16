using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.CapaLogicaNegocio
{
    public interface ISujetoNotificacion
    {
        void suscribir(IObservador observador);
        void quitar(IObservador observador);
        void notificar();

    }
}
