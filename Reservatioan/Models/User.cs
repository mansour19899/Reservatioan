using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservatioan.Models
{
    public class User
    {
        public int  PersonId { get; set; }
        public string Name { get; set; }
        public string Restuarent { get; set; }
        public int Restuarent_fk_id { get; set; }
        public int Shift { get; set; }  

    }
}