using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class MainWindowMVVM : INotifyPropertyChanged
    {
        private BDMarcosEntities contexto;
        private ObservableCollection<CLIENTE> Clients { get; set; }
        private CLIENTE ClientsModifyComboBoxSelectedItem { get; set; }

        public void MainWindowMVVMVoid()
        {
            contexto = new BDMarcosEntities();
            contexto.CLIENTES.Load();
            Clients = contexto.CLIENTES.Local;
        }

        public void Modificar()
        {
            contexto.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
