using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUWP.Models
{
    public class ItemTreeView
    { 
        public string Name { get; set; }

        public bool IsExpanded { get; set; }
        public ObservableCollection<ItemTreeView> Children { get; set; } = new ObservableCollection<ItemTreeView>();

        public override string ToString()
        {
            return Name;
        }
    }
}
