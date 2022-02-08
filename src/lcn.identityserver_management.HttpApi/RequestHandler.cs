using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lcn.identityserver_management
{
    public static class RequestHandler
    {
        public static async Task<IActionResult> HandleQuery<TModel>(Func<Task<TModel>> query, ILogger logger)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                return new OkObjectResult(await query());
            }
            catch (Exception ex)//异常，则返回400的代码
            {
                logger.LogError(ex, $"执行查询[{typeof(TModel).FullName}]时出错");

                return new BadRequestObjectResult(new
                {
                    error = new
                    {
                        code = "400",
                        message = "出现查询异常，请刷新后再试！",
                        details = "",
                        data = new { },
                        validationErrors = ""
                    }
                });
            }
            finally
            {
                stopwatch.Stop();
                logger.LogDebug($"执行查询[{typeof(TModel).FullName}]耗时[{Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds)}]毫秒");
            }
        }
    }
}
