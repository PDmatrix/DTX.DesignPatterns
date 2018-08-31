using System;

namespace DTX.DesignPatterns.Patterns.Iterator
{
    public static class ClassicIterator
    {
        // Client
        private static class Reader
        {
            public static void SeeBooks(IBookNumerable library)
            {
                var iterator = library.CreateNumerator();
                while (iterator.HasNext())
                {
                    var book = iterator.Next();
                    Console.WriteLine(book.Name);
                }
            }
        }

        // Iterator
        private interface IBookIterator
        {
            bool HasNext();
            Book Next();
        }

        // IterableCollection
        private interface IBookNumerable
        {
            IBookIterator CreateNumerator();
            int Count { get; }
            Book this[int index] { get; }
        }

        private class Book
        {
            public string Name { get; set; }
        }

        // ConcreteCollection
        private class Library : IBookNumerable
        {
            private readonly Book[] _books;
            public Library()
            {
                _books = new[]
                {
                    new Book { Name = "War and Peace" },
                    new Book { Name = "Lolita" },
                    new Book { Name = "Crime and Punishment" }
                };
            }
            public int Count => _books.Length;

            public Book this[int index] => _books[index];

            public IBookIterator CreateNumerator()
            {
                return new LibraryNumerator(this);
            }
        }

        // ConcreteIterator
        private class LibraryNumerator : IBookIterator
        {
            private readonly IBookNumerable _aggregate;
            private int _index;
            public LibraryNumerator(IBookNumerable a)
            {
                _aggregate = a;
            }
            public bool HasNext()
            {
                return _index < _aggregate.Count;
            }

            public Book Next()
            {
                return _aggregate[_index++];
            }
        }

        public static void Start()
        {
            var library = new Library();
            Reader.SeeBooks(library);
        }
    }
}