using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai9
    {
        static void Main()
        {
            double coSo = 2;
            int soMu = 3;

            // Gọi hàm tính lũy thừa tự viết
            double ketQua = TinhLuyThua(coSo, soMu);

            Console.WriteLine("--- BAI 9 ---");
            Console.WriteLine($"Input: x = {coSo}, y = {soMu} -> Output: {ketQua}");

            // Chạy thử thêm trường hợp số mũ âm để test độ xịn của hàm
            Console.WriteLine($"Test mu am: x = 2, y = -3 -> Output: {TinhLuyThua(2, -3)}");
        }

        // HÀM BÀI 9: Tính lũy thừa x^y không dùng Math.Pow
        static double TinhLuyThua(double x, int y)
        {
            // Trường hợp bất kỳ số nào mũ 0 cũng bằng 1
            if (y == 0) return 1;

            double ketQua = 1;

            // Lấy giá trị tuyệt đối của y để chạy vòng lặp (xử lý được cả mũ âm)
            int soMuTuyetDoi = Math.Abs(y);

            // Vòng lặp nhân dồn x vào kết quả
            for (int i = 1; i <= soMuTuyetDoi; i++)
            {
                ketQua *= x;
            }

            // Nếu số mũ ban đầu là số âm thì lấy nghịch đảo (1 / ketQua)
            if (y < 0)
            {
                return 1 / ketQua;
            }

            return ketQua;
        }
    }
}
