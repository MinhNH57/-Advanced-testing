using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    public class ItemManage
    {
        public List<Item> items = new List<Item>();

        public void Create(Item item)
        {
            if (item.Name == null)
            {
                throw new ArgumentNullException(nameof(item.Name), "Name cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(item.Name))
            {
                throw new ArgumentNullException(nameof(item.Name), "Name cannot be null or empty.");
            }
            if(int.TryParse(item.Name , out int i))
            {
                throw new ArgumentException("Du lieu khong hop le");
            }
            if (item.Name.Length > 50 || item.Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(item.Name), "Số lượng ký tự không hợp lệ");
            }
            items.Add(item);
        }

        public void Update(int id, string newName)
        {
            if (newName == null)
            {
                throw new ArgumentNullException(nameof(newName));
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("Name cannot be null or empty.", nameof(newName));
            }

            if (newName.Length > 50 || newName.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(newName), "Name length must be between 2 and 50 characters.");
            }

            var itemToUpdate = items.FirstOrDefault(a => a.Id == id);
            if (itemToUpdate == null)
            {
                throw new KeyNotFoundException($"Item with Id {id} not found.");
            }

            itemToUpdate.Name = newName;
        }

        public void Remove(int id)
        {
            items.RemoveAll(o => o.Id == id);
        }
    }
}
