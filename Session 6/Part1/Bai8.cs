using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_6.Part1
{
    internal class Bai8
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Mang truoc khi xoa trung: " + string.Join(", ", numbers));

            // Gọi hàm lọc trùng
            int[] mangDocNhat = XoaTrungLap(numbers);

            Console.WriteLine("Mang sau khi xoa trung: " + string.Join(", ", mangDocNhat));
        }

        // 8: To remove duplicate elements from an array
        static int[] XoaTrungLap(int[] arr)
        {
            // Tạo mảng tạm có cùng kích thước tối đa bằng mảng gốc
            int[] tam = new int[arr.Length];
            int soLuongDocNhat = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool daTonTai = false;

                // Kiểm tra xem số arr[i] đã có trong mảng 'tam' chưa
                for (int j = 0; j < soLuongDocNhat; j++)
                {
                    if (arr[i] == tam[j])
                    {
                        daTonTai = true;
                        break; // Nếu có rồi thì dừng kiểm tra
                    }
                }

                // Nếu số này hoàn toàn mới (chưa tồn tại trong mảng tạm)
                if (!daTonTai)
                {
                    tam[soLuongDocNhat] = arr[i];
                    soLuongDocNhat++;
                }
            }

            // Thu gọn mảng 'tam' về đúng kích thước 'soLuongDocNhat'
            int[] ketQua = new int[soLuongDocNhat];
            for (int i = 0; i < soLuongDocNhat; i++)
            {
                ketQua[i] = tam[i];
            }

            return ketQua;
        }
    }
}
