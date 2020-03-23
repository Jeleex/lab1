using System;
using System.Collections.Generic;
using System.IO;
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
        public void Cht()
        {
            List<string> pp = new List<string> { };
            Vivod aa;
            pp.AddRange(File.ReadAllLines("txt.txt"));
            for (int i = 0; i <= pp.Count - 1; i += 3)
            {
                aa = new Vivod() { Naz = pp[i], Plosh = Convert.ToDouble(pp[i + 1]), Prot = Convert.ToDouble(pp[i + 2]) };
                pl.Add(aa);
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
