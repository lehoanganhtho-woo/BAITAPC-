using System;

public class Class1
{
	public Class1()
	{
        using System;

class Program
    {
        static void Main()
        {
            Console.Write("Nhap ho ten khach hang: ");
            string hoten = Console.ReadLine();

            // Quy định: không âm
            int cu;
            do
            {
                Console.Write("Nhap chi so nuoc cu: ");
                cu = int.Parse(Console.ReadLine());

                if (cu < 0)
                    Console.WriteLine("Sai! Khong nhap so am. Nhap lai.");

            } while (cu < 0);
            //           ↑ Lặp lại khi điều kiện SAI (cu âm)


            // BƯỚC 3: NHẬP CHỈ SỐ MỚI — validate 2 điều kiện
            // Quy định: không âm VÀ >= chỉ số cũ

            int moi;
            do
            {
                Console.Write("Nhap chi so nuoc moi: ");
                moi = int.Parse(Console.ReadLine());

                if (moi < 0)
                    Console.WriteLine("Sai! Khong nhap so am. Nhap lai.");
                else if (moi < cu)
                    Console.WriteLine("Sai! Chi so moi phai >= chi so cu. Nhap lai.");

            } while (moi < 0 || moi < cu);
            //                ↑ || = HOẶC: sai một trong hai thì lặp lại

            // ============================================================
            // BƯỚC 4: TÍNH SỐ NƯỚC TIÊU THỤ
            // ============================================================
            int m3 = moi - cu;

            // ============================================================
            // BƯỚC 5: TÍNH TIỀN NƯỚC THEO LŨY TIẾN TỪNG BẬC
            // Dùng double vì kết quả có thể rất lớn
            // ============================================================
            double tienNuoc = 0;

            if (m3 <= 50)
            {
                // Chỉ rơi vào bậc 1
                tienNuoc = m3 * 8000;
            }
            else if (m3 <= 100)
            {
                // Bậc 1: toàn bộ 50m³ đầu
                // Bậc 2: phần còn lại (m3 - 50)
                tienNuoc = 50 * 8000 + (m3 - 50) * 10000;
            }
            else
            {
                // Bậc 1: 50m³ đầu
                // Bậc 2: 50m³ tiếp theo (từ 51→100)
                // Bậc 3: phần vượt quá 100m³
                tienNuoc = 50 * 8000 + 50 * 10000 + (m3 - 100) * 12000;
            }

            // ============================================================
            // BƯỚC 6: TÍNH PHỤ PHÍ VÀ VAT
            // ============================================================
            double phuPhi = tienNuoc * 0.05;              // 5% tiền nước
            double vat = (tienNuoc + phuPhi) * 0.10;   // 10% (tiền nước + phụ phí)
            double tong = tienNuoc + phuPhi + vat;

            // ============================================================
            // BƯỚC 7: IN KẾT QUẢ THEO MẪU
            // String.Format("{0:N0}") → định dạng số có dấu phẩy, không thập phân
            // ============================================================
            Console.WriteLine(new string('*', 48));
            Console.WriteLine($"Khach hang: {hoten}");
            Console.WriteLine($"Chi so cu:  {cu}");
            Console.WriteLine($"Chi so moi: {moi}");
            Console.WriteLine($"So nuoc:    {m3} m3");
            Console.WriteLine($"Tien nuoc:  {tienNuoc:N0}");
            Console.WriteLine($"Phu phi:    {phuPhi:N0}");
            Console.WriteLine($"VAT:        {vat:N0}");
            Console.WriteLine($"=> Tong tien: {tong:N0}");
            Console.WriteLine(new string('*', 48));
        }
    }
}
}
