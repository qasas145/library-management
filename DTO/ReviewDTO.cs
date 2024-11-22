using System.ComponentModel.DataAnnotations;

namespace DTOS;
public class ReviewDTO {
    
    public int Id{get;set;}
    public int BookId{get;set;}
    public string UserName{get;set;}
    public string Comment{get;set;}
    [Range(1, 5)]
    public int Rating{get;set;}
}