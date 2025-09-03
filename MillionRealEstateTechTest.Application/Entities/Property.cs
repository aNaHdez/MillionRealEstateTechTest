namespace MillionRealEstateTechTest.Application.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        // Agrega más propiedades según tu modelo de base de datos
    }
}
