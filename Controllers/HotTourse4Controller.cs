
using Microsoft.AspNetCore.Mvc;
using TourseWebApi.Models;

namespace TourseWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotTourse4Controller : ControllerBase
    {
        private static readonly IList<Tours4> Tours4List = new List<Tours4>();

        [HttpGet]
        public IEnumerable<Tours4> Get()
        {
            return Tours4List;
        }
        [HttpGet("Statistics")]
        public StatisticsTourse4 GetStatistics()
        {
            var stratic = new StatisticsTourse4()
            {
                CountTourse = Tours4List.Count(),
                AllTotalAmount = Tours4List.Sum(x => (x.NumberNight * x.NumberVac * x.CostVac) + x.Surcharges),
                CountTourseWithSur = Tours4List.Where(x => x.Surcharges != 0).Count(),
                AllTotalAmountWithSur = Tours4List.Sum(x => x.Surcharges),
            };
            return stratic;
        }
        

        [HttpPost]
        public Tours4 AddTours(AddTourse4RequestModel model)
        {
            var tours = new Tours4()
            {
                Id = Guid.NewGuid(),
                direction = model.direction,
                DateDeparture = model.DateDeparture,
                NumberNight = model.NumberNight,
                CostVac = model.CostVac,
                NumberVac = model.NumberVac,
                Wi_Fi = model.Wi_Fi,
                Surcharges = model.Surcharges,
                TotalAmount = (model.NumberNight * model.NumberVac * model.CostVac) + model.Surcharges,
            };
            Tours4List.Add(tours);
            return tours;
        }
        [HttpPut]
        public Tours4 UpdateTours([FromRoute] Guid id,[FromBody] AddTourse4RequestModel model)
        {
            var toursElement = Tours4List.FirstOrDefault(x => x.Id == id);
            if (toursElement != null)
            {
                toursElement.direction = model.direction;
                toursElement.DateDeparture = model.DateDeparture;
                toursElement.NumberNight = model.NumberNight;
                toursElement.CostVac = model.CostVac;
                toursElement.NumberVac = model.NumberVac;
                toursElement.Wi_Fi = model.Wi_Fi;
                toursElement.Surcharges = model.Surcharges;
                toursElement.TotalAmount = (model.NumberNight * model.NumberVac * model.CostVac) + model.Surcharges;
                var index = Tours4List.IndexOf(toursElement);
                Tours4List[index] = toursElement;
            }
            return toursElement;
        }
        
        [HttpDelete]
        public bool RemoveTours(Guid id)
        {
            var tourseElement = Tours4List.FirstOrDefault(x => x.Id == id);
            if (tourseElement != null)
            {
                return Tours4List.Remove(tourseElement);
            }
            return false;
        }
        
       
    }
}
