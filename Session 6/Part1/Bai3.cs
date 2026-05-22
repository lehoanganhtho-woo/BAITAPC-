using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai3
    {
        static void Main()
        {
            // 1. Tạo mảng ngẫu nhiên
            int[] numbers = new int[10];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Mang ngau nhien : " + string.Join(", ", numbers));

            // 2. Định nghĩa số cần tìm vị trí
            int soCanTim = 75;

            // 3. Gọi hàm tìm vị trí index
            int viTriIndex = TimViTriIndex(numbers, soCanTim);

            if (viTriIndex != -1)
            {
                Console.WriteLine($"Ket qua: Tim thay so {soCanTim} tai vi tri index: {viTriIndex}");
            }
            else
            {
                Console.WriteLine($"Ket qua: Khong tim thay so {soCanTim} trong mang (Index: {viTriIndex})");
            }
        }

        static int TimViTriIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}
