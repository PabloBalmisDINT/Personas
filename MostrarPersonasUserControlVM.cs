using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class MostrarPersonasUserControlVM: ObservableRecipient
    {
        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        public MostrarPersonasUserControlVM()
        {
            Personas = new ObservableCollection<Persona>();

            Personas.Add(new Persona("Pietro", 30, "Italiana"));
            Personas.Add(new Persona("Julia", 25, "Española"));
            Personas.Add(new Persona("Sophie", 35, "Francesa"));

            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                Personas.Add(m.Value);
            });
        }
    }
}
