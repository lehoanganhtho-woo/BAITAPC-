using System;

public class Class1
{
	public Class1()
	{
        static void Bai2_XoaFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("[Bài 2] Đã xóa file thành công!");
            }
        }
    }
}
