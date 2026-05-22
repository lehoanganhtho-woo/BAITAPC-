using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai10
    {
        static void Main()
        {
            // Mảng mẫu theo đúng tài liệu
            int[] numbers = { 4, 5, 6, 7 };

            // Gọi hàm tính trung bình cộng
            double ketQua = TinhTrungBinh(numbers);

            Console.WriteLine("--- BAI 10 ---");
            Console.WriteLine($"Input: [{string.Join(", ", numbers)}] -> Output: {ketQua}");
        }

        // HÀM BÀI 10: Tính giá trị trung bình của mảng số nguyên
        static double TinhTrungBinh(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }

            // Ép kiểu 'tong' sang double để phép chia trả về số thập phân chính xác
            return (double)tong / arr.Length;
        }
    }
}
