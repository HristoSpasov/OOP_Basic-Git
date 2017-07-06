namespace _02.Book_Shop
{
    using System;

    public class Book
    {
        private string author;
        private decimal price;
        private string title;

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        protected virtual decimal Price
        {
            get => price;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");

                price = value;
            }
        }

        protected string Author
        {
            get => author;

            set
            {
                var authorNames = value
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (authorNames.Length == 2)
                    if (char.IsDigit(value.Split()[1][0]))
                        throw new ArgumentException("Author not valid!");

                author = value;
            }
        }

        protected string Title
        {
            get => title;

            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Title not valid!");

                title = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}\n" +
                   $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Price: {Price:F1}\n";
        }
    }
}