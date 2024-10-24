using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Athing {
        public int Price { get; set; }
        public int calculate();
    }

    public class CompositeMobile : Athing
    {
        //other prop
        public int Price { get; set; }
        public int calculate()
        {
            return Price;
        }
    }
    public class CompositeRuler : Athing
    {
        //other prop
        public int Price { get; set; }
        public int calculate()
        {
            return Price;
        }
    }
    public class CompositeBox : Athing
    {
        //other prop
        public List<Athing> Items { get; set; } = new List<Athing>();
        public int Price { get; set; }
        public int calculate()
        {
            int cal = 0;
            foreach (var i in Items)
            {
                cal += i.calculate();
            }
            return cal;
        }
    }
    public class ExecMainCompositeDesignPattern
    {
        public void ExecMain()
        {
            CompositeRuler compositeRuler1 = new CompositeRuler();
            CompositeRuler compositeRuler2 = new CompositeRuler();
            compositeRuler1.Price = 10;
            compositeRuler2.Price = 30;
            CompositeMobile mobile = new CompositeMobile();
            mobile.Price = 300;

            CompositeBox compositeBox1 = new CompositeBox();
            compositeBox1.Items.Add(compositeRuler1);
            compositeBox1.Items.Add(compositeRuler2);
            compositeBox1.Items.Add(mobile);//340

            CompositeBox compositeBox2 = new CompositeBox();
            compositeBox2.Items.Add(compositeRuler1);//340
            compositeBox2.Items.Add(compositeBox1);//10

            int x = compositeBox2.calculate();
            Console.WriteLine($"{x}");
        }
    }
}
