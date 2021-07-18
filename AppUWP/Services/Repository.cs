using AppUWP.Interfaces;
using AppUWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUWP.Services
{
    public class Repository : IRepository
    {
        public List<ItemTreeView> GetDataTreeView()
        {
            var list = new List<ItemTreeView>();

            ItemTreeView mammalsCategory = new ItemTreeView()
            {
                Name = "Mammals",
                Children =
                {
                    new ItemTreeView()
                    {
                        Name = "Cat",
                        Children =
                        {
                            new ItemTreeView() { Name = "Persa" },
                            new ItemTreeView() { Name = "Maine Coon" },
                            new ItemTreeView() { Name = "Bengala" }
                        }
                    },
                    new ItemTreeView()
                    {
                        Name = "Dog",
                        Children =
                        {
                            new ItemTreeView() { Name = "Bulldog" },
                            new ItemTreeView() { Name = "Doberman" },
                            new ItemTreeView() { Name = "Pug" }
                        }
                    },
                }
            };

            ItemTreeView birdsCategory = new ItemTreeView()
            {
                Name = "Birds",
                Children =
                {
                    new ItemTreeView()
                    {
                        Name = "Dove",
                        Children =
                        {
                            new ItemTreeView() { Name = "Jacobina" },
                            new ItemTreeView() { Name = "Cumulet" },
                            new ItemTreeView() { Name = "Lahore Pigeon" }
                        }
                    },
                    new ItemTreeView()
                    {
                        Name = "Duck",
                        Children =
                        {
                            new ItemTreeView() { Name = "Anade real" },
                            new ItemTreeView() { Name = "Alabio duck" },
                            new ItemTreeView() { Name = "Domestic" }
                        }
                    }
                }
            };

            ItemTreeView fishesCategory = new ItemTreeView()
            {
                Name = "Fishes",
                Children =
                     {
                         new ItemTreeView()
                         {
                             Name = "Shark",
                             Children =
                             {
                                 new ItemTreeView() { Name = "Pilgrim" },
                                 new ItemTreeView() { Name = "Stained carpet" },
                                 new ItemTreeView() { Name = "Big Blue" }
                             }
                         },
                         new ItemTreeView()
                         {
                             Name = "Tuna",
                             Children =
                             {
                                 new ItemTreeView() { Name = "List" },
                                 new ItemTreeView() { Name = "Rabil" },
                                 new ItemTreeView() { Name = "Patudo" }
                             }
                         }
                     }
            };

            list.Add(mammalsCategory);
            list.Add(birdsCategory);
            list.Add(fishesCategory);
            return list;
        }
    }
}
