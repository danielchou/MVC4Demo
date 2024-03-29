﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MyWebTest.Filters {

    /// <summary>
    /// http://www.developer.com/net/dealing-with-json-dates-in-asp.net-mvc.html
    /// </summary>
    public class JsonDateResult : JsonResult {
        public JsonDateResult() { }

        public override void ExecuteResult(ControllerContext context) {
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";
            if (ContentEncoding != null)
                response.ContentEncoding = ContentEncoding;
            if (Data != null) {
                JsonTextWriter writer = new JsonTextWriter(response.Output) { Formatting = Formatting.Indented };
                JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings());
                serializer.Serialize(writer, Data);
                writer.Flush();
            }
        }

    }

}