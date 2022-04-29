using StudentDataCreation.Core.IRepository;
using StudentDataCreation.Core.Model;
using StudentDataCreation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCraetion.Repository.Repository
{

    public class StudentsRepository : IRepository
    {
        public void InsertEmpDetails(StudentDataModel studentDataModel)
        {
            if (studentDataModel != null)
            {
                using (var entity = new FRESHER2022Context())
                {
                    StudentDataCreationS entityclass = new StudentDataCreationS();
                    entityclass.StudentFirstName = studentDataModel.StudentFirstName;
                    entityclass.StudentSecondName = studentDataModel.StudentSecondName;
                    entityclass.Department = studentDataModel.Department;
                    entityclass.Gender = studentDataModel.Gender;
                    entityclass.JoiningDate = studentDataModel.JoiningDate;
                    entityclass.Create_Time_Stamp = DateTime.Now;
                    entityclass.Update_Time_Stamp = DateTime.Now;
                    entityclass.IS_Deleted = false;
                    entity.StudentDataCreationS.Add(entityclass);
                    entity.SaveChanges();
                }
            }

        }
        public List<StudentDataModel> listStudents()
        {
            List<StudentDataModel> studentmodelList = new List<StudentDataModel>();
            using (var entities = new FRESHER2022Context())
            {
                var dbstudent = entities.StudentDataCreationS.Where(x => x.IS_Deleted == false).ToList();

                if (dbstudent != null)
                {
                    foreach (var item in dbstudent)
                    {
                        StudentDataModel stu = new StudentDataModel();
                        stu.StudentID = item.StudentID;
                        stu.StudentFirstName = item.StudentFirstName;
                        stu.StudentSecondName = item.StudentSecondName;
                        stu.Department = item.Department;
                        stu.Gender = item.Gender;
                        stu.JoiningDate = item.JoiningDate;
                        studentmodelList.Add(stu);
                    }
                }
                return studentmodelList;
            }


            /*            public void saveOrEditStudents(StudentDataModel model)
                        {
                        StudentDataCreationS students = new StudentDataCreationS();
                            if (model != null)
                            {
                                using (var entities = new FRESHER2022Context())
                                {
                                    var dbstuden = entities.StudentDataCreationS.Where(x => x.StudentID == model.StudentID).SingleOrDefault();
                                    if (dbstuden == null)
                                    {
                                        students.StudentFirstName = model.StudentFirstName;
                                        students.StudentSecondName = model.StudentSecondName;
                                        students.Department = model.Department;
                                        students.Gender = model.Gender;
                                        students.JoiningDate = model.JoiningDate;
                                        entities.StudentDataCreationS.Add(students);
                                    }
                                    else
                                    {
                                        dbstuden.StudentFirstName = model.StudentFirstName;
                                        dbstuden.StudentSecondName = model.StudentSecondName;
                                        dbstuden.Department = model.Department;
                                        dbstuden.Gender = model.Gender;
                                        dbstuden.JoiningDate = model.JoiningDate;
                                        entities.StudentDataCreationS.Update(dbstuden);
                                    }
                                    entities.SaveChanges();
                                }
                            }
                        }
                        public StudentDataModel DeleteOrEdit(int id)
                        {
                        StudentDataModel model = new StudentDataModel();
                            using (var entities = new FRESHER2022Context())
                            {
                                var dbstudent = entities.StudentDataCreationS.Find(id);
                                model.StudentID = dbstudent.StudentID;
                                model.StudentFirstName = dbstudent.StudentFirstName;
                                model.StudentSecondName = dbstudent.StudentSecondName;
                                model.Gender = dbstudent.Gender;
                                model.Department = dbstudent.Department;
                                model.JoiningDate = dbstudent.JoiningDate;
                                entities.SaveChanges();
                            }
                            return model;
                        }
                        public void DeleteStudents(int? id)
                        {
                            if (id.HasValue)
                            {
                                using (var entities = new FRESHER2022Context())
                                {
                                    var dbstudent = entities.StudentDataCreationS.Where(x => x.StudentID == id).SingleOrDefault();

                                    dbstudent.IS_Deleted = true;
                                    entities.SaveChanges();
                                }
                            }
                        }

                        }*/
        }
    }
}



