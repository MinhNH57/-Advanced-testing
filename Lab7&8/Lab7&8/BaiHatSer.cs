using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_8
{
    public class BaiHatSer
    {
        public List<BaiHat> bh = new List<BaiHat>();

        public List<BaiHat> GetAll()
        {
            return bh.ToList();
        }

        public void Create(BaiHat item)
        {
            if (item.ten == null)
            {
                throw new ArgumentNullException(nameof(item.ten), "Name cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(item.ten))
            {
                throw new ArgumentNullException(nameof(item.ten), "Name cannot be null or empty.");
            }
            if (item.ten.Length > 50 || item.ten.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(item.ten), "Số lượng ký tự không hợp lệ");
            }

            if(item.doDai < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            bh.Add(item);
        }

        public void Update(string id, string newName)
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

            var itemToUpdate = bh.FirstOrDefault(a => a.ID == id);
            if (itemToUpdate == null)
            {
                throw new KeyNotFoundException($"Item with Id {id} not found.");
            }

            itemToUpdate.ten = newName;
        }

        public void Remove(string id)
        {

            if(string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            if(id.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }


            if (id.Length >20)
            {
                throw new ArgumentOutOfRangeException();
            }
            bh.RemoveAll(o => o.ID == id);
        }
    }
}
