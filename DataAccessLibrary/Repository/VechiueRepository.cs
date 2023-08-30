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
    public class VechiueRepository
    {
        public readonly string connectionString;
        
        public VechiueRepository()
        {
            connectionString = @"Data Source=DESKTOP-18UQSSV;Initial Catalog=vechiue information;User id=sa;Password=Anaiyaan@123";
        }
        public void InsertSP(VechiueModel a)
        {
            try
            {

                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec insertvechiue '{a.Name}','{a.Number}','{a.Insurancenumber}','{a.type}','{a.Owner}'"); 

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
        public List<VechiueModel> SelectSP()

        {
            try
            {
                List<VechiueModel> constrain = new List<VechiueModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<VechiueModel>("exec selectvechiue", connectionString).ToList();
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
        public VechiueModel SelectSP(int id)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var constrain = connection.QueryFirst<VechiueModel>($"exec vechiueGetbyid {id}");
            connection.Close();

            return constrain;

        }



        public void updateSP(VechiueModel u)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec updatevechiue '{u.id}','{u.Name}',{u.Number},{u.Insurancenumber},'{u.type}','{u.Owner}'");               

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




        public void deleteSP(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"exec deletevechiue {id}");


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
