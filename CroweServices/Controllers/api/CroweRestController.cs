using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweServices.Controllers.api
{
    public class CroweRestController : ApiController
    {
		[HttpGet(), Route("CroweRest/GetData")]
		IHttpActionResult GetData()
		{
			try
			{
				CroweDataAccess.DataHandler data = new CroweDataAccess.DataHandler();
				var s = data.RetrieveData();
				return Ok(s);
			}
			catch(Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
    }
}
