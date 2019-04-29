using MVCBevezetoListString.repository;
using MVCBevezetoListString.validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBevezetoListString.controller
{
    class ControllerStudentID
    {
        private RepositoryStudentID repo;

        public void add(string studendId)
        {
            try
            {
                StudentIdValidation sv;
                sv = new StudentIdValidation(studendId);
                sv.validation();
            }
            catch(StudentIdValidationException sve)
            {}
            catch(Exception e)
            {}
        }
    }
}
