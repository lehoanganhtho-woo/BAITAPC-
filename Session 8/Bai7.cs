using System;

public class Class1
{
	public Class1()
	{
        // 7. Tạo bản sao (Copy) file sang tên khác và hiển thị nội dung file mới đó
        static void Bai7_CopyVaHienThi(string srcPath, string destPath)
        {
            if (File.Exists(srcPath))
            {
                File.Copy(srcPath, destPath, true);
                Console.WriteLine($"[Bài 7] Đã copy từ {srcPath} sang {destPath}.");

                // Đọc và hiển thị file mới copy
                string noiDungFileMoi = File.ReadAllText(destPath);
                Console.WriteLine($"Nội dung file sau khi copy là:\n{noiDungFileMoi}");
            }
        }
    }
}
