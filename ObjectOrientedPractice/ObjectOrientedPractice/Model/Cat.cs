
namespace ObjectOrientedPractice
{
    /// <summary>
    /// Cat Class
    /// </summary>
    public class Cat : Animal
    {
        public Cat() : base()
        { }
        /// <summary>
        /// 定義Cat類別建構式
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name) :base(name)
        { }
        /// <summary>
        /// 貓叫
        /// </summary>
        /// <returns></returns>
        public override string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵~";
            }
            return result;
        }
    }
}
