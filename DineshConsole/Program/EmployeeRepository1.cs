using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DineshConsole

{
    public class propertiesandDestroctor
    {
        public int Empid { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }


    }
    public class EmployeeRepository1

    {
        public readonly string conectionstring;
        public EmployeeRepository1()
        {
            conectionstring = @"Data source=DESKTOP-18UQSSV;Initial catalog=SQL ;User Id=sa;Password=Anaiyaan@123";
        }

        public propertiesandDestroctor modelInfo()
        {

            propertiesandDestroctor S = new propertiesandDestroctor();

            Console.WriteLine("Enter  Empid");
            S.Empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  Firstname");
            S.Firstname = Console.ReadLine();

            Console.WriteLine("Enter  Lastname");
            S.Lastname = Console.ReadLine();


            Console.WriteLine("Enter email");
            S.Email = Console.ReadLine();
            return S;
        }


        public void Insert(propertiesandDestroctor a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"insert into StudentInformation  (empid,Firstname,Lastname,Email) values('{a.Empid}','{a.Firstname}','{a.Lastname}','{a.Email}')");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(propertiesandDestroctor a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);
                Console.WriteLine("Enter the  empid for which one you want to Update Records");
                var update = Console.ReadLine();

                con.Open();

                con.Execute($"update StudentInformation set empid='{a.Empid}',Firstname= '{a.Firstname}', lastname='{a.Lastname}',Email='{a.Email}' where empid='{update}' ");

                con.Close();
            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete()
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("enter the delete records");
                var del = Convert.ToInt32(Console.ReadLine());


                con.Open();

                con.Execute($"delete from StudentInformation where empid = '{del}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CRUD_Operation()
        {

            int b;
            do
            {
                Console.WriteLine("Choose the option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.update");
                Console.WriteLine("3.delete");



                b = Convert.ToInt32(Console.ReadLine());
                EmployeeRepository1 objadd = new EmployeeRepository1();


                switch (b)
                {
                    case 1:
                        EmployeeRepository1 obj = new EmployeeRepository1();
                        var Add = obj.modelInfo();
                        objadd.Insert(Add);

                        break;
                    case 2:
                        EmployeeRepository1 obj1 = new EmployeeRepository1();
                        var update = obj1.modelInfo();
                        objadd.Update(update);

                        break;

                    case 3:
                        EmployeeRepository1 obj2 = new EmployeeRepository1();

                        obj2.Delete();

                        break;

                    default:
                        Console.WriteLine("Please give a valid OPtion");
                        break;

                }

            } while (b != 0);
            Console.ReadLine();
        }
        public void InsertSP(propertiesandDestroctor a)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec InsertStudentInformation  '{a.Empid}',{a.Firstname},'{a.Lastname}','{a.Email}'");

                //con.Execute($"insert into stubio(FirstName,LastName,Age,Email,Gender) values('{a.FirstName}', '{a.LastName}','{a.age}','{a.email}','{a.gender}')");


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



        public List<propertiesandDestroctor> SelectSP()

        {
            try
            {
                List<propertiesandDestroctor> constrain = new List<propertiesandDestroctor>();

                var connection = new SqlConnection(conectionstring);
                connection.Open();
                constrain = connection.Query<propertiesandDestroctor>("  exec StudentInformation; ", conectionstring).ToList();
                connection.Close();


                //foreach (var constrai in constrain)
                //{

                //    Console.WriteLine($"Empid--{constrai.Empid}   Firstname--{constrai.Firstname}   Lastname--{constrai.Lastname}   Email--{constrai.Email} ");
                //    Console.WriteLine("-------------------------------------------------------------------------------");
                //}




                /*Console.WriteLine(constrain);
                Console.ReadLine();*/

                return constrain;


            }
            catch (Exception ex)
            {
                throw ex;
            }



        }



        public void updateSP()
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("Enter A Email to alter");
                string Email = Console.ReadLine();

                Console.WriteLine("Enter A FirstName to alter the Email");
                string Empid = Console.ReadLine();

                con.Open();
                con.Execute($"  exec UpdateStudentInformation '{Email}','{Empid}' ");

                // con.Execute($"  update stubio set FirstName ='{fastn}' where LastName='{lastn}' ");


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
                SqlConnection con = new SqlConnection(conectionstring);

                Console.WriteLine("enter a Epmid  to delete record");
                string del = Console.ReadLine();
                con.Open();
                con.Execute($"EXEC DeleteStudentInformation '{del}'");


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















