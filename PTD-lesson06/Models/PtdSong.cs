using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace PTD_lesson06.Models
{
    public class PtdSong
    {
        [Key]
        public double Id { get; set; }
        [Required(ErrorMessage ="Ptd: Hay nhap ten tieu de")]
        [DisplayName("Tieu de")]
        public string PtdTitle { get; set; }
        [Required(ErrorMessage = "Ptd: Hay nhap ten tac gia")]
        [DisplayName("Tac gia")]
        public string PtdAuthor { get; set; }
        [Required(ErrorMessage = "Ptd: Hay nhap nghe si")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Ptd: Ten nghe si co toi thieu 2 ky tu,toi da 50 ky tu")]
        [DisplayName("Nghe si")]
        public string Ptdartist { get; set; }
        [Required(ErrorMessage = "Ptd: Hay nhap nam xuat ban")]
        [RegularExpression(@"[0,9]{4}",ErrorMessage ="Ptd: Nha xuat ban phai co 2 ky tu so")]
        [Range(1900,2024,ErrorMessage ="Ptd: Nam xuat ban trong khoang 1900-2024")]
        [DisplayName("Nam xuat ban")]
        public int PtdYearRelease { get; set; }


    }
}