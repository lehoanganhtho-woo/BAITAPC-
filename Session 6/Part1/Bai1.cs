using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai1
    {
        static void Main()
        {
            // 1.to calculate the average value of array elements.

            int[] numbers = new int[10];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Mang ngau nhien: " + string.Join(", ", numbers));

            // Gọi hàm TinhTrungBinh
            double ketQua = TinhTrungBinh(numbers);
            Console.WriteLine($"Gia tri trung binh: {ketQua:F1}");
        } 
        static double TinhTrungBinh(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int tong = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }

            return (double)tong / arr.Length;
        } 

    }
}
