
namespace ObjectOrientedPractice
{
    /// <summary>
    /// Cat Class
    /// </summary>
    public class Cat
    {
        /// <summary>
        /// 貓叫次數
        /// </summary>
        private int shoutNum = 3;
        public int ShoutNum
        { 
            get { return shoutNum; }
            set { shoutNum = value; }
        }
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
        
        /// <summary>
        /// 貓叫
        /// </summary>
        /// <returns></returns>
        public string Shout()
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
