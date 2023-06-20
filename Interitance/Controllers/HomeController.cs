using Interitance.Application;
using Interitance.Converters;
using Interitance.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Interitance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly AnimalService _additionalService;
        private readonly ConverterFacade _converterFacade;

        public HomeController(AnimalService additionalService,
            ConverterFacade converter)
        {
            _additionalService = additionalService;
            _converterFacade = converter;
        }

        // GET: HomeController
        [HttpGet]
        public ActionResult Index()
        {
            var dogDto = new DogDto()
            {
                Type = "dog",
            };
            var dog = _converterFacade.CreateConvert(dogDto);

            _additionalService.Create(dog);

            //var animals = _additionalService.Get<Animal>();
            var animals = _additionalService.Search(new Parameters.AninalSearchParams());
            var dtos = animals.Select(x => _converterFacade.ConvertToDto(x)).ToList();

            return Ok(dtos);
        }
    }
}
