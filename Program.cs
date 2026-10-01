using System;
using System.Collections.Generic;

namespace QuanLyPhuongTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding =
                System.Text.Encoding.UTF8;

            QuanLyPhuongTien ql =
                new QuanLyPhuongTien();

            // ==============================
            // TẠO Ô TÔ
            // ==============================

            OTo oto = new OTo(
                "OT001",
                "Toyota",
                2024,
                1000000000m,
                5,
                2.0
            );

            // ==============================
            // TẠO XE MÁY
            // ==============================

            XeMay xeMay = new XeMay(
                "XM001",
                "Honda",
                2024,
                50000000m,
                150
            );

            // Thêm vào danh sách
            ql.AddPhuongTien(oto);
            ql.AddPhuongTien(xeMay);

            // ==============================
            // HIỂN THỊ DANH SÁCH
            // ==============================

            Console.WriteLine(
                "===== DANH SÁCH PHƯƠNG TIỆN =====");

            ql.DisplayAll();

            // ==============================
            // TC01 - NĂM SẢN XUẤT
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TC01: TEST NĂM SẢN XUẤT =====");

            try
            {
                OTo otoSai = new OTo(
                    "OT002",
                    "Ford",
                    1850,
                    800000000m,
                    5,
                    1.5
                );
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // ==============================
            // TC02 - GIÁ LĂN BÁNH Ô TÔ
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TC02: GIÁ LĂN BÁNH Ô TÔ =====");

            Console.WriteLine(
                oto.TinhGiaLanBanh().ToString("N0")
                + " VNĐ");

            // ==============================
            // TC03 - GIÁ LĂN BÁNH XE MÁY
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TC03: GIÁ LĂN BÁNH XE MÁY =====");

            Console.WriteLine(
                xeMay.TinhGiaLanBanh().ToString("N0")
                + " VNĐ");

            // ==============================
            // TC04 - ĐA HÌNH
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TC04: KIỂM TRA ĐA HÌNH =====");

            List<PhuongTien> dsTest =
                new List<PhuongTien>();

            dsTest.Add(oto);
            dsTest.Add(xeMay);

            foreach (PhuongTien pt in dsTest)
            {
                Console.WriteLine(
                    pt.TenHang
                    + ": "
                    + pt.TinhGiaLanBanh().ToString("N0")
                    + " VNĐ");
            }

            // ==============================
            // TC05 - TÌM GIÁ LĂN BÁNH MAX
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TC05: GIÁ LĂN BÁNH CAO NHẤT =====");

            PhuongTien max =
                ql.FindMaxGiaLanBanh();

            if (max != null)
            {
                Console.WriteLine(max.GetInfo());

                Console.WriteLine(
                    "Giá lăn bánh: "
                    + max.TinhGiaLanBanh().ToString("N0")
                    + " VNĐ");
            }

            // ==============================
            // TÌM KIẾM THEO TÊN HÃNG
            // ==============================

            Console.WriteLine();
            Console.WriteLine(
                "===== TÌM KIẾM THEO HÃNG =====");

            List<PhuongTien> ketQua =
                ql.SearchByName("Toyota");

            foreach (PhuongTien pt in ketQua)
            {
                Console.WriteLine(pt.GetInfo());
            }

            Console.ReadKey();
        }
    }
}