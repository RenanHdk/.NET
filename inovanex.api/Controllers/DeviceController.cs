using Microsoft.AspNetCore.Mvc;
using Web_api.Data;
using Web_api.Models;
using Microsoft.AspNetCore.Authorization;


namespace Web_api.Controllers
{        
    [Route("api/Devices")]
    [ApiController]
    public class DeviceController : Controller
    {
        private readonly DataContext _db;

            public DeviceController(DataContext db)
            {
                _db = db;
            }

            [HttpGet]
            [Authorize]
            public async Task<ActionResult<List<Device>>> Getdb()
            {
                return _db.cd.ToList();
            }


            [HttpGet("{UuseId}")]
            public async Task<ActionResult<List<Device>>> getCardsUser(string UuseId)
            {
                var cards = _db.cd.Where(c => c.userId == UuseId);
                return cards.ToList();
            }



            // [HttpGet("{Uid}/{Utitle}/{Ustatus}/{Uwifi}")]
            // public void testCard(int Uid, string Utitle, string Ustatus, string Uwifi)
            // {
            //     var tmp = _db.cd.Find(Uid);
            //     if (tmp != null)
            //     {
            //         tmp.status = Ustatus;
            //         _db.SaveChanges();
            //     }
            // }


            [HttpGet("{Uid}/{Utitle}/{Ustatus}/{Uwifi}")]
            public void addCard(int Uid, string Utitle, string Ustatus, string Uwifi)
            {
                _db.Add(new Device { id = Uid, title = Utitle, status = Ustatus, wifi = Uwifi });
                _db.SaveChanges();
            }


            [HttpGet("status/{Uid}/{Ustatus}")]
            public void updateStatusCard(int Uid, string Ustatus)
            {
                var tmp = _db.cd.Find(Uid);
                if (tmp != null)
                {
                    tmp.status = Ustatus;
                    _db.SaveChanges();
                }
            }

            [HttpGet("wifi/{Uid}/{Uwifi}")]
            public void updateWifiCard(int Uid, string Uwifi)
            {
                var tmp = _db.cd.Find(Uid);
                if (tmp != null)
                {
                    tmp.wifi = Uwifi;
                    _db.SaveChanges();
                }
            }


            [HttpGet("title/{Uid}/{Utitle}")]
            public void updateTitleCard(int Uid, string Utitle)
            {
                var tmp = _db.cd.Find(Uid);
                if (tmp != null)
                {
                    tmp.title = Utitle;
                    _db.SaveChanges();
                }
            }


            [HttpGet("delete/{Uid}")]
            public void deleteCard(int Uid)
            {
                var tmp = _db.cd.Find(Uid);
                if (tmp != null)
                {
                    _db.Remove(tmp);
                    _db.SaveChanges();
                }
            }
        }
    }
