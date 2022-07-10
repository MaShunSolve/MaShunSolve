
namespace ObjectOrientedPractice
{
    /// <summary>
    /// Cat Class
    /// </summary>
    public class Cat
    {
        private string name = "";
        /// <summary>
        /// 定義Cat類別建構式
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 重載
        /// </summary>
        public Cat()
        {
            this.name = "等待取名";
        }

        public string Shout()
        {
            return $"My name is {name} 喵~";
        }
    }
}
