using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review {
    public int Id{get;set;}
    public int BookId{get;set;}
    [ForeignKey("BookId")]
    public string UserName{get;set;}
    public string Comment{get;set;}
    [Range(1, 5)]
    public int Rating{get;set;}
    public Book Book{get;set;}
}