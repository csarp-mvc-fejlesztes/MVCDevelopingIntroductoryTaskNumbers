using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBevezetoListString.validation
{
    class StudentIdValidation
    {
        private string studentID;

        public StudentIdValidation(string studentID)
        {
            this.studentID = studentID;
        }

        public void validation()
        {
            if (testStudendIdIsWrong())
                throw new StudentIdValidationException(
                    "Rossz a diak azonosító!");
        }

        /// <summary>
        /// Teszteli a studend ID-t
        /// </summary>
        /// <returns>true, ha a student ID rossz</returns>
        private bool testStudendIdIsWrong()
        {
            
        }
    }
}
