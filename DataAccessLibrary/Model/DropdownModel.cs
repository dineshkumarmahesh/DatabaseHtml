using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Data.SqlClient;

namespace DataAccessLibrary.Model
{
    public class DropdownModel
    {
        public int vechiuetypeid { get; set; }
        public string type { get; set; }

    }
}
