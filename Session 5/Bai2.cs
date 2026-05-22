using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai2
    {
        static void Main()
        {
            int soCanKiemTra = 8;

            // Gọi hàm và nhận kết quả true/false
            bool laSoChan = KiemTraChan(soCanKiemTra);

            Console.WriteLine("--- BAI 2 ---");
            if (laSoChan)
            {
                Console.WriteLine($"So {soCanKiemTra} la so chan.");
            }
            else
            {
                Console.WriteLine($"So {soCanKiemTra} la so le.");
            }
        }

        // Hàm kiểm tra số chẵn lẻ
        static bool KiemTraChan(int n)
        {
            return n % 2 == 0; // Trả về thẳng biểu thức logic
        }
    }
}
