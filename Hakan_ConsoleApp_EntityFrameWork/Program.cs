using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hakan_ConsoleApp_EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NORTHWND db = new NORTHWND();
            var cat = db.Categories;
            foreach (var item in cat)
            {
                Console.WriteLine(item.CategoryName);
            }
            Console.ReadLine();
        }
    }
}
