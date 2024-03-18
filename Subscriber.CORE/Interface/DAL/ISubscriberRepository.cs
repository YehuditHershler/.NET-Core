using Subscriber.CORE.DTO;
using Subscriber.CORE.response;
using Subscriber.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Subscriber.CORE.Interface.DAL
{
    public interface ISubscriberRepository
    {
        public Task<BaseResponse> add(SubscriberTable _subscriberTable, double hight);
        public Task<BaseResponseGeneral<int>> Login(LoginDTO login);
        bool IsExsistEmail(string Email);
        bool IsValidLogin(LoginDTO login);

    }
}
