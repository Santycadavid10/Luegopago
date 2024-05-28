namespace Coupons.Models;

public class Coupons
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double ValueCoupon { get; set; }
    public string? Stores { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndingDate  { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; }
    public int Cumulative { get; set; }
    public double ValueMinimum { get; set; }
    public double ValueMaximum { get; set; }
    public string? ImagenCupon { get; set; } // Ruta de la imagen en wwwroot
    
    [NotMapped]
    public IFormFile? ImagenReal { get; set; } // Archivo de imagen

        
}