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

namespace ModificarMVVM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowMVVM mv = new MainWindowMVVM();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mv.getClientes();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mv.Modificar();
        }
    }
}
