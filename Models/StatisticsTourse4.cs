namespace TourseWebApi.Models
{
    public class StatisticsTourse4
    {
        /// <summary>
        /// Всего туров(кол-во)
        /// </summary>
        public int CountTourse { get; set; }
        /// <summary>
        /// Общая сумма
        /// </summary>
        public decimal AllTotalAmount { get; set; }
        /// <summary>
        /// Всего туров c доплатами(кол-во)
        /// </summary>
        public int CountTourseWithSur { get; set; }
        /// <summary>
        /// Общая сумма доплат
        /// </summary>
        public decimal AllTotalAmountWithSur { get; set; }
    }
}
