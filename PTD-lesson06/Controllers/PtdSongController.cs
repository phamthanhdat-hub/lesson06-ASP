using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTD_lesson06.Models;

namespace PTD_lesson06.Controllers
{
    public class PtdSongController : Controller
    {

        private static List<PtdSong> ptdSongs = new List<PtdSong>()
            {
                new PtdSong{Id=2210900007,PtdTitle="Pham Thanh Dat",PtdAuthor="k22CNT3",Ptdartist="NTU",PtdYearRelease=2020},
                  new PtdSong{Id=1,PtdTitle="Pham Thanh Dat",PtdAuthor="k22CNT3",Ptdartist="NTU",PtdYearRelease=2020},
            };

        //Get: PtdSong
        /// <summary>
        ///  <summary>
        ///  Hien thi danh sach bai hat
        ///  Author:Pham Thanh Dat
        ///  </summary>
        /// </summary>
        /// <returns></returns>
        public ActionResult PtdIndex()
        {
            return View();
        }
        //Get: PtdCreate
        /// <summary>
        /// Form Them moi bai hat
        /// Author: Pham Thanh Dat
        /// </summary>
        /// <returns></returns>
        public ActionResult PtdCreate()
        {
            var PtdSong = new PtdSong();
            return View();
        }
    }
}