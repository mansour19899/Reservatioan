using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

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
            dateNow = "1396/11/03";
            shift = 2;

            var ee = from p in GetSheduleShift().AsEnumerable()
                where p.Field<string>("Date").CompareTo(dateNow)==1 & p.Field<string>("Nahar")==shift.ToString()
                     select p;
     
            int x = 5;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
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