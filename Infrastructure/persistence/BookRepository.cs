
public class BookRepository : IRepository<Book>
{
    List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "C# Programming", Author = "John Doe", Price = 29.99m, Description = "A comprehensive guide to C# programming.", StockQuantity = 100, AverageRating = 10 },
        new Book { Id = 2, Title = "Java Basics", Author = "Jane Smith", Price = 24.99m, Description = "Learn the basics of Java programming.", StockQuantity = 50, AverageRating = 4 },
        new Book { Id = 3, Title = "Python for Data Science", Author = "Alice Johnson", Price = 34.99m, Description = "Master Python for data science and machine learning.", StockQuantity = 75, AverageRating = 4 },
        new Book { Id = 4, Title = "Web Development with React", Author = "Bob Brown", Price = 39.99m, Description = "A guide to building modern web apps with React.", StockQuantity = 30, AverageRating = 4 },
        new Book { Id = 5, Title = "Database Design", Author = "Emily Davis", Price = 49.99m, Description = "Learn how to design efficient and scalable databases.", StockQuantity = 20, AverageRating = 4 },
        new Book { Id = 6, Title = "Machine Learning for Beginners", Author = "Charlie White", Price = 42.99m, Description = "Introduction to machine learning concepts and techniques.", StockQuantity = 40, AverageRating = 4 },
        new Book { Id = 7, Title = "Advanced JavaScript", Author = "David Green", Price = 29.99m, Description = "Deep dive into advanced JavaScript programming.", StockQuantity = 60, AverageRating = 4 },
        new Book { Id = 8, Title = "The Art of Programming", Author = "Sarah Black", Price = 54.99m, Description = "Explore programming techniques and algorithms in depth.", StockQuantity = 25, AverageRating = 2 },
        new Book { Id = 9, Title = "Data Structures and Algorithms", Author = "Michael Harris", Price = 36.99m, Description = "Master data structures and algorithms in C++.", StockQuantity = 80, AverageRating = 4 },
        new Book { Id = 10, Title = "Full Stack Development", Author = "Olivia King", Price = 59.99m, Description = "A complete guide to becoming a full-stack developer.", StockQuantity = 15, AverageRating = 5 }
    };
    public void Add(Book obj)
    {
        this.books.Add(obj);
    }

    public void Delete(int id)
    {
        this.books.Remove(this.books.FirstOrDefault(b=>b.Id == id));
    }

    public IEnumerable<Book> GetAll()
    {
        return books;
    }

    public Book GetById(int id)
    {
        return this.books.FirstOrDefault(b=>b.Id == id);
    }

    public void Update(Book obj)
    {
        throw new NotImplementedException();
    }
}