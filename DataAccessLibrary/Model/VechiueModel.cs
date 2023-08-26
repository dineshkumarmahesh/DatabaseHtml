using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;

using Dapper;
using System.Data.SqlClient;

namespace DataAccessLibrary.Model
{
    public class VechiueModel
    {
        public VechiueModel()
        {
            typeValues = new List<DropdownModel>();
        }
        public int id { get; set; }

        
        public string Name { get; set; }
        public string Number { get; set; }
        public string Insurancenumber { get; set; }
        public string type { get; set; }
        public string Owner { get; set; }
        public List<DropdownModel> typeValues { get; set; }
    }
}
