
public class ReviewRepository : IRepository<Review>
{
    List<Review> reviews = new List<Review>
    {
        new Review
        {
            Id = 1,
            BookId = 1,
            UserName = "Ahmed",
            Comment = "Great book for learning C#",
            Rating = 5
        },
        new Review
        {
            Id = 2,
            BookId = 2,
            UserName = "Sara",
            Comment = "Very informative for beginners in Java",
            Rating = 4
        }
    };
    public void Add(Review obj)
    {
        reviews.Add(obj);
    }

    public void Delete(int id)
    {
        this.reviews.Remove(this.reviews.FirstOrDefault(r=>r.Id == id));
    }

    public IEnumerable<Review> GetAll()
    {
        return this.reviews;
    }

    public Review GetById(int id)
    {
        return this.reviews.FirstOrDefault(r=>r.Id == id);
    }

    public void Update(Review obj)
    {
        throw new NotImplementedException();
    }
}