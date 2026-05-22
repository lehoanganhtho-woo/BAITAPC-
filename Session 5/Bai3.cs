using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai3
    {
        static void Main()
        {
            int n1 = 45, n2 = 89, n3 = 23;

            // Gọi hàm tìm số lớn nhất
            int soLonNhat = TimMax(n1, n2, n3);

            Console.WriteLine("--- BAI 3 ---");
            Console.WriteLine($"So lon nhat trong 3 so ({n1}, {n2}, {n3}) la: {soLonNhat}");
        }

        // Hàm tìm số lớn nhất sử dụng Math.Max
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c); // So sánh ngắn gọn
        }
    }
}
