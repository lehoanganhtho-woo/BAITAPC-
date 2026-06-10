using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_1
{
    internal class Bai1
    {
        static void Main()
        {
            // Viết chương trình nhập vào một ký tự và cho ký tự di chuyển theo hình chữ nhật trên màn hình

            // BƯỚC 1: NHẬP DỮ LIỆU
            
            Console.Write("Nhap ky tu: ");
            char kyTu = Console.ReadKey().KeyChar;  // đọc 1 ký tự ngay lập tức
            Console.WriteLine();

            Console.Write("Nhap toc do (delay ms): ");
            int delay = int.Parse(Console.ReadLine());

            Console.Clear(); // xóa màn hình trước khi chạy animation

            // ============================================================
            // BƯỚC 2: ĐỊNH NGHĨA HÌNH CHỮ NHẬT
            // Chọn kích thước cố định, cách mép màn hình
            // ============================================================
            int x1 = 2, y1 = 2;   // góc trên trái
            int x2 = 40, y2 = 15;  // góc dưới phải

            // Vị trí ban đầu: góc trên trái
            int x = x1, y = y1;

            // Hướng di chuyển: 0=phải, 1=xuống, 2=trái, 3=lên
            int huong = 0;

            Console.WriteLine("Nhan phim bat ky de dung...");

            // ============================================================
            // BƯỚC 3: VÒNG LẶP VÔ TẬN — chạy đến khi nhấn phím
            // ============================================================
            while (true)
            {
                // --- Kiểm tra nhấn phím để thoát ---
                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true); // đọc phím nhưng không hiện lên màn hình
                    break;
                }

                // --- Xóa vị trí cũ ---
                Console.SetCursorPosition(x, y);
                Console.Write(" ");

                // --- Cập nhật tọa độ theo hướng hiện tại ---
                switch (huong)
                {
                    case 0: x++; break;  // sang phải
                    case 1: y++; break;  // xuống dưới
                    case 2: x--; break;  // sang trái
                    case 3: y--; break;  // lên trên
                }

                // --- Kiểm tra đến góc chưa → đổi hướng ---
                //     Mỗi góc là điểm chuyển hướng
                if (huong == 0 && x >= x2) { x = x2; huong = 1; } // đến góc phải → xuống
                if (huong == 1 && y >= y2) { y = y2; huong = 2; } // đến góc dưới → trái
                if (huong == 2 && x <= x1) { x = x1; huong = 3; } // đến góc trái → lên
                if (huong == 3 && y <= y1) { y = y1; huong = 0; } // đến góc trên → phải

                // --- Vẽ ký tự ở vị trí mới ---
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Cyan; // tô màu cho đẹp (tuỳ chọn)
                Console.Write(kyTu);
                Console.ResetColor();

                // --- Delay để điều khiển tốc độ ---
                Thread.Sleep(delay);
            }

            // ============================================================
            // BƯỚC 4: KẾT THÚC
            // ============================================================
            Console.SetCursorPosition(0, y2 + 2);
            Console.WriteLine("Da dung chuong trinh!");
        }
    }
}
}
