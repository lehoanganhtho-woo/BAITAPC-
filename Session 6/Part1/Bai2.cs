using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai2
    {
        static void Main()
        {
            // 1. Tạo mảng ngẫu nhiên
            int[] numbers = new int[10];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Mang ngau nhien: " + string.Join(", ", numbers));

            // 2. Định nghĩa số cần tìm để test
            int soCanTim = 50;

            // 3. Gọi hàm kiểm tra
            bool coTonTai = KiemTraTonTai(numbers, soCanTim);

            // 4. In kết quả
            Console.WriteLine($"Ket qua: So {soCanTim} co trong mang khong? -> {coTonTai}");
        }

        // Hàm KiemTraTonTai nằm ngoài hàm Main, cùng cấp với Main và nằm trong class Bai2
        static bool KiemTraTonTai(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
