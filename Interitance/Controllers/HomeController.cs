using Interitance.Application;
using Interitance.Converters;
using Interitance.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interitance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly AdditionalService _additionalService;
        private readonly ConverterFacade _converter;

        public HomeController(AdditionalService additionalService,
            ConverterFacade converter)
        {
            _additionalService = additionalService;
            _converter = converter;
        }

        // GET: HomeController
        [HttpGet]
        public ActionResult Index()
        {
            //var animals = _additionalService.Get<Animal>();
            var animals = _additionalService.Search(new Parameters.AninalSearchParams());

            var dog = new Dog();
            _additionalService.Update(dog);

            var dtos = animals.Select(x => _converter.Convert(x)).ToList();

            return Ok(dtos);
        }
    }
}
