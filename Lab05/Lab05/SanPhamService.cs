using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class SanPhamService
    {
        private List<SanPham> sanPhams;

        public SanPhamService()
        {
            sanPhams = new List<SanPham>();
        }

        public void AddSanPham(SanPham sanPham)
        {
            if(string.IsNullOrEmpty(sanPham.tenSanPham))
            {
                throw new ArgumentNullException();
            }
            if (sanPham.gia == 0)
            {
                throw new ArgumentException("Giá tiền không được bằng 0.");
            }

            if (sanPham.gia < 1000)
            {
                throw new ArgumentOutOfRangeException("Giá tiền phải lớn hơn 1000.");
            }

            if (sanPham.gia > 1000000000)
            {
                throw new ArgumentOutOfRangeException("Giá tiền phải nhỏ hơn 1 tỷ.");
            }

            if (sanPham.soLuong < 0)
            {
                throw new ArgumentOutOfRangeException("Số lượng không được nhỏ hơn 0.");
            }

            if (sanPham.soLuong > 100)
            {
                throw new ArgumentOutOfRangeException("Số lượng không được lớn hơn 100.");
            }

            sanPhams.Add(sanPham);
        }

        public bool DeleteSanPham(string masp)
        {
            var d = sanPhams.Find(x => x.maSanPham == masp);
            if (d != null)
            {
                sanPhams.Remove(d);
                return true;
            }
            else
            {
                throw new Exception();
                return false;
            }
        }

        public void UpdateSanPham(string id, SanPham updatedSanPham)
        {
            var existingSanPham = sanPhams.FirstOrDefault(sp => sp.id == id);
            if (existingSanPham != null)
            {
                if(string.IsNullOrEmpty(updatedSanPham.maSanPham))
                {
                    throw new ArgumentNullException();
                }
                if(string.IsNullOrEmpty(updatedSanPham.tenSanPham))
                {
                    throw new ArgumentNullException();
                }
                if (sanPhams.Any(sp => sp.id == updatedSanPham.id && sp.id != id))
                {
                    throw new ArgumentException("ID cập nhật đã tồn tại trong danh sách sản phẩm.");
                }

                if (!updatedSanPham.maSanPham.Contains("SP"))
                {
                    throw new ArgumentException("Mã sản phẩm phải chứa chữ 'SP'.");
                }

                if (updatedSanPham.gia == 0)
                {
                    throw new ArgumentException();
                }

                if (updatedSanPham.gia < 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (updatedSanPham.gia > 1000000000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (updatedSanPham.soLuong < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (updatedSanPham.soLuong > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                existingSanPham.maSanPham = updatedSanPham.maSanPham;
                existingSanPham.tenSanPham = updatedSanPham.tenSanPham;
                existingSanPham.gia = updatedSanPham.gia;
                existingSanPham.mauSac = updatedSanPham.mauSac;
                existingSanPham.kichThuoc = updatedSanPham.kichThuoc;
                existingSanPham.soLuong = updatedSanPham.soLuong;
            }
        }

        public SanPham GetSanPhamById(string id)
        {
            return sanPhams.FirstOrDefault(sp => sp.id == id);
        }

        public List<SanPham> GetAllSanPhams()
        {
            return sanPhams;
        }
    }
}
