using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;

using Dapper;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLibrary.Model
{
    public class VechiueModel
    {
        public VechiueModel()
        {
            typeValues = new List<DropdownModel>();
        }
       
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Insurancenumber { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string Owner { get; set; }
        public List<DropdownModel> typeValues { get; set; }
    }
}
