namespace Resturant.Models.DTOs
{
    public class MenuDTO
    {
        public int MenuId { get; set; }

        public string DishName { get; set; }
        public int Price { get; set; }
        public bool Availability { get; set; }
    }
}
