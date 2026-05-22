using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai7
    {
        static void Main()
        {
            // Mảng mẫu có chứa các phần tử trùng nhau (số 2, số 5)
            int[] numbers = { 2, 5, 8, 2, 9, 5, 2 };

            Console.WriteLine("Mang ban dau: " + string.Join(", ", numbers));
            Console.WriteLine("7. Cac gia tri trung lap trong mang la:");

            TimTrungLap(numbers);
        }

        // HÀM BÀI 7: To find duplicate values in an array
        static void TimTrungLap(int[] arr)
        {
            // Tạo mảng đánh dấu để tránh in lặp lại cùng một số đã tìm thấy trùng trước đó
            bool[] daIn = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (daIn[i]) continue; // Nếu số này đã từng được xử lý rồi thì bỏ qua

                bool coTrung = false;

                // Vòng lặp quét tất cả các phần tử đứng phía sau phần tử i
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        coTrung = true;
                        daIn[j] = true; // Đánh dấu phần tử j trùng để lần sau không quét lại nó
                    }
                }

                // Nếu có trùng thì in số đó ra màn hình
                if (coTrung)
                {
                    Console.WriteLine($"- So {arr[i]} bi trung lap");
                }
            }
        }
    }
}
