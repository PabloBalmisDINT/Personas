using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona persona):base(persona) { }
    }

    public class NuevaNacionalidadMessage: ValueChangedMessage<string>
    {
        public NuevaNacionalidadMessage(string nacionalidad) : base(nacionalidad) { }
    }
}
