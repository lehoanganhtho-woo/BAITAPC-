using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai6
    {
        static void Main()
        {
            int n1 = 7;
            int n2 = 10;

            Console.WriteLine("BAI 6");
            Console.WriteLine($"Input: {n1} -> Output: {KiemTraNguyenTo(n1)}"); // Kỳ vọng: True
            Console.WriteLine($"Input: {n2} -> Output: {KiemTraNguyenTo(n2)}"); // Kỳ vọng: False
        }

        // Hàm kiểm tra số nguyên tố
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false; // Số nhỏ hơn 2 không phải số nguyên tố

            // Chạy vòng lặp từ 2 đến căn bậc hai của n
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false; // Nếu chia hết cho số bất kỳ thì không phải số nguyên tố
                }
            }
            return true; // Nếu không chia hết cho số nào thì là số nguyên tố
        }
    }
}
