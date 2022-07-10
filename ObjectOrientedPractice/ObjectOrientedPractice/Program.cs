namespace ObjectOrientedPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();//Cat類別實體化
            cat.ShoutNum = 11;
            Console.WriteLine(cat.Shout());
            Dog dog = new Dog();
            Console.WriteLine(dog.Shout());
        }
    }
}