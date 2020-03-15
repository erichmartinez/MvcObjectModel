using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcObjectModel.Models
{
    public class PersonModel1
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public List<PersonModel2> people2 { get; set; }
    }
}