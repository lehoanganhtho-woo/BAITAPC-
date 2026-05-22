using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part2
{
    internal class Bai2
    {
        static void Main()
        {
            Console.WriteLine("CHUONG TRINH LINEAR SEARCH");

            // 1. Yêu cầu người dùng nhập vào một câu (chuỗi)
            Console.Write("Nhap vao mot cau: ");
            string cau = Console.ReadLine();

            // 2. Yêu cầu người dùng nhập vào từ cần tìm
            Console.Write("Nhap vao tu can tim kiem: ");
            string tuCanTim = Console.ReadLine();

            // 3. Tách câu thành mảng các từ dựa vào khoảng trắng
            // Ví dụ: "Hoc C Sharp" -> ["Hoc", "C", "Sharp"]
            string[] cacTu = cau.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // 4. Gọi hàm tìm kiếm tuyến tính
            int viTriIndex = LinearSearch(cacTu, tuCanTim);

            // 5. In kết quả ra màn hình
            if (viTriIndex != -1)
            {
                Console.WriteLine($"\nKet qua: Tim thay tu '{tuCanTim}' xuat hien tai vi tri index thu {viTriIndex} trong cau.");
            }
            else
            {
                Console.WriteLine($"\nKet qua: Khong tim thay tu '{tuCanTim}' trong cau vừa nhập.");
            }
        }

        // LINEAR SEARCH
        static int LinearSearch(string[] arr, string value)
        {
            // Duyệt tuần tự từng phần tử từ đầu đến cuối mảng
            for (int i = 0; i < arr.Length; i++)
            {
                // So sánh (không phân biệt chữ hoa chữ thường nhờ OrdinalIgnoreCase)
                if (string.Equals(arr[i], value, StringComparison.OrdinalIgnoreCase))
                {
                    return i; // Trả về vị trí index ngay khi tìm thấy khớp
                }
            }
            return -1; // Duyệt hết mảng mà không có thì trả về -1
        }
    }
}
