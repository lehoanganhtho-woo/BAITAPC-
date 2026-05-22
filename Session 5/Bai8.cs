using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai8
    {
        static void Main()
        {
            string vanBan = "Hello World";

            // Gọi hàm đếm số nguyên âm
            int soLuong = DemNguyenAm(vanBan);

            Console.WriteLine("BAI 8");
            Console.WriteLine($"Input: \"{vanBan}\" -> Output: {soLuong}"); // Kỳ vọng: 3
        }

        // Hàm đếm số lượng nguyên âm trong chuỗi
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            // Chuyển toàn bộ chuỗi sang chữ thường để không bị sót chữ in hoa
            string chuoiChuThuong = s.ToLower();

            for (int i = 0; i < chuoiChuThuong.Length; i++)
            {
                char kyTu = chuoiChuThuong[i];

                // Kiểm tra ký tự có thuộc nhóm nguyên âm không
                if (kyTu == 'a' || kyTu == 'e' || kyTu == 'i' || kyTu == 'o' || kyTu == 'u')
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
