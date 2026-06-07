using System;

public class Class1
{
	public Class1()
	{
        static void Bai3_TaoFileVaGhiChuoi(string path, string noiDung)
        {
            File.WriteAllText(path, noiDung);
            Console.WriteLine("[Bài 3] Đã ghi nội dung văn bản vào file!");
        }
    }
}
