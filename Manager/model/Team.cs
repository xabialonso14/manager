using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Manager.model
{
    class Team
    {
        public ObservableCollection<Player> Players = new ObservableCollection<Player>();
    }
}
