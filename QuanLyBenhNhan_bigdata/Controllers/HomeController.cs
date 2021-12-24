using Heart_Disease_Prediction.ML_Model;
using Heart_Disease_Prediction.ML_Model.DataStructures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using QuanLyBenhNhan_bigdata.Models;
using QuanLyKiemTraSK_MongoDB.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBenhNhan_bigdata.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMongoDatabase _db;
        public HomeController(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        public IMongoCollection<BenhNhan> _context =>
           _db.GetCollection<BenhNhan>("BenhNhans");

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Nam = _context.Find(x => x.GioiTinh == 1).ToList().Count;
            ViewBag.Nu = _context.Find(x => x.GioiTinh == 0).ToList().Count;
            var a=_context.Find(x =>true).ToList().GroupBy(x=>x.NgayTao.Year).Select(x=>new {year=x.Key, count=x.Count()}).OrderBy(x=>x.year).ToList();
            ViewBag.Data1 = a[0].count;
            ViewBag.Data2 = a[1].count;
            ViewBag.Data3 = a[2].count;
            ViewBag.Data4 = a[3].count;
            return View();
        }
        public IActionResult Predict()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Predict(HeartData input)
        {
            var model = new MLModel();
            model.Build();
            var result = model.Consume(input);
            ViewBag.HeartPrediction = result;
            return View();
        }

    }
}
