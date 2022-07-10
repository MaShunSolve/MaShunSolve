using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractice
{
    public class Dog : Animal
    {
        public Dog() : base()
        { }
        /// <summary>
        /// 定義Cat類別建構式
        /// </summary>
        /// <param name="name"></param>
        public Dog(string name) : base(name)
        { }
        /// <summary>
        /// 貓叫
        /// </summary>
        /// <returns></returns>
        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += "旺~";
            }
            return result;
        }
    }
}
