using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para MostrarPersonasUserControl.xaml
    /// </summary>
    public partial class MostrarPersonasUserControl : UserControl
    {
        private MostrarPersonasUserControlVM vm;
        public MostrarPersonasUserControl()
        {
            InitializeComponent();
            vm = new MostrarPersonasUserControlVM();
            this.DataContext = vm;
        }
    }
}
