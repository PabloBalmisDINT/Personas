using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class MostrarPersonasUserControlVM: ObservableRecipient
    {
        private List<Persona> personas;

        public List<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        public MostrarPersonasUserControlVM()
        {
            Personas = new List<Persona>();

            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });

            Personas.Add(new Persona("Pietro", 30, "Italiana"));
            Personas.Add(new Persona("Julia", 25, "Española"));
            Personas.Add(new Persona("Sophie", 35, "Francesa"));
        }
    }
}
