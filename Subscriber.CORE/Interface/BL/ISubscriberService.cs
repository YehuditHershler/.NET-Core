using Subscriber.CORE.DTO;
using Subscriber.CORE.response;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.CORE.Interface.BL
{
    public interface ISubscriberService
    {
        public Task<BaseResponse> add(subscriberDTO _subscriberDTO);
        public Task<BaseResponseGeneral<int>> Login(LoginDTO login);

    }
}
