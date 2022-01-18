using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NacionalidadWindowVM: ObservableRecipient
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public RelayCommand NuevaNacionalidadCommand { get; }

        public NacionalidadWindowVM()
        {
            NuevaNacionalidadCommand = new RelayCommand(CrearNuevaNacionalidad);
        }

        public void CrearNuevaNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadMessage(Nacionalidad));
        }
    }
}
