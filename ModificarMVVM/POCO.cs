using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class POCO
    {
        public partial class CLIENTE : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
        }
    }
}
