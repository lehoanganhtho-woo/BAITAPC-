using System;

public class Class1
{
	public Class1()
	{
        // 6. Ghi nối tiếp một đoạn chữ vào cuối file đang có sẵn (Không làm mất chữ cũ)
        static void Bai6_NoiThemChuoi(string path, string chuoiNoiThem)
        {
            File.AppendAllText(path, chuoiNoiThem);
            Console.WriteLine("[Bài 6] Đã nối thêm chữ vào cuối file thành công!");
        }
    }
}
