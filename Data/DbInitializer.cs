using LibraryApi.Models;
using System;
using System.Linq;

namespace LibraryApi.Data
{
    public class DbInitializer
    {
        internal static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            if (context.Books.Any())
            {
                return;
            }

            var books = new Book[]
            {
                new Book {Name ="Война и мир", Author = "Лев Толстой", Count = 2},
                new Book {Name ="Сказка о царе Салтане", Author = "Александр Пушкин", Count = 1},
                new Book {Name ="Чистый код", Author = "Дядюшка Боб", Count = 2},
                new Book {Name ="Мастер и маргарита", Author = "Михаил Булгаков", Count = 1},
                new Book {Name ="Совершенный код", Author = "Стив Макконел", Count = 2}
            };

            context.AddRange(books);
            context.SaveChanges();

            var readers = new Reader[]
            {
                new Reader{FullName = "Алмазов Игорь Павлович", Birthday = new DateTime(2000, 12, 26) },
                new Reader{FullName = "Петров Петр Петрович", Birthday = new DateTime(1998, 1, 16) },
                new Reader{FullName = "Иванов Иван Иванович", Birthday = new DateTime(1970, 11, 1) }
            };

            context.AddRange(readers);
            context.SaveChanges();
        }
    }
}
