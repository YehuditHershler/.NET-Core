using Subscriber.CORE.Interface.BL;
using Subscriber.CORE.Interface.DAL;
using Subscriber.CORE.response;
using Subscriber.DAL;
using Subscriber.Data;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.BL
{
    public class CardService : ICardService
    {
        readonly ICardRepository _cardRepository;
        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }
        public async Task<BaseResponseGeneral<GetCardById>> GetCardById(int id)
        {
            if (_cardRepository.IsExsistId(id))
                return await _cardRepository.GetCardById(id);
            return new BaseResponseGeneral<GetCardById>() { Message = "ERROR,Not found!", Date = null };
        }
    }
}
