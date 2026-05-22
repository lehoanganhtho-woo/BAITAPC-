using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai5
    {
        static void Main()
        {
            int[] numbers = { 10, 5, 8, 2, 9 };

            Console.WriteLine("Mang: " + string.Join(", ", numbers));

            // Gọi hai hàm tìm Max và Min
            int max = TimMax(numbers);
            int min = TimMin(numbers); 

            Console.WriteLine($"5. Gia tri lon nhat (Max): {max}");
            Console.WriteLine($"5. Gia tri nho nhat (Min): {min}");
        }

        // Hàm tìm giá trị lớn nhất (Max)
        static int TimMax(int[] arr)
        {
            int max = arr[0]; // Giả định phần tử đầu tiên là lớn nhất
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; // Cập nhật lại nếu tìm thấy số lớn hơn
                }
            }
            return max;
        }

        static int TimMin(int[] arr)
        {
            int min = arr[0]; // Giả định phần tử đầu tiên là nhỏ nhất
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i]; // Cập nhật lại nếu tìm thấy số nhỏ hơn
                }
            }
            return min;
        }
    }
}
