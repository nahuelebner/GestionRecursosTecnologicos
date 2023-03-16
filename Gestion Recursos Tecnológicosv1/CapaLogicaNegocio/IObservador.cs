using Gestion_Recursos_Tecnológicos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Recursos_Tecnológicos.CapaLogicaNegocio
{
    public interface IObservador
    {
        void generarMailsNotificacion(string razonMantenimiento, List<string>[] contactos);
        
    }
}
