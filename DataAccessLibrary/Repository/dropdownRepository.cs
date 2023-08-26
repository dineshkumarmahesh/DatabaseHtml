using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Model;
using Dapper;
using System.Data.SqlClient;


namespace DataAccessLibrary.Repository
{
  public  class dropdownRepository
    {
        public readonly string connectionString;
        
        
        public dropdownRepository()
        {
            connectionString = @"Data Source=DESKTOP-18UQSSV;Initial Catalog=vechiue information;User id=sa;Password=Anaiyaan@123";
        }
        public void InsertSP(DropdownModel a)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec insertvechiue '{a.type}',");

                con.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<DropdownModel> SelectSP()

        {
            try
            {
                List<DropdownModel> constrain = new List<DropdownModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<DropdownModel>("exec selectvechiueid 3", connectionString).ToList();
                connection.Close();

                return constrain;

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DropdownModel SelectSP(string type)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var constrain = connection.QueryFirst<DropdownModel>($"exec DropdownModel {type} ", connectionString);
            connection.Close();

            return constrain;

        }



        public void updateSP(DropdownModel u)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"updatevechiuetype 2,'car'");



                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




        public void deleteSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec deletevechiuetype 2");


                con.Close();
            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
