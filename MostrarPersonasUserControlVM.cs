using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class MostrarPersonasUserControlVM: ObservableObject
    {
        private List<String> personas;

        public List<String> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        public MostrarPersonasUserControlVM()
        {
            personas = new List<string>();
            personas.Add("Pietro - 30 - Italiana");
            personas.Add("Julia - 25 - Española");
            personas.Add("Sophie - 35 - Francesa");
        }
    }
}
