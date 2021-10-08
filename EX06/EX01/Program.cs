using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog muki = new Dog("Muki");
            Dog pontu = new Dog("Pontu");
            muki.Age = 5;
            Console.WriteLine(muki.Age);
            pontu.Age = 14;
            muki.ChangeOwnersName("Jyri");
            muki.ChangeOwnersName("T6nu");
            muki.Run();
            pontu.Run();
            muki.PrintInfo();
            pontu.PrintInfo();
        }
    }
}
