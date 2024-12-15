using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Pattern
{
    internal class StudentController
    {
        private Student _model;
        private StudentViewer _view;
        public StudentController(Student model, StudentViewer view)
        {
            _model = model;
            _view = view;
        }
        public void SetStudentId(int ID)
        {
            _model.Id = ID;
        }
        public int GetStudentId()
        {
            return _model.Id;
        }
        public void SetStudentName(string Name)
        {
            _model.Name = Name;
        }
        public string GetStudentName()
        {
            return _model.Name;
        }
        public void SetStudentGrade(double Grade)
        {
            _model.Grade = Grade;
        }
        public double GetStudentGrade()
        {
            return _model.Grade;
        }
        public void UpdateView()
        {
            _view.DisplayStudentDetails(_model.Id, _model.Name, _model.Grade);
        }
    }
}
