using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai6
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Mang ban dau: " + string.Join(", ", numbers));

            // Gọi hàm đảo ngược mảng (thay đổi trực tiếp trên mảng gốc)
            DaoNguocMang(numbers);

            Console.WriteLine("Mang sau khi dao nguoc: " + string.Join(", ", numbers));
        }

        // 6: Reverse an array of integer values
        static void DaoNguocMang(int[] arr)
        {
            int dau = 0;
            int cuoi = arr.Length - 1;

            // Vòng lặp chạy từ 2 đầu dồn vào giữa
            while (dau < cuoi)
            {
                // Kỹ thuật Hoán vị 
                int tam = arr[dau];
                arr[dau] = arr[cuoi];
                arr[cuoi] = tam;

                // Tịnh tiến các biến chỉ mục xích lại gần nhau
                dau++;
                cuoi--;
            }
        }
    }
}
