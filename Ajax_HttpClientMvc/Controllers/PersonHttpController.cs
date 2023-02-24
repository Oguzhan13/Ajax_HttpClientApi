using System.Text;

namespace Ajax_HttpClientMvc.Controllers
{
    public class PersonHttpController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public PersonHttpController(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> GetAll()
        {
            HttpClient client = _httpClient.CreateClient("url");
            var result = await client.GetAsync("Person/GetAll");
            var jsonString = await result.Content.ReadAsStringAsync();
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            return View(persons);            
        }

        public async Task<IActionResult> Create(Person person)
        {
            //person.Id = 6;
            //person.FullName = "Mehmet Kaya";
            //person.BirthOfDate = new DateTime(2005, 3, 2);

            var jsonPerson = JsonConvert.SerializeObject(person);
            HttpClient client = _httpClient.CreateClient("url");
            var data = new StringContent(jsonPerson, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("Person/Create", data);
            return View();
        }
    }
}
