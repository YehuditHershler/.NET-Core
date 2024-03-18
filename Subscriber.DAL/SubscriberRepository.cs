using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Subscriber.Data;
using Subscriber.CORE.Interface.DAL;
using Subscriber.CORE.response;
using Subscriber.Data.Entities;
using Subscriber.CORE.DTO;
//using Subscriber.CORE.Interface.DAL;
//using Subscriber.Data;
//using Subscriber.Data.Entities;
//using Subscriber.CORE.response;
//using Subscriber.CORE.DTO;

namespace Subscriber.DAL
{
    public class SubscriberRepository : ISubscriberRepository
    {
        readonly WeightWatchersContext _WeightWatchersContext;
        public SubscriberRepository(WeightWatchersContext w)
        {
            _WeightWatchersContext = w;
        }

        public async Task<BaseResponse> add(SubscriberTable subscriberTable, double h)
        {
            BaseResponse response = new BaseResponse();
            try
            {
                _WeightWatchersContext.SubscriberTable.Add(subscriberTable);
                _WeightWatchersContext.SaveChanges();
                var card = new CardTable
                {
                    SubscriberId = subscriberTable.Id,
                    OpenDate = DateTime.Now,
                    BMI = 0,
                    height = h,
                    UpdateDate = DateTime.Now
                };
                _WeightWatchersContext.CardTable.Add(card);
                _WeightWatchersContext.SaveChanges();
                response.Succeed = true;
                response.Message = "good";
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception("Register Failed");
            }

        }
        public bool IsExsistEmail(string email)
        {
            if (_WeightWatchersContext.SubscriberTable.Any(t => t.Email == email))
            {
                return true;
            }
            return false;
        }

        public bool IsValidLogin(LoginDTO login)
        {
            return (_WeightWatchersContext.SubscriberTable.Any(t => t.Email == login.Email && t.Password == login.Password));

        }
        public async Task<BaseResponseGeneral<int>> Login(LoginDTO login)
        {
            BaseResponseGeneral<int> response = new BaseResponseGeneral<int>();
            SubscriberTable s = _WeightWatchersContext.SubscriberTable.Where(e => e.Email == login.Email && e.Password == login.Password).FirstOrDefault();
            response.Succeed = true;
            response.Date = s.Id;
            response.Message = "Succeed!!";
            return response;
        }

    }
}
