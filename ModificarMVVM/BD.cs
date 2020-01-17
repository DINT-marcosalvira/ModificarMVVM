using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class BD
    {
        private BDMarcosEntities contexto;
        
        public BD()
        {
            contexto = new BDMarcosEntities();
            contexto.CLIENTES.Load();
        }


        public ObservableCollection<CLIENTE> GetClientes()
        {
            return contexto.CLIENTES.Local;
        }

        public void GuardarModificacion()
        {
            contexto.SaveChanges();
        }
    }
}
