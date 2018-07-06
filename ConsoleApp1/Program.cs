using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Something
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var somethings = new List<Something>
            {
                new Something{Name = "Taro"},
                new Something{Name = "Jiro"}
            };

            foreach (var piece in somethings)
            {
                Console.WriteLine(string.Format("Id={0},Name={1}", piece.Id, piece.Name));
                
            }
            Console.ReadLine();
	//Id=0,Name=Taro
	//Id=0,Name=Jiro

        }
    }
}
