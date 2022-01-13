using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class NavigationService
    {
        internal UserControl CaragarVistaNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        internal UserControl CaragarVistaMostrarPersonas()
        {
            return new MostrarPersonasUserControl();
        }
    }
}
