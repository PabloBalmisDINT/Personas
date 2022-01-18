using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class NuevaPersonaUserControlVM: ObservableRecipient
    {
        //Propiedades
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        private List<String> nacionalidades;

        public List<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }



        //Comandos
        public RelayCommand NuevaNacionalidadCommand { get; }

        public RelayCommand NuevaPersonaCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            NuevaNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
            NuevaPersonaCommand = new RelayCommand(NuevaPersona);
            Nacionalidades = new List<string>();

            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessage>(this, (r, m) =>
            {
                Nacionalidades.Add(m.Value);
            });

            Nacionalidades.Add("Española");
            Nacionalidades.Add("Italiana");
            Nacionalidades.Add("Francesa");
        }

        public void NuevaNacionalidad()
        {
            new NacionalidadWindow().ShowDialog();
        }

        public void NuevaPersona()
        {
            Persona persona = new Persona(Nombre, Edad, Nacionalidad);
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(persona));
        }
    }
}
