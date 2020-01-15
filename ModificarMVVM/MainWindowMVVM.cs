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


        public MainWindowMVVM()
        {
            contexto = new BDMarcosEntities();
            contexto.CLIENTES.Load();
        }

        public void Modificar()
        {
            contexto.SaveChanges();
        }

        public ObservableCollection<CLIENTE> getClientes()
        {
            return contexto.CLIENTES.Local;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
