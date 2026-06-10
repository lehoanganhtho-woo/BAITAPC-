using System;

public class Class1
{
	public Class1()
	{
        static void Main()
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ============================================================
            // NHẬP N VÀ MA TRẬN
            // ============================================================
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];

            Console.WriteLine("Nhap ma tran:");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }

            // ============================================================
            // NHẬP K
            // ============================================================
            Console.Write("Nhap so nguyen duong k: ");
            int k = int.Parse(Console.ReadLine());

            // ============================================================
            // DUYỆT MA TRẬN — tìm phần tử thỏa điều kiện
            // Điều kiện: a[i,j] < k  VÀ  a[i,j] % 2 != 0
            // ============================================================
            int dem = 0;
            long tong = 0;
            int min = int.MaxValue; // khởi tạo min = rất lớn

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < k && a[i, j] % 2 != 0)
                    {
                        dem++;
                        tong += a[i, j];

                        if (a[i, j] < min)
                            min = a[i, j]; // cập nhật min
                    }
                }
            }

            // ============================================================
            // IN KẾT QUẢ
            // ============================================================
            Console.WriteLine("\n========== KET QUA ==========");

            if (dem == 0)
            {
                Console.WriteLine("Khong ton tai phan tu thoa dieu kien.");
            }
            else
            {
                double trungBinh = (double)tong / dem;

                Console.WriteLine($"So luong phan tu thoa dk: {dem}");
                Console.WriteLine($"Trung binh cong:          {trungBinh:F2}");
                Console.WriteLine($"Gia tri nho nhat:         {min}");

                // Duyệt lại để in TẤT CẢ vị trí có giá trị = min
                Console.WriteLine("Vi tri cac phan tu nho nhat:");
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        if (a[i, j] == min && a[i, j] < k && a[i, j] % 2 != 0)
                            Console.WriteLine($"  -> Dong {i}, Cot {j}");
            }
        }
    }
}
}
