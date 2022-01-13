using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM: ObservableObject
    {
        NavigationService servicioNavegacion;

        private UserControl contenidoVista;

        public UserControl ContenidoVista
        {
            get { return contenidoVista; }
            set { SetProperty(ref contenidoVista, value); }
        }

        public RelayCommand NuevaPersonaCommand { get; }

        public RelayCommand MostrarPersonasCommand { get; }

        public MainWindowVM()
        {
            servicioNavegacion = new NavigationService();
            NuevaPersonaCommand = new RelayCommand(CargarVistaNuevaPersona);
            MostrarPersonasCommand = new RelayCommand(CargarVistaMostrarPersonas);
        }

        public void CargarVistaNuevaPersona()
        {
            ContenidoVista = servicioNavegacion.CaragarVistaNuevaPersona();
        }

        public void CargarVistaMostrarPersonas()
        {
            ContenidoVista = servicioNavegacion.CaragarVistaMostrarPersonas();
        }
    }
}
