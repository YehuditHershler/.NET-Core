using Subscriber.CORE.Interface.DAL;
using Subscriber.CORE.response;
using Subscriber.Data;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.DAL
{
    public class CardRepository : ICardRepository
    {
        readonly WeightWatchersContext _weightWatchersContext;
        public CardRepository(WeightWatchersContext weightWatchersContext)
        {
            _weightWatchersContext = weightWatchersContext;
        }
        public bool IsExsistId(int id)
        {
            return _weightWatchersContext.CardTable.Where(x => x.Id == id).Any();
        }
        public async Task<BaseResponseGeneral<GetCardById>> GetCardById(int id)
        {
            CardTable cardTable = _weightWatchersContext.CardTable.Where(x => x.Id == id).FirstOrDefault();
            SubscriberTable subscriberTable = _weightWatchersContext.SubscriberTable.Where(x => x.Id == id).FirstOrDefault();
            return new BaseResponseGeneral<GetCardById>()
            {
                Date = new GetCardById()
                {
                    FirstName = subscriberTable.FirstName,
                    LastName = subscriberTable.LastName,
                    Weight = cardTable.weight,
                    Height = cardTable.height,
                    BMI = cardTable.BMI,
                    Id = cardTable.Id,

                },
                Succeed = true,
                Message = "Good!!",
            };
        }

    }
}