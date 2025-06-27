using _100_ExercicioFixacao_Enum_Composicao_02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_ExercicioFixacao_Enum_Composicao_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awsome!");


            Post post1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), 
                "Traveling to New Zealand", 
                "I'm going to visit this wonderful country!", 
                12);
            post1.AddComment(c1);
            post1.AddComment(c2);


            Console.WriteLine();

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the force be with you");

            Post post2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), 
                "Good Night guys", 
                "See you tomorrow", 
                5);
            post2.AddComment(c3);
            post2.AddComment(c4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
