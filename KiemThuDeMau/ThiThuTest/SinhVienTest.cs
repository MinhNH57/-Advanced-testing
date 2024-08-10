using KiemThuDeMau;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThuTest
{
    public class SinhVienTest
    {
        SinhVienService sv1 = new SinhVienService();

        [Test]
        public void ThemSinhVienThanhCong()
        {
            SinhVien sv = new SinhVien()
            {
                Masv = "Mi12",
                Ten = "Nguyen Hong Minh",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };

            sv1.sinhViens.Add(sv);

            CollectionAssert.Contains(sv1.sinhViens, sv);
        }

        [Test]
        public void ThemSinhVienThatBai()
        {
            SinhVien sv = new SinhVien()
            {
                Masv = "Mi12",
                Ten = null,
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };

            Assert.Throws<ArgumentNullException>(() => sv1.CreateSinhVien(sv));
        }

        [Test]
        public void UpdateSinhVien_MaSV_Khong_Khop()
        {
            // Arrange
            var sv = new SinhVien
            {
                Masv = "SV01",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };
            sv1.CreateSinhVien(sv);

            var svUpdate = new SinhVien
            {
                Masv = "SV02", // Mã sinh viên khác
                Ten = "Nguyen Van B",
                Tuoi = 21,
                ChuyenNghanh = "KTMT",
                KyHoc = 6,
                diemTrungBinh = 9.0f
            };

            var ex = Assert.Throws<ArgumentException>(() => sv1.UpdateSinhVien("SV01", svUpdate));
            Assert.That("Mã sinh viên không khớp.", Is.EqualTo(ex.Message));
        }

        [Test]
        public void UpdateSinhVien_ThanhCong()
        {
            // Arrange
            var sv = new SinhVien
            {
                Masv = "SV01",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };
            sv1.CreateSinhVien(sv);

            var svUpdate = new SinhVien
            {
                Masv = "SV01",
                Ten = "Nguyen Van B",
                Tuoi = 21,
                ChuyenNghanh = "KTMT",
                KyHoc = 6,
                diemTrungBinh = 9.0f
            };

            sv1.UpdateSinhVien("SV01", svUpdate);

            // Assert
            var updatedSv = sv1.sinhViens.Find(x => x.Masv == "SV01");
            CollectionAssert.Contains(sv1.sinhViens, updatedSv);
        }

        [Test]
        public void UpdateSinhVien_Ten_Qua_Ngan()
        {
            // Arrange
            var sv = new SinhVien
            {
                Masv = "SV01",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };
           sv1.CreateSinhVien(sv);

            var svUpdate = new SinhVien
            {
                Masv = "SV01",
                Ten = "A", // Tên quá ngắn
            };
            Assert.Throws<ArgumentOutOfRangeException>(() => sv1.UpdateSinhVien("SV01", svUpdate));
        }

        [Test]
        public void UpdateThatBai_TuoiSinhVienQuaCao()
        {
            var sv = new SinhVien
            {
                Masv = "SV01",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };
            sv1.CreateSinhVien(sv);

            var svUpdate = new SinhVien
            {
                Masv = "SV01",
                Ten = "An",
                Tuoi = 102
            };
            Assert.Throws<ArgumentException>(() => sv1.UpdateSinhVien("SV01", svUpdate));
        }

        [Test]
        public void UpdateThatBai_TuoiSinhVienQuaNho()
        {
            var sv = new SinhVien
            {
                Masv = "SV04",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };
            sv1.CreateSinhVien(sv);

            var upSinhV = new SinhVien
            {
                Masv = "SV04",
                Ten = "An",
                Tuoi = 9
            };

            Assert.Throws<ArgumentException>(() => sv1.UpdateSinhVien("SV04", upSinhV));
        }

        [Test]
        public void XoaSinhVienThanhCong()
        {
            var sv = new SinhVien
            {
                Masv = "SV05",
                Ten = "Nguyen Van A",
                Tuoi = 20,
                ChuyenNghanh = "CNTT",
                KyHoc = 5,
                diemTrungBinh = 8.7f
            };

            sv1.CreateSinhVien(sv);

            sv1.DeleteSinhVien("SV05");
            CollectionAssert.DoesNotContain(sv1.sinhViens, sv);
        }

        [Test]
        public void XoaSinhVienThatBai_MaKhongTonTai()
        {
            Assert.Throws<ArgumentException>(() => sv1.DeleteSinhVien("SV11"));
        }

    }
}
