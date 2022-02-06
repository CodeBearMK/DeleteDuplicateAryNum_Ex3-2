namespace DeleteDuplicateAryNum_Ex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] AryNum = { 23, 12, 34, 12, 45, 12, 23 };
            Console.Write("1. 陣列的初值：");
            for (int i = 0; i < AryNum.Length; i++)
            {
                Console.Write("{0}, ", AryNum[i]);
            }
            Console.WriteLine();

            Console.Write("2. 刪除重複的值後：");
            Array.Sort(AryNum);
            AryNum = AryNum.Distinct().ToArray();
            for (int j = 0; j < AryNum.Length; j++)
            {
                Console.Write("{0}, ", AryNum[j]);
            }
            Console.Read();
        }
    }
}