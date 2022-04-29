using StudentDataCreation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCreation.Core.IRepository
{
   public interface IRepository 
    {
        void InsertEmpDetails(StudentDataModel studentDataModel);
        List<StudentDataModel> listStudents();
        /*        void saveOrEditStudents(StudentDataModel studentDataModel);
                StudentDataModel DeleteOrEdit(int id);
                void DeleteStudents(int? id);
                List<StudentDataModel> listStudents();*/


    }
}
