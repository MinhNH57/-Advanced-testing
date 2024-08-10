using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Sach
    {
        //id  - String, ten - String, soTrang - int, tenTacGia - String, lanTaiBan - int
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public int Sotrang { get; set; }
        public string? TenTacGia { get; set; }
        public int LanTaiBan { get; set; }

        public Sach()
        {

        }

        public Sach(string id, string? name, int sotrang, string? tenTacGia, int lanTaiBan)
        {
            Id = id;
            Name = name;
            Sotrang = sotrang;
            TenTacGia = tenTacGia;
            LanTaiBan = lanTaiBan;
        }
    }
}
