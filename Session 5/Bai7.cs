using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_5
{
    internal class Bai7
    {
        static void Main()
        {
            int n = 6;

            Console.WriteLine("BAI 7");
            Console.Write($"Input: {n} -> Output: ");

            // Gọi hàm in dãy Fibonacci
            InFibonacci(n);
            Console.WriteLine(); // Xuống dòng khi kết thúc
        }

        // Hàm in ra n số đầu tiên của dãy Fibonacci
        static void InFibonacci(int n)
        {
            if (n <= 0) return;

            int soThuNhat = 0;
            int soThuHai = 1;

            // In số đầu tiên nếu n >= 1
            Console.Write(soThuNhat + " ");

            // In số thứ hai nếu n >= 2
            if (n > 1)
            {
                Console.Write(soThuHai + " ");
            }

            // Tính toán và in các số tiếp theo từ vị trí thứ 3
            for (int i = 3; i <= n; i++)
            {
                int soTiepTheo = soThuNhat + soThuHai;
                Console.Write(soTiepTheo + " ");

                // Cập nhật lại hai số liền trước cho lượt chạy kế tiếp
                soThuNhat = soThuHai;
                soThuHai = soTiepTheo;
            }
        }
    }
}
