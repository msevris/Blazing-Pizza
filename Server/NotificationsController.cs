using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza.Server
{
    [Route("notifications")]
    [ApiController]
    [Authorize]
    public class NotificationsController : Controller
    {
        private readonly PizzaStoreContext _db;

        public NotificationsController(PizzaStoreContext db)
        {
            _db = db;
            
        }

        [HttpPut("subscribe")]
        public async Task<NotificationSubscription> Subscribe(NotificationSubscription subscription)
        {
            /* We are storing at most one subscription per user, so delete old ones. 
             Alternatively, you could let the user register multiple subscriptions from browsers/devices.*/
            var userId = GetUserId();
            var oldSubscriptions = _db.NotificationSubscriptions.Where(e => e.UserId == userId);
            _db.NotificationSubscriptions.RemoveRange(oldSubscriptions);

            // store new subscriptions
            subscription.UserId = userId;
            _db.NotificationSubscriptions.Attach(subscription);

            await _db.SaveChangesAsync();
            return subscription;
        }
        private string GetUserId()
        {
            // return HttpContext.User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value;
            // return HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
