using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class SanPham
    {
    //    id  - String, maSanPham - String, tenSanPham - String, gia - float, mauSac - String, kichThuoc - String, soLuong - int//
        public string id { get; set; }
        public string maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public float gia { get; set; }
        public string mauSac { get; set; }
        public string kichThuoc { get; set; }
        public int soLuong { get; set; }

        public SanPham()
        {

        }

        public SanPham(string id, string maSanPham, string tenSanPham, float gia, string mauSac, string kichThuoc, int soLuong)
        {
            this.id = id;
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.gia = gia;
            this.mauSac = mauSac;
            this.kichThuoc = kichThuoc;
            this.soLuong = soLuong;
        }
    }
}
