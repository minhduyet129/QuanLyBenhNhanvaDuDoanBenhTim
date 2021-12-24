using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using QuanLyBenhNhan_bigdata.Models;
using QuanLyKiemTraSK_MongoDB.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBenhNhan_bigdata.Controllers
{
    public class BenhNhanController : Controller
    {
        private readonly IMongoDatabase _db;
        public BenhNhanController(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<BenhNhan> _context =>
           _db.GetCollection<BenhNhan>("BenhNhans");

        public IActionResult Index(string keyword)
        {
            var dsbenhnhan = _context.Find(x => true).ToList().OrderByDescending(x=>x.NgayTao).ToList();
            if (!String.IsNullOrEmpty(keyword))
            {
                dsbenhnhan = dsbenhnhan.Where(x => x.Ten.ToLower().Contains(keyword.ToLower()) || x.MaBN.ToLower().Contains(keyword.ToLower())||x.SDT.Contains(keyword.ToLower())).ToList();
            }
            return View(dsbenhnhan);
            
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(BenhNhan benhNhan)
        {
            benhNhan.MaBN= AutoGenMaBN();
            
            
            benhNhan.NgayTao = DateTime.Now;
            _context.InsertOne(benhNhan);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string _id)
        {
            var bn = _context.Find(x => x._id == _id).FirstOrDefault();
            return View(bn);
        }
        [HttpPost]
        public IActionResult Edit(string _id,BenhNhan benhNhan)
        {
            var filter = Builders<BenhNhan>.Filter.Eq(c => c._id, _id);
            var update = Builders<BenhNhan>.Update
                .Set("Ten", benhNhan.Ten)
                .Set("QueQuan", benhNhan.QueQuan)
                .Set("SDT", benhNhan.SDT)
                .Set("NgayTao", benhNhan.NgayTao)
                .Set("GioiTinh",benhNhan.GioiTinh);

            _context.UpdateOne(filter, update);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete([FromQuery] string _id)
        {
            var bn = _context.Find(x => x._id == _id).FirstOrDefault();
            return View(bn);
        }
        [HttpPost]
        public IActionResult DeletePost(string _id)
        {
            var filter = Builders<BenhNhan>.Filter.Eq(c => c._id, _id);
            _context.DeleteOne(filter);
            return RedirectToAction("Index");
        }
        private string AutoGenMaBN()
        {
            var mabn = "";
            var dsbenhnhan = _context.Find(x => true).ToList().Select(x => x.MaBN);
            for (int i = 1; i < 1000000; i++)
            {
                mabn = "BN" + i.ToString("d6");
                var result = dsbenhnhan.FirstOrDefault(x => x == mabn);
                if (result == null)
                {
                    return mabn;
                }
            }
            mabn = "";
            return mabn;
        }
    }
}
