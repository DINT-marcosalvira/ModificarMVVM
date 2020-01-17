using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class MainWindowMVVM : INotifyPropertyChanged
    {
        
        private ObservableCollection<CLIENTE> Clientes { get; set; }
        private CLIENTE ClientsModifyComboBoxSelectedItem { get; set; }

        private BD baseDatos;

        public MainWindowMVVM()
        {
            baseDatos = new BD();
            Clientes = baseDatos.GetClientes();
        }

        public void Modificar()
        {
            baseDatos.GuardarModificacion();
            ClientsModifyComboBoxSelectedItem = null;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
