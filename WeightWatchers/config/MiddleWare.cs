
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace WeightWatchers.config
{
    public class MiddlelWare
    {
        public class ErrorHandlingMiddleware
        {
            private readonly RequestDelegate _next;
            private readonly ILogger<ErrorHandlingMiddleware> _loger;
            public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> loger)
            {
                _next = next;
                _loger = loger;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="context"></param>
            /// <returns></returns>
            public async Task Invoke(HttpContext context /* other dependencies */)
            {
                try
                {
                    //string time = DateTime.Now.ToString("yyyy-MM-dd HH:ss:mm");

                    //_loger.LogDebug($"start cell api {context.Request.Path} start in {time} ");
                    ///שורה הכי חשובה שגורמת להמשך במקרה ולא רוצים שימשיך אנחנו לא לקרוא לURV VZU 
                    await _next(context);

                    string time2 = DateTime.Now.ToString("yyyy-MM-dd HH:ss:mm");

                    //_loger.LogInformation($"end  cell api {context.Request.Path} start in {time2} ");
                }
                catch (Exception ex)
                {
                    await HandleExceptionAsync(context, ex);
                }
            }
            private static Task HandleExceptionAsync(HttpContext context, Exception ex)
            {
                //ממיר את השגיאה לJSON ומחזיר מכל הפונקציות במקרה ונפל 

                var result = JsonConvert.SerializeObject(new { error = ex.Message });
                //context.Response.ContentType = "application/json";            
                return context.Response.WriteAsync(result);
            }
        }
    }
}
