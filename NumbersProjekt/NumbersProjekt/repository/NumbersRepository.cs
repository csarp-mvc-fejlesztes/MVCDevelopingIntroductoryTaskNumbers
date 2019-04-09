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

        /// <summary>
        /// Szám hozzáadása a listához
        /// </summary>
        /// <param name="number">A szám</param>
        public void add(double number)
        {
            numbers.Add(number);
        }

        /// <summary>
        /// Adott sorszámú elem törlése a listában
        /// </summary>
        /// <param name="index">A sorszám</param>
        /// <exception cref="RepositoryException">Adott sorszámú elem nem létezik a listában</exception>
        public void remove(int index)
        {
            try
            {
                numbers.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new RepositoryException(index + " sorszámú elem nem törölhető.\n" + e.Message);
            }
        }

        /// <summary>
        /// Adott sorszámú elem módosítása adott számra
        /// </summary>
        /// <param name="index">A sorszám</param>
        /// <param name="toNumber">Erre a számra módosul</param>
        /// <exception cref="RepositoryException">Adott sorszámú elem nem létezik a listában</exception>
        public void modify(int index, double toNumber)
        {

            try
            {
                numbers[index] = toNumber;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new RepositoryException(index + " sorszámú elem nem törölhető\n" + e.Message);
            }
        }

    }
}
