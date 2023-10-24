namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {
            RandomList randomList = new RandomList();

            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("31");
            randomList.Add("41");

            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
        }
    }
}