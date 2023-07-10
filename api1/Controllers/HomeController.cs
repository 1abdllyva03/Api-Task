using api1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace api1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        kompContext db = new kompContext();

        [HttpGet]
        public List<Alici> Get()
        {
            return db.Alicis.ToList();
        }

        [HttpPost]
        public Alici Post(Alici a)
        {
            
            db.Alicis.Add(a);
            db.SaveChanges();
            return a;

        }
        [HttpPut("{id}")]
        public Alici Put(int id, Alici a)
        {
            Alici al = db.Alicis.SingleOrDefault(a => a.Id == id);
            al.AliciAd = a.AliciAd;
            db.Alicis.Add(a);
            db.SaveChanges();
            return al;

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Alici a = db.Alicis.SingleOrDefault(a => a.Id == id);
            db.Alicis.Remove(a);
            db.SaveChanges();
        }
    }

}
