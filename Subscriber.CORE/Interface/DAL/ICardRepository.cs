using Subscriber.CORE.response;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.CORE.Interface.DAL
{
    public interface ICardRepository
    {
        public Task<BaseResponseGeneral<GetCardById>> GetCardById(int id);
        public bool IsExsistId(int id);
    }
}
