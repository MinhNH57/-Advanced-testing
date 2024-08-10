using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab08
{
    public class SachService
    {
        List<Sach> lst = new List<Sach> ();

        public List<Sach> GetAll()
        {
            return lst.ToList();
        }
        public void CreateSach(Sach sach)
        {
            if(sach.Id.Length < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(sach.Id.Length > 10)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(Regex.IsMatch(sach.Name! , @"[~`!@#$%^&*()_\-+={}[\]|\\:;""'<>,.?/]"))
            {
                throw new ArgumentException();
            }
            lst.Add(sach);
        }

        public Sach TimKiemByName(string ten)
        {
            Sach sach = new Sach();

            if(sach.TenTacGia != ten)
            {
                throw new Exception();
            }

            if(ten == null)
            {
                throw new ArgumentNullException();
            }

            var s = lst.Find(x => x.TenTacGia!.ToLower().Contains(ten.ToLower()));
            if(s == null)
            {
                return null!;
            }
            return s;
           
        }
    }
}
