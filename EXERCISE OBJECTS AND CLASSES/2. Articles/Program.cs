using System;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(", ");
            int number = int.Parse(Console.ReadLine());

            Artcles article = new Artcles();

            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0]=="Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0]=="ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0]== "Rename")
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article.ToString());


    }

        class Artcles
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {


                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
