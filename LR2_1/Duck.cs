using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_1
{
    abstract class Duck
    {
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
        public string Swim()
        {
            return "Swim " + this.GetType();
        }
        public abstract string Display();
    }

    class MallardDuck : Duck
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }
    }

    class RedheadDuck : Duck
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }
    }
}
