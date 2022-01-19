using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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
    class NuevaPersonaUserControlVM: ObservableRecipient
    {
        //Propiedades
        private Persona personaFormulario;

        public Persona PersonaFormulario
        {
            get { return personaFormulario; }
            set { SetProperty(ref personaFormulario, value); }
        }


        private ObservableCollection<String> nacionalidades;

        public ObservableCollection<String> Nacionalidades
        {
            get { return nacionalidades; }
            set { SetProperty(ref nacionalidades, value); }
        }



        //Comandos
        public RelayCommand NuevaNacionalidadCommand { get; }

        public RelayCommand NuevaPersonaCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            PersonaFormulario = new Persona();
            NuevaNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
            NuevaPersonaCommand = new RelayCommand(NuevaPersona);
            Nacionalidades = new ObservableCollection<string>();

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
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(PersonaFormulario));
        }
    }
}
