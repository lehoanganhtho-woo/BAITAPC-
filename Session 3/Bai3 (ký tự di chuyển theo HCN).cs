using System;

public class Class1
{
	public Class1()
	{
        static void chayhcn(char kytu, int delay)
        {
            int thongsotrai = 5;
            int thongsotren = 5;
            int chieurong = 20;
            int chieucao = 10;
            int xmin = thongsotrai;
            int xmax = thongsotrai + chieurong;
            int ymin = thongsotren;
            int ymax = thongsotren + chieucao;
            int x = xmin;
            int y = ymin;
            int huongdi = 0;
            Console.WriteLine("Bấm một phím bất kì để dừng chương trình!");
            Console.CursorVisible = false;
            while (Console.KeyAvailable == false)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                if (huongdi == 0)
                {
                    x++;
                    if (x >= xmax)
                    {
                        huongdi = 1;
                    }
                }
                else if (huongdi == 1)
                {
                    y++;
                    if (y >= ymax)
                        huongdi = 2;
                }
                else if (huongdi == 2)
                {
                    x--;
                    if (x <= xmin)
                        huongdi = 3;
                }
                else if (huongdi == 3)
                {
                    y--;
                    if (y < ymin)
                        huongdi = 0;
                }
                Console.SetCursorPosition(x, y);
                Console.Write(kytu);
                Thread.Sleep(delay);

            }
            Console.CursorVisible = true;
        }
public static void Main1(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập 1 ký tự: ");
        char kytu = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.Write("Nhập tốc độ di chuyển (delay-ms): ");
        int delay = int.Parse(Console.ReadLine());
        chayhcn(kytu, delay);

    }
}
}
