using AppUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUWP.Interfaces
{
    public interface IRepository
    {
        List<ItemTreeView> GetDataTreeView();
    }
}
