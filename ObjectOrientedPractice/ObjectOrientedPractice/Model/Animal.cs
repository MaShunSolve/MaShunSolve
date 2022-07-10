
namespace ObjectOrientedPractice
{
    public class Animal
    {
        /// <summary>
        /// 名字
        /// </summary>
        protected string name = "";
        /// <summary>
        /// 建構式
        /// </summary>
        /// <param name="name"></param>
        public Animal(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 建構式重載
        /// </summary>
        public Animal()
        {
            this.name = "名字待取";
        }
        protected int shoutNum = 3;
        public int ShoutNum
        {
            get { return shoutNum; }
            set { shoutNum = value; }
        }
        public virtual string Shout()
        {
            return "";
        }
    }
}
