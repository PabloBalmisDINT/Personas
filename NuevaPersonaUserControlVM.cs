using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NuevaPersonaUserControlVM: ObservableObject
    {
        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            NuevaNacionalidadCommand = new RelayCommand(NuevaNacionalidad);
        }

        public void NuevaNacionalidad()
        {
            new NacionalidadWindow().ShowDialog();
        }
    }
}
