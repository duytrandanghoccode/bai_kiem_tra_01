using System;
using System.Collections.Generic;

namespace QuanLyPhuongTien
{
    public class QuanLyPhuongTien
    {
        private List<PhuongTien> danhSach;

        public QuanLyPhuongTien()
        {
            danhSach = new List<PhuongTien>();
        }

        // 1. Thêm phương tiện
        public void AddPhuongTien(PhuongTien pt)
        {
            danhSach.Add(pt);
        }

        // 2. Hiển thị tất cả
        public void DisplayAll()
        {
            foreach (PhuongTien pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());

                Console.WriteLine(
                    "Giá lăn bánh: "
                    + pt.TinhGiaLanBanh().ToString("N0")
                    + " VNĐ");

                Console.WriteLine();
            }
        }

        // 3. Tìm phương tiện có giá lăn bánh cao nhất
        public PhuongTien FindMaxGiaLanBanh()
        {
            if (danhSach.Count == 0)
                return null;

            PhuongTien max = danhSach[0];

            foreach (PhuongTien pt in danhSach)
            {
                if (pt.TinhGiaLanBanh()
                    > max.TinhGiaLanBanh())
                {
                    max = pt;
                }
            }

            return max;
        }

        // 4. Tìm theo tên hãng
        public List<PhuongTien> SearchByName(
            string keyword)
        {
            List<PhuongTien> ketQua
                = new List<PhuongTien>();

            foreach (PhuongTien pt in danhSach)
            {
                if (pt.TenHang.ToLower()
                    .Contains(keyword.ToLower()))
                {
                    ketQua.Add(pt);
                }
            }

            return ketQua;
        }
    }
}