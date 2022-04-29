using StudentDataCreation.Core.IRepository;
using StudentDataCreation.Core.IServices;
using StudentDataCreation.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCreation.Services.Services
{
   public class StudentsServices  : IServices
    {
        #region Decleartion
        private readonly IRepository _Inrepository;
        #endregion
        #region Con_
        public StudentsServices(IRepository Insertrepository)
        {
            this._Inrepository = Insertrepository;
        }

        public void InsertEmpDetails(StudentDataModel studentDataModel)
        {
            _Inrepository.InsertEmpDetails(studentDataModel);
        }
        #endregion

        /*      public class Service
              {
                  IRepository _repository;

                  public Service(IRepository repository)
                  {
                      _repository = repository;
                  }
                  public void saveOrEditStudents(StudentDataModel model)
                  {
                      _repository.saveOrEditStudents(model);

                  }
                  public void DeleteStudents(int? id)
                  {
                      _repository.DeleteStudents(id);
                  }
                  public List<StudentDataModel> listStudents()
                  {
                      return _repository.listStudents();
                  }
                  public StudentDataModel DeleteOrEdit(int id)
                  {
                      return _repository.DeleteOrEdit(id);
                  }


              }*/
        public void InsertStdInfoData(StudentDataModel stdInfoData)
        {
            _Inrepository.InsertEmpDetails(stdInfoData);
        }
        public List<StudentDataModel> listStudents()
        {
            return _Inrepository.listStudents();
        }

        /*        public List<StudentDataModel> listStudents()
                {
                    return _Inrepository.listStudents();
                }
                public StudentDataModel DeleteOrEdit(int id)
                {
                    return _Inrepository.DeleteOrEdit(id);
                }
                public void DeleteStudents(int? id)
                {
                    _Inrepository.DeleteStudents(id);
                }
                public void saveOrEditStudents(StudentDataModel model)
                {
                    _Inrepository.saveOrEditStudents(model);
                }*/
    }


}