using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    /// <summary>
    /// Client endpoints.
    /// </summary>
    public class ClientsController : ApiController
    {
        /// <summary>
        /// Returns list of all clients.
        /// </summary>
        public ClientsController()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Client Get()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns specific client.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Client Get(int id)
        {
            //return clients.Where(x => x.Id == id).FirstOrDefault();
            throw new NotImplementedException();
        }
    }
}
