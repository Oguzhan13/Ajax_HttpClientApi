using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ajax_HttpClientApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Person> persons = (List<Person>)_personRepository.GetAll();
            return Ok(persons);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            Person person = _personRepository.Get(id);
            return Ok(person);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            bool result = _personRepository.Delete(id);
            return result ? Ok() : BadRequest();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
            bool result = _personRepository.Create(person);
            return result ? Ok() : BadRequest();
        }
        [HttpPut]
        public IActionResult Update(Person person)
        {
            bool result = _personRepository.Update(person);
            return result ? Ok() : BadRequest();
        }
    }
}
