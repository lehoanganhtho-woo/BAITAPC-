using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai4
    {
        static void Main()
        {
            int input = 5; // Tính 5! (1 * 2 * 3 * 4 * 5)

            // Gọi hàm tính giai thừa với kết quả trả về kiểu long
            long giaiThua = TinhGiaiThua(input);

            Console.WriteLine("--- BAI 4 ---");
            Console.WriteLine($"Giai thua cua {input}! la: {giaiThua}");
        }

        // Hàm tính giai thừa của một số nguyên dương
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1; // Khởi tạo biến kết quả bằng 1

            // Vòng lặp chạy từ 1 đến n để nhân dồn
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i; // Nhân dồn vào biến kết quả
            }

            return ketQua;
        }
    }
}
