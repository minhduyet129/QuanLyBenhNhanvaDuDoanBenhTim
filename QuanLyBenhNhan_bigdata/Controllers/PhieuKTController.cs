using Heart_Disease_Prediction.ML_Model;
using Heart_Disease_Prediction.ML_Model.DataStructures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Newtonsoft.Json;
using QuanLyBenhNhan_bigdata.Models;
using QuanLyKiemTraSK_MongoDB.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuanLyBenhNhan_bigdata.Controllers
{
    public class PhieuKTController : Controller
    {
        public readonly IMongoDatabase _db;

        public PhieuKTController(IOptions<Settings> options)
        {

            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<PhieuKT> _context =>
           _db.GetCollection<PhieuKT>("PhieuKiemTra");

        
        public IActionResult GetAllPhieuKTTheoBN(string MaBN)
        {
            var dsphieu = _context.Find(x =>x.MaBN==MaBN).SortByDescending(x=>x.DateTime).ToList();
            ViewBag.MaBN = MaBN;
            return View(dsphieu);
        }

        [HttpGet]
        public IActionResult Create(string MaBN)
        {
            ViewBag.MaBN = MaBN;
            return View();
        }

        [HttpPost]
        public IActionResult Create(PhieuKT phieukt)
        {
            HeartData input = new HeartData()
            {
                Age = phieukt.Age,
                Sex=phieukt.Sex,
                Cp=phieukt.Cp,
                TrestBps=phieukt.TrestBps,
                Chol=phieukt.Chol,
                Fbs=phieukt.Fbs,
                RestEcg=phieukt.RestEcg,
                Thalac=phieukt.Thalac,
                Exang=phieukt.Exang,
                OldPeak=phieukt.OldPeak,
                Slope=phieukt.Slope,
                Ca=phieukt.Ca,
                Thal=phieukt.Thal

            };
            var model = new MLModel();
            model.Build();
            var result = model.Consume(input);
            phieukt.Predict = result.Prediction;
            phieukt.Probability = result.Probability;
            phieukt.MaPhieu = AutoGenMaPhieu();
            phieukt.DateTime = DateTime.Now;
            _context.InsertOne(phieukt);
            return RedirectToAction("GetAllPhieuKTTheoBN",new { MaBN=phieukt.MaBN});
        }
        [HttpGet]
        public IActionResult Edit(string MaBN,string _id)
        {
            var phieu = _context.Find(x => x._id == _id).FirstOrDefault();
            ViewBag.MaBN = MaBN;
            return View(phieu);
        }
        [HttpPost]
        public IActionResult Edit(PhieuKT phieukt)
        {
            HeartData input = new HeartData()
            {
                Age = phieukt.Age,
                Sex = phieukt.Sex,
                Cp = phieukt.Cp,
                TrestBps = phieukt.TrestBps,
                Chol = phieukt.Chol,
                Fbs = phieukt.Fbs,
                RestEcg = phieukt.RestEcg,
                Thalac = phieukt.Thalac,
                Exang = phieukt.Exang,
                OldPeak = phieukt.OldPeak,
                Slope = phieukt.Slope,
                Ca = phieukt.Ca,
                Thal = phieukt.Thal

            };
            var model = new MLModel();
            model.Build();
            var result = model.Consume(input);
            phieukt.Predict = result.Prediction;
            phieukt.Probability = result.Probability;
            var filter = Builders<PhieuKT>.Filter.Eq(c => c._id,phieukt._id);
            var update = Builders<PhieuKT>.Update
                .Set("Age", phieukt.Age)
                .Set("Sex", phieukt.Sex)
                .Set("Cp", phieukt.Cp)
                .Set("TrestBps",phieukt.TrestBps)
                .Set("Fbs", phieukt.Fbs)
                .Set("RestEcg", phieukt.RestEcg)
                .Set("Thalac",phieukt.Thalac)
                .Set("OldPeak", phieukt.OldPeak)
                .Set("Exang",phieukt.Exang)
                .Set("Slope", phieukt.Slope)
                .Set("Ca", phieukt.Ca)
                .Set("Thal", phieukt.Thal)
                .Set("Chol", phieukt.Chol)
                .Set("Predict",phieukt.Predict)
                .Set("Probability", phieukt.Probability)
                .Set("DateTime", phieukt.DateTime);

            _context.UpdateOne(filter, update);
            
            return RedirectToAction("GetAllPhieuKTTheoBN", new { MaBN = phieukt.MaBN });
        }

        [HttpGet]
        public IActionResult Details(string _id)
        {
            var phieu = _context.Find(x => x._id == _id).FirstOrDefault();
           
            return View(phieu);
        }
        
        [HttpGet]
        public IActionResult Delete(string MaBN, string _id)
        {
            var phieu = _context.Find(x => x._id == _id).FirstOrDefault();
            ViewBag.MaBN = MaBN;
            return View(phieu);
        }
        public IActionResult DeletePost(string _id,string MaBN)
        {
            var filter = Builders<PhieuKT>.Filter.Eq(c => c._id, _id);
            _context.DeleteOne(filter);
            return RedirectToAction("GetAllPhieuKTTheoBN", new { MaBN = MaBN });
        }
        public JsonResult Predict(HeartData input)
        {
            var model = new MLModel();
            model.Build();
            var result = model.Consume(input);
            var predict = result.Prediction ? "Có":"Không";
            return Json(new {prediction=predict,probability=result.Probability });
        }
        private string AutoGenMaPhieu()
        {
            var mabn = "";
            var dsbenhnhan = _context.Find(x => true).ToList().Select(x => x.MaPhieu);
            for (int i = 1; i < 1000000; i++)
            {
                mabn = "P" + i.ToString("d6");
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
