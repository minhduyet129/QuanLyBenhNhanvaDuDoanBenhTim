using Microsoft.ML.Data;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBenhNhan_bigdata.Models
{
    public class PhieuKT
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [Display(Name ="Mã bệnh nhân")]
        public string MaBN { get; set; }
        [Display(Name ="Mã phiếu nhập")]
        public string MaPhieu { get; set; }
        [Display(Name = "Tuổi")]
        [Required(ErrorMessage ="{0} không được trống")]
        public float Age { get; set; }
        
        [Display(Name = "Giới tính")]
        public float Sex { get; set; }
        [Display(Name ="Đau thắt ngực")]
        public float Cp { get; set; }
        [Display(Name ="Huyết áp lúc nghỉ(mmHg)")]
        [Required(ErrorMessage = "{0} không được trống")]
        public float TrestBps { get; set; }
        [Display(Name = "Lượng cholesterol(mg/dl)")]
        [Required(ErrorMessage = "{0} không được trống")]
        public float Chol { get; set; }
        [Display(Name = "Đường huyết khi đói(mg/dl)")]
        [Required(ErrorMessage = "Không được trống")]
        public float Fbs { get; set; }
        [Display(Name = "Kết quả điện tâm đồ")]
        public float RestEcg { get; set; }
        [Display(Name = "Nhịp tim tối đa")]
        [Required(ErrorMessage = "{0} không được trống")]
        public float Thalac { get; set; }
        [Display(Name = "Đau thắt khi hoạt động")]
        public float Exang { get; set; }
        [Display(Name = "Điểm ST từ hoạt động đến nghỉ ngơi")]
        [Required(ErrorMessage = "Không được trống")]
        public float OldPeak { get; set; }
        [Display(Name = "Độ dốc ST cường độ cao")]
        [Required(ErrorMessage = "Không được trống")]
        public float Slope { get; set; }
        [Display(Name = "Số lượng mạch chính soi huỳnh quang(từ 0 đến 3)")]
        [Required(ErrorMessage = "Không được trống")]
        public float Ca { get; set; }
        [Display(Name = "Bệnh tan máu bẩm sinh")]

        public float Thal { get; set; }
        [Display(Name ="Nguy cơ bệnh tim")]
        public bool Predict { get; set; }
        [Display(Name ="Tỉ lệ mắc")]
        public float Probability { get; set; }
        [Display(Name ="Ngày kiểm tra")]
        public DateTime DateTime { get; set; }
    }
}
