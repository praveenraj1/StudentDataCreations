using StudentDataCreation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCreation.Core.IServices
{
   public interface IServices
    {
        /*        void saveOrEditStudents(StudentDataModel model);
                StudentDataModel DeleteOrEdit(int id);
                void DeleteStudents(int? id);
                List<StudentDataModel> listStudents();*/
        void InsertEmpDetails(StudentDataModel studentDataModel);
        List<StudentDataModel> listStudents();
    }
}
