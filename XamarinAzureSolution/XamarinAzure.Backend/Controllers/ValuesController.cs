using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace XamarinAzure.Backend.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Authorize]
        [Route("private/{valor:int?}")]
        public string Private(int? valor = null)
        {
            return (!valor.HasValue) ? "Você não informou um valor" : $"{this.RequestContext.Principal.Identity.GetUserName()} informou {valor} e realizou uma chamada autenticada.";
        }

        [HttpGet]
        [Route("public/{valor:int?}")]
        public string Public(int? valor = null)
        {
            return (!valor.HasValue) ? "Você não informou um valor" : $"Você informou {valor} e realizou uma chamada pública.";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
