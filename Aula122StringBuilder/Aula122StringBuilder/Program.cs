using System;
using Aula122StringBuilder.Entities;
namespace Aula122StringBuilder
{
    class Program
    {

        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awesome!");
            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the force be with you");





            Post post1 = new Post(
                DateTime.Parse("20/12/2020 10:30"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );
            post1.AddComment(comment1);
            post1.AddComment(comment2);
            Post post2 = new Post(
                DateTime.Parse("21/12/2020 18:45"),
                 "Good night guys",
                 "See you tomorrow",
                 5
                 );
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
