using Subscriber.CORE.response;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.CORE.Interface.BL
{
    public interface ICardService
    {
        public Task<BaseResponseGeneral<GetCardById>> GetCardById(int id);

    }
}
