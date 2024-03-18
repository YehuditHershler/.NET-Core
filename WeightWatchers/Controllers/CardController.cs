using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.response;
using Subscriber.Data;
using Subscriber.Data.Entities;

namespace WeightWatchers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        [HttpGet]
        [Route("GetById")]
        public async Task<BaseResponseGeneral<GetCardById>> GetCardById(int id)
        {
            return await _cardService.GetCardById(id);
        }
    }
}
