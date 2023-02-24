//namespace Ajax_HttpClientApi.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class xPersonController : Controller
//    {
//        private readonly IPersonRepository _personRepository;
//        public xPersonController(IPersonRepository personRepository)
//        {
//            _personRepository = personRepository;
//        }

//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            List<Person> persons = (List<Person>) _personRepository.GetAll();
//            return Json(persons);
//        }
//        [HttpGet("Get/{id}")]
//        [Route("{id}")]
//        public IActionResult Get(int id)
//        {
//            Person person = _personRepository.Get(id);
//            return Json(person);
//        }
//        [HttpGet("Delete/{id}")]
//        [Route("{id")]
//        public IActionResult Delete(int id)
//        {
//            bool result = _personRepository.Delete(id);
//            return result ? Json("ok") : Json("fail");            
//        }
//        [HttpPost]
//        public IActionResult Create(Person person)
//        {
//            bool result = _personRepository.Create(person);
//            return result ? Json("ok") : Json("fail");
//        }
//        [HttpPut]
//        public IActionResult Update(Person person)
//        {
//            bool result = _personRepository.Update(person);
//            return result ? Json("ok") : Json("fail");
//        }
//    }
//}
