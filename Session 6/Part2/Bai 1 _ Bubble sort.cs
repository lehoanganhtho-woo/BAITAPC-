using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part2
{
    internal class Bai1
    {
        static void Main()
        {
            int[] numbers = new int[10];

            // 1. Yêu cầu người dùng nhập 10 số nguyên
            Console.WriteLine("CHUONG TRINH BUBBLE SORT");
            Console.WriteLine("Vui long nhap vao 10 so nguyen:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // In mảng ban đầu ra màn hình
            Console.WriteLine("\nMang ban dau: " + string.Join(", ", numbers));

            // 2. Gọi hàm sắp xếp nổi bọt
            BubbleSort(numbers);

            // In mảng sau khi đã sắp xếp xong
            Console.WriteLine("Mang sau khi sap xep (Tang dan): " + string.Join(", ", numbers));
        }

        // HÀM SẮP XẾP BUBBLE SORT
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            // Vòng lặp bên ngoài quản lý số lần quét mảng
            for (int i = 0; i < n - 1; i++)
            {
                // Vòng lặp bên trong so sánh các phần tử cạnh nhau
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Nếu số trước lớn hơn số sau thì hoán đổi vị trí
                    if (arr[j] > arr[j + 1])
                    {
                        int tam = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tam;
                    }
                }
            }
        }
    }
}
