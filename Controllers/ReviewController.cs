using DTOS;
using Microsoft.AspNetCore.Mvc;

public class ReviewController : Controller{
    public ReviewController(ILogger<ReviewController> logger, IRepository<Review> repository) {
        _logger = logger;
        _repository = repository;
    }

    private ILogger<ReviewController> _logger;
    private readonly IRepository<Review> _repository;

    public IActionResult ManageReviews() {
        var reviews = _repository.GetAll().Select(r=>new ReviewDTO(){Id = r.Id, BookId = r.BookId, Comment = r.Comment, Rating = r.Rating, UserName = r.UserName});
        return View(reviews);
    }
    public IActionResult AddReview() {
        return View();
    }
    
    [HttpPost]
    public IActionResult SubmitReview(Review review) {
        _repository.Add(review);
        return Ok("the review has been added sucessfully");
    }
}