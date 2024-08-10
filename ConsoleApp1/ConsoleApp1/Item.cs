using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Item(int id , string name)
        {
            this.Id = id;
            this.Name = name;
        }

        private List<Item> items = new List<Item>();

        public void Create(Item item)
        {
            items.Add(item);
        }

        public void Update(int id,string newName)
        {
            var i = items.FirstOrDefault(a => a.Id == id);
            if(i != null)
            {
                i.Name = newName;
            }
        }

        public void Remove(int id)
        {
            items.RemoveAll(o => o.Id == id);
        }
    }
}
