using System;
namespace BookShopOnline.Models
public class Class1
{
    public Class1()
    {
        [ScaffoldColumn(false)]
    public int TheloaiID { get; set; }
    [Required, StringLength(100), Display(Name = "Ten")]
    public string Tenloai { get; set; }
    public virtual ICollection<Book> Books { get; set; }
} 
        
}
    

