using System;
using System.Collections.Generic;
using System.Text;

namespace BAITAPC_.Session_7
{
    internal class Bai1
    {
        // 1. Tạo một file trống rỗng trên ổ đĩa
        static void Bai1_TaoFileTrong(string path)
        {
            File.Create(path).Close();
            Console.WriteLine("[Bài 1] Đã tạo thành công một file trống rỗng!");
        }

    }
}
