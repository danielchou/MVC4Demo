using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebTest.Filters {

    /// <summary>
    /// CORS:Cross-site HTTP requests 跨Site資源分享
    /// 
    /// Please ref: https://developer.mozilla.org/en-US/docs/Web/HTTP/Access_control_CORS
    /// 裡面有很詳細的安全設定說明。
    /// </summary>
    public class AllowCrossSiteJsonAttribute : ActionFilterAttribute {
        public override void OnActionExecuting(ActionExecutingContext filterContext) {
            filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*"); //*:代表任何網域網站都可取得資源
            base.OnActionExecuting(filterContext);
        }
    }

}