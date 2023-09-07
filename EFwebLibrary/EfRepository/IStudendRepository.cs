
using EFwebLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library.EfRepository
{
   public interface IStudendRepository
    {
        public List<EFmodel> GetAllRegistration();
        

        public EFmodel GetRegistrationById(int empId);
       

        public void Insert(EFmodel data);
      

        public void Update(EFmodel data);
       

        public void Delete(int empId);
      
    }
}
