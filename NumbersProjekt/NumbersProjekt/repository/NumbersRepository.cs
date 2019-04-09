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
        public void remove(int index)
        {
            numbers.RemoveAt(index);
        }

        /// <summary>
        /// Adott sorszámú elem módosítása adott számra
        /// </summary>
        /// <param name="index">A sorszám</param>
        /// <param name="toNumber">Erre a számra módosul</param>
        public void modify(int index, double toNumber)
        {
            numbers[index] = toNumber;
        }

    }
}
