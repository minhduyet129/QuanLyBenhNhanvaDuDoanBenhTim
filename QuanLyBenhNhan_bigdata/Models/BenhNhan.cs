using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBenhNhan_bigdata.Models
{
    public class BenhNhan
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [Display(Name ="Mã bệnh nhân")]
        [Required(ErrorMessage ="{0} không được để trống")]
        public string MaBN { get; set; }
        [Display(Name ="Tên bệnh nhân")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string Ten { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string SDT { get; set; }
        [Display(Name ="Quê quán")]
        [Required(ErrorMessage = "{0} không được để trống")]
        public string QueQuan { get; set; }
        [Display(Name ="Giới tính")]
        public int GioiTinh { get; set; }
        [Display(Name ="Ngày tạo")]
        public DateTime NgayTao { get; set; }
    }
}
