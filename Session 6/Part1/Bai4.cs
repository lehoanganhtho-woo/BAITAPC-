using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai4
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 30, 50 };
            int soCanXoa = 30;

            Console.WriteLine("Mang ban dau: " + string.Join(", ", numbers));

            // Gọi hàm xóa phần tử
            int[] mangMoi = XoaPhanTu(numbers, soCanXoa);

            Console.WriteLine($"Mang sau khi xoa so {soCanXoa}: " + string.Join(", ", mangMoi));
        }

        // HÀM BÀI 4: Remove a specific element from an array
        static int[] XoaPhanTu(int[] arr, int value)
        {
            // Bước 1: Đếm xem có bao nhiêu phần tử KHÔNG BẰNG số cần xóa
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value) dem++;
            }

            // Bước 2: Tạo một mảng mới với kích thước vừa đủ
            int[] ketQua = new int[dem];
            int indexMoi = 0;

            // Bước 3: Ném các phần tử giữ lại vào mảng mới
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != value)
                {
                    ketQua[indexMoi] = arr[i];
                    indexMoi++;
                }
            }

            return ketQua;
        }
        }
}
