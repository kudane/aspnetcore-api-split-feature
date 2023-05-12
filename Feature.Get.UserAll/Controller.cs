namespace Feature.Get.UserAll
{
    [ApiController]
    [Route("api")]
    public class Controller : ControllerBase
    {
        [HttpGet("GetUserAll")]
        public IActionResult Get()
        {
            // for fake using [Model]
            var model = new Model() 
            {
                UserId= 1,
                Fullname = "Test User A"
            };

            // for fake using [Serice]
            var service = new Service();

            var response = service.Handle();

            return Ok(response);
        }
    }
}