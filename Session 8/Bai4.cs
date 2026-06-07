using System;

public class Class1
{
	public Class1()
	{
        // 4. Đọc toàn bộ nội dung của file văn bản và in ra
        static void Bai4_DocFile(string path)
        {
            if (File.Exists(path))
            {
                string noiDung = File.ReadAllText(path);
                Console.WriteLine($"[Bài 4] Nội dung file đọc được:\n{noiDung}");
            }
        }
    }
}
