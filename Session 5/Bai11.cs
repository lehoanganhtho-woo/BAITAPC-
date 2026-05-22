using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai11
    {
        static void Main()
        {
            string s1 = "radar";
            string s2 = "hello";

            Console.WriteLine("--- BAI 11 ---");
            Console.WriteLine($"Input: \"{s1}\" -> Output: {KiemTraDoiXung(s1)}"); // Kỳ vọng: True
            Console.WriteLine($"Input: \"{s2}\" -> Output: {KiemTraDoiXung(s2)}"); // Kỳ vọng: False
        }

        // HÀM BÀI 11: Kiểm tra chuỗi Palindrome
        static bool KiemTraDoiXung(string s)
        {
            int dau = 0;
            int cuoi = s.Length - 1;

            // Chạy từ 2 đầu dồn vào giữa câu
            while (dau < cuoi)
            {
                // Nếu ký tự ở 2 đầu không khớp nhau thì không phải chuỗi đối xứng
                if (s[dau] != s[cuoi])
                {
                    return false;
                }
                dau++;
                cuoi--;
            }
            return true;
        }
    }
}
