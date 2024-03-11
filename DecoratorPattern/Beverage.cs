using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI }
        public Size _size = Size.TALL;
        public string _description = "Unknow Beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        //public void SetSize(Size size)
        //{
        //    _size = size;
        //}

        public virtual Size GetSize()
        {
            return _size;
        }

        public abstract double Cost();
    }
}
