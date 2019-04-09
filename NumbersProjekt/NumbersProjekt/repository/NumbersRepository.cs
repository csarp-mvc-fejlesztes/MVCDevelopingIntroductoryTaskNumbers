using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersProjekt.repository
{
    class NumbersRepository
    {
        private List<double> numbers;

        /// <summary>
        /// Konstruktorban példányosítás
        /// </summary>
        public NumbersRepository()
        {
            numbers = new List<double>();
        }

        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Számok listája</returns>
        public List<double> getNumbers()
        {
            return numbers;
        }
    }
}
