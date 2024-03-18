using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subscriber.CORE.DTO;
using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.response;
using Subscriber.Data.Entities;

namespace WeightWatchers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Subscriber_Controller : ControllerBase
    {
        readonly ISubscriberService _subscriberController;
        public Subscriber_Controller(ISubscriberService subscriberController)
        {
            _subscriberController = subscriberController;
        }
        // POST: Subscriber_Controller/Create
        [HttpPost]
        public async Task<BaseResponse> add(subscriberDTO subscriberDTO)
        {
            return await _subscriberController.add(subscriberDTO);
        }
        [HttpPost("/login")]
        public async Task<BaseResponseGeneral<int>> Login(LoginDTO login)
        {
            return await _subscriberController.Login(login);
        }

    }
}
