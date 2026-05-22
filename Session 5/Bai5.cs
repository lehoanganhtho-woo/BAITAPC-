using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai5
    {
        static void Main()
        {
            string chuoiBanDau = "hello";

            // Gọi hàm đảo ngược chuỗi
            string chuoiDaoNguoc = DaoNguocChuoi(chuoiBanDau);

            Console.WriteLine("BAI 5");
            Console.WriteLine($"Chuoi ban dau: {chuoiBanDau}");
            Console.WriteLine($"Chuoi dao nguoc: {chuoiDaoNguoc}");
        }

        // Hàm đảo ngược chuỗi ký tự
        static string DaoNguocChuoi(string input)
        {
            // Chuyển chuỗi thành mảng ký tự
            char[] charArray = input.ToCharArray();

            // Đảo ngược các phần tử trong mảng ký tự
            Array.Reverse(charArray);

            // Tạo và trả về chuỗi mới từ mảng ký tự đã đảo
            return new string(charArray);
        }
    }
}
