using RestFulWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using System.Web.Handlers.TransferRequestHandler;

namespace RestFulWeb.Controllers
{
    public class UserController : ApiController
    {
        private UserContext db = new UserContext();

        public IEnumerable<User> Get()
        {
            return db.Users.AsEnumerable();
        }
        public User Get(int id)
        {
            var friend = db.Users.Find(id);
            if (friend != null)
            {

                return friend;
            }
            return null;
        }
            /// <summary>
            /// Post 添加
            /// </summary>
            /// <param name="user"></param>
            /// <returns></returns>
        public HttpResponseMessage Post(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, user);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
        /// <summary>
        /// Put 修改
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
          ///[HttpPut("{id}")]
        public HttpResponseMessage Put(User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                var response = Request.CreateResponse(HttpStatusCode.OK, user);
                return response;
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///[HttpDelete("{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var friend = db.Users.Find(id);
            if (friend != null)
            {
                db.Users.Remove(friend);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, friend);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }

    }
}
