namespace TourseWebApi.Models
{
    public class AddTourse4RequestModel
    {
        public Direction direction { get; set; }
        public DateTime DateDeparture { get; set; }
        public int NumberNight { get; set; }
        public decimal CostVac { get; set; }
        public int NumberVac { get; set; }
        public bool Wi_Fi { get; set; }
        public decimal Surcharges { get; set; }
    }
}
