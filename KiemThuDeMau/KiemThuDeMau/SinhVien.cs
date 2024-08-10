using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuDeMau
{
    public class SinhVien
    {
        public SinhVien(string masv, string ten, int tuoi, float diemTrungBinh, int kyHoc, string chuyenNghanh)
        {
            Masv = masv;
            Ten = ten;
            Tuoi = tuoi;
            this.diemTrungBinh = diemTrungBinh;
            KyHoc = kyHoc;
            ChuyenNghanh = chuyenNghanh;
        }

        public SinhVien()
        {

        }

        public string Masv { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public float diemTrungBinh { get; set; }
        public int KyHoc { get; set; }
        public string ChuyenNghanh { get;set; }
    }
}
