using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuDeMau
{
    public class SinhVienService
    {
        public List<SinhVien> sinhViens = new List<SinhVien>();

        public void CreateSinhVien(SinhVien sv)
        {
            if (sv.Masv == null || sv.Ten == null || sv.Tuoi == null||sv.ChuyenNghanh == null)
            {
                throw new ArgumentNullException();
            }

            sv = new SinhVien()
            {
                Masv = sv.Masv,
                Ten = sv.Ten,
                Tuoi = sv.Tuoi,
                ChuyenNghanh = sv.ChuyenNghanh,
                KyHoc = sv.KyHoc,
                diemTrungBinh = sv.diemTrungBinh
            };

            sinhViens.Add(sv);
        }

        public void DeleteSinhVien(string masv)
        { 
            var s = sinhViens.Find(x => x.Masv == masv);
            if (s == null)
            {
                throw new ArgumentException();
            }

            sinhViens.Remove(s);
        }

        public void UpdateSinhVien(string masv , SinhVien sv)
        {
            if(sv.Masv != masv)
            {
                throw new ArgumentException("Mã sinh viên không khớp.");
            }

            if(sv.Ten.Length < 2)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(sv.Tuoi > 100)
            {
                throw new ArgumentException();
            }

            if(sv.Tuoi < 10)
            {
                throw new ArgumentException();
            }
            var s = sinhViens.Find(x => x.Masv == masv);
            s.Ten = sv.Ten;
            s.ChuyenNghanh = sv.ChuyenNghanh;
            s.Tuoi = sv.Tuoi;

        }
    }
}
