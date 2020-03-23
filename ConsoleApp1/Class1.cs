using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public List<Vivod> pl = new List<Vivod> { };
        public static List<Vivod> pll = new List<Vivod> { };
        public void Vivod()
        {
            for (int i = 0; i < pl.Count; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Название: {0}", pl[i].Naz);
                Console.WriteLine("Площадь бассейна: {0}", pl[i].Plosh);
                Console.WriteLine("Протяженность: {0}", pl[i].Prot);
            }
        }
    }
    class Vivod
    {
        public string Naz { set; get; }
        public double Plosh { set; get; }
        public double Prot { set; get; }
    }
}
