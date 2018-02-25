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
        public ActionResult Index()
        {
            var t = GetSheduleShift();
            var ee = from p in t.AsEnumerable()
                select p;

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

            DataRow r = table.NewRow();
         

            table.Rows.Add("1396/11/01", "2", "1");
            table.Rows.Add("1396/11/02", "2", "1");
            table.Rows.Add("1396/11/03", "2", "1");
            table.Rows.Add("1396/11/04", "2", "1");
            table.Rows.Add("1396/11/05", "3", "2");
            table.Rows.Add("1396/11/06", "3", "2");
            table.Rows.Add("1396/11/07", "3", "2");
            table.Rows.Add("1396/11/08", "3", "2");
            table.Rows.Add("1396/11/09", "3", "2");
            table.Rows.Add("1396/11/10", "3", "2");
            table.Rows.Add("1396/11/11", "3", "2");
            table.Rows.Add("1396/11/12", "3", "2");
            table.Rows.Add("1396/11/13", "3", "2");
            table.Rows.Add("1396/11/14", "3", "2");
            table.Rows.Add("1396/11/15", "3", "2");
            table.Rows.Add("1396/11/16", "3", "2");
            table.Rows.Add("1396/11/17", "3", "2");
            table.Rows.Add("1396/11/18", "3", "2");
            table.Rows.Add("1396/11/19", "3", "2");
            table.Rows.Add("1396/11/20", "3", "2");
            table.Rows.Add("1396/11/21", "3", "2");
            table.Rows.Add("1396/11/22", "3", "2");
            table.Rows.Add("1396/11/23", "3", "2");
            table.Rows.Add("1396/11/24", "3", "2");
            table.Rows.Add("1396/11/25", "3", "2");
            table.Rows.Add("1396/11/26", "3", "2");
            table.Rows.Add("1396/11/27", "3", "2");
            table.Rows.Add("1396/11/28", "3", "2");
            table.Rows.Add("1396/11/29", "3", "2");
            table.Rows.Add("1396/11/30", "3", "2");


            return table;
        }
    }

}