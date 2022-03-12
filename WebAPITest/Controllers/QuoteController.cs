using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class QuoteController : ApiController
    {
        [HttpGet] //Annotation
        [Route("api/search/{id}")]
        public DraftQuote Get(int id)
        {
            DraftQuote draftQuote = new DraftQuote(id, "Janyo");
            return draftQuote;
        }         
    }
}
