using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Dynamic;
using System.IO;
using  System.Web.SessionState;
using Microsoft.Ajax.Utilities;
using Reservatioan.Models;
using Reservatioan.Models.Enums;

namespace Reservatioan.Controllers
{

    public class HomeController : Controller
    {
        private int person_id;
        private string dateNow;
        private int shift;
        

        public ActionResult Index()
        {
            person_id = 34647;
            dateNow = "1396/11/01";
            shift = 1;
            User user = new User() { PersonId = person_id,Shift = shift,Restuarent = "رستوران یک",Restuarent_fk_id = 26,Name = "سید منصور محمدی"};
            Session["user"] = user;
            
            Session["permit"] = true;
            
            List<datee> naharDate =( from p in GetSheduleShift().AsEnumerable()
                     where p.Field<string>("Date").CompareTo(dateNow) == 1 & p.Field<string>("Nahar") == shift.ToString()
                     select new datee { date = p.Field<string>("Date"), meal = (int)MealEnum.ناهار ,theme = "themeLunch" }).ToList();
            List<datee> shamDate =( from p in GetSheduleShift().AsEnumerable()
                      where p.Field<string>("Date").CompareTo(dateNow) == 1 & p.Field<string>("Sham") == shift.ToString()
                      select new datee { date = p.Field<string>("Date"), meal = (int)MealEnum.شام ,theme = "themeDinner" }).ToList();

            var date = naharDate.Concat(shamDate).OrderBy(p => p.date).ToList();


            return View(date);
        }

        public ActionResult ReserveAllDay()
        {
            var user = Session["user"] as User;
            dateNow = "1396/11/01";
            List<datee> Date = (from p in GetSheduleShift().AsEnumerable()
                where p.Field<string>("Date").CompareTo(dateNow) == 1
                select new datee { date = p.Field<string>("Date")}).ToList();
            return View("temp",Date);
        }
        [HandleError]
        public ActionResult ReservePerDay(string date,int meal)
        {
            var y =(bool) Session["permit"];
            Session["permit"] = true;
            if (y)
            {
                var db = new PoonehEntities4();

                var q = Session["user"] as User;

                var trayIds = (from p in db.Schedules
                    where p.SDate.Equals(date) & p.Restaurant_Id_Fk == q.Restuarent_fk_id
                                               & p.Meal_Id_Fk == meal
                    select new { p.Tray_Id_Fk }).ToList();
                int t = (int)trayIds.ElementAt(0).Tray_Id_Fk;
                int tt = (int)trayIds.ElementAt(1).Tray_Id_Fk;
                int ttt = (int)trayIds.ElementAt(2).Tray_Id_Fk;
                List<Tray> qq = (from qqq in db.Trays
                    where qqq.Id == t || qqq.Id == tt || qqq.Id == ttt
                    select qqq).ToList();

                
                
                return View(qq);
            }
            else
            {
                return RedirectToAction("Index");
            }
        
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("test");
        }

        public ActionResult Contact()
        {
            person_id = 34647;
            dateNow = "1396/11/11";
            shift = 4;
            User user = new User() { PersonId = person_id, Shift = shift, Restuarent = "رستوران یک", Restuarent_fk_id = 26, Name = "سید منصور محمدی" };
            Session["user"] = user;

            Session["permit"] = true;

            List<datee> naharDate = (from p in GetSheduleShift().AsEnumerable()
                                     where p.Field<string>("Date").CompareTo(dateNow) == 1 & p.Field<string>("Nahar") == shift.ToString()
                                     select new datee { date = p.Field<string>("Date"), meal = (int)MealEnum.ناهار, theme = "themeLunch" }).ToList();
            List<datee> shamDate = (from p in GetSheduleShift().AsEnumerable()
                                    where p.Field<string>("Date").CompareTo(dateNow) == 1 & p.Field<string>("Sham") == shift.ToString()
                                    select new datee { date = p.Field<string>("Date"), meal = (int)MealEnum.شام, theme = "themeDinner" }).ToList();

            var date = naharDate.Concat(shamDate).OrderBy(p => p.date).ToList();



            var ttt = date.ElementAt(1);


            string htmldata = "";



            int itemrowindex = 0;


          
            foreach (var item in date)
            {

                if (itemrowindex == 0)
                {
                    htmldata += "<div class='row'>";
                }

                htmldata += "<div class='col-md-4  " + item.theme + " '  style='padding: 30px;'>";
                htmldata += "<div class='colitem'>";
                htmldata += "<a href = '../Home/ReservePerDay?date=" + item.date + "&meal=" + item.meal + "' >";
                htmldata += "<div class='col-md-8'>";
                htmldata += "<p>" + item.date + " </p>";
                htmldata += "<p>رستوران یک</p>";
                htmldata += "</div>";
                htmldata += "<div class='col-md-4'><span> <img src = '/Resources/Spoon.png' style='width: 60px; height: 60px;' /></span></div>";
                htmldata += "</a>";
                htmldata += "</div>";
                htmldata += "</div>";

                itemrowindex++;
                if (itemrowindex == 3)
                {
                    itemrowindex = 0;

                    htmldata += "</div>";
                }
            }

            ViewBag.HtmlData = htmldata;



            return View( date);
        }

        private DataTable GetSheduleShift()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Date");
            table.Columns.Add("Nahar");
            table.Columns.Add("Sham");


            table.Rows.Add("1396/11/01", "2", "1");
            table.Rows.Add("1396/11/02", "2", "1");
            table.Rows.Add("1396/11/03", "2", "1");
            table.Rows.Add("1396/11/04", "2", "1");
            table.Rows.Add("1396/11/05", "3", "2");
            table.Rows.Add("1396/11/06", "3", "2");
            table.Rows.Add("1396/11/07", "3", "2");
            table.Rows.Add("1396/11/08", "3", "2");
            table.Rows.Add("1396/11/09", "4", "3");
            table.Rows.Add("1396/11/10", "4", "3");
            table.Rows.Add("1396/11/11", "4", "3");
            table.Rows.Add("1396/11/12", "4", "3");
            table.Rows.Add("1396/11/13", "1", "4");
            table.Rows.Add("1396/11/14", "1", "4");
            table.Rows.Add("1396/11/15", "1", "4");
            table.Rows.Add("1396/11/16", "1", "4");
            table.Rows.Add("1396/11/17", "2", "1");
            table.Rows.Add("1396/11/18", "2", "1");
            table.Rows.Add("1396/11/19", "2", "1");
            table.Rows.Add("1396/11/20", "2", "1");
            table.Rows.Add("1396/11/21", "3", "2");
            table.Rows.Add("1396/11/22", "3", "2");
            table.Rows.Add("1396/11/23", "3", "2");
            table.Rows.Add("1396/11/24", "3", "2");
            table.Rows.Add("1396/11/25", "4", "3");
            table.Rows.Add("1396/11/26", "4", "3");
            table.Rows.Add("1396/11/27", "4", "3");
            table.Rows.Add("1396/11/28", "4", "3");
            table.Rows.Add("1396/11/29", "1", "4");
            table.Rows.Add("1396/11/30", "1", "4");


            return table;
        }

        private DataTable GetPersonShift()
        {
            DataTable table = new DataTable();
            table.Columns.Add("personId");
            table.Columns.Add("whichShift");

            table.Rows.Add("31319", "1");
            table.Rows.Add("34647", "2");
            table.Rows.Add("20686", "3");
            table.Rows.Add("19051", "4");
            return table;
        }



    }
}