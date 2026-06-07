using System;

public class Class1
{
	public Class1()
	{
        // 5. Tạo một file và ghi một mảng các chuỗi (mỗi chuỗi nằm trên một dòng)
        static void Bai5_GhiMangChuoiVaoFile(string path)
        {
            string[] danhSachDong = { "Dòng số một", "Dòng số hai", "Dòng số ba" };

            // WriteAllLines sẽ tự động xuống dòng sau mỗi phần tử trong mảng
            File.WriteAllLines(path, danhSachDong);
            Console.WriteLine("[Bài 5] Đã ghi một mảng các dòng chữ vào file!");
        }
    }
}
