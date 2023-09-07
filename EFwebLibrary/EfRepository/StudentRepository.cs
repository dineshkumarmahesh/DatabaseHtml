using EFwebLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EF_Library.EfRepository
{
    public class StudentRepository : IStudendRepository
    {

        private readonly context _context;


        public StudentRepository(context con)
        {
            _context = con;
        }

        public void Delete(int empId)
        {
            try
            {
                var tobeDeleted = GetRegistrationById(empId);
                _context.Remove<EFmodel>(tobeDeleted);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        public List<EFmodel> GetAllRegistration()
        {
            try
            {
                var lst = _context.Set<EFmodel>().ToList();

                return lst;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

         
        public EFmodel GetRegistrationById(int empId)
        {
            try
            {
                var reg = _context.Find<EFmodel>(empId);

                return reg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        public void Insert(EFmodel data)
        {
            try
            {
                _context.Add<EFmodel>(data);
                _context.SaveChanges();
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

     

        public void Update(EFmodel data)
        {
            try
            {
                //var tobeDeleted = GetRegistrationById(empId);
                _context.Update<EFmodel>(data);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

   
    }
}