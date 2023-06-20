using Interitance.Application;
using Interitance.Converters;
using Interitance.Dtos;
using Interitance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interitance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly AdditionalService _additionalService;
        private readonly ConverterFacade _converterFacade;

        public HomeController(AdditionalService additionalService,
            ConverterFacade converter)
        {
            _additionalService = additionalService;
            _converterFacade = converter;
        }

        // GET: HomeController
        [HttpGet]
        public ActionResult Index()
        {
            var dogDto = new DogDto();
            var dog = _converterFacade.Convert(dogDto);

            _additionalService.Update(dog);

            //var animals = _additionalService.Get<Animal>();
            var animals = _additionalService.Search(new Parameters.AninalSearchParams());
            var dtos = animals.Select(x => _converterFacade.Convert(x)).ToList();

            return Ok(dtos);
        }
    }
}
