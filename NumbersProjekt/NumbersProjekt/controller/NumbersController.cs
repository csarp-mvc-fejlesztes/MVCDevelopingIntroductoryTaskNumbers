using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumbersProjekt.repository;

namespace NumbersProjekt.controller
{
    /// <summary>
    /// Feladata:
    ///  - az adattárban lévő adatok elérése, kezelése
    ///  - az outputra szánt adatok átalakítása a megfeleő formátumba
    ///  - input adatok ellenörzése
    ///  - hibaüzenetek megjelenítése a logba vagy a felhasználó felé (kivételdobás)
    /// </summary>
    class NumbersController
    {
        private NumbersRepository nr;

        public NumbersController()
        {
            nr = new NumbersRepository();
        }

        /// <summary>
        /// Output átalakítás:
        ///  - eröltetett példa, a számok listájából stringek listáját készíti el
        ///  - bemutatja a példa az outputra szánt átalakításokat
        /// </summary>
        /// <returns>Számok listája</returns>
        public List<string> getNumbers()
        {
            List<double> numbers = nr.getNumbers();
            List<string> numbersString = new List<string>();
            foreach (double number in numbers)
            {
                numbersString.Add(number.ToString());
            }
            return numbersString;
        }
        
        /// <summary>
        /// Input átalakítások:
        /// A viewn megadott szöveget számmá konvertálja és a reposiotry segitségével eltárolja
        /// </summary>
        /// <param name="numberText">A felhasználó által megadott szám</param>
        public void addNumber(string numberText)
        {
            double number = 0;
            number = Convert.ToDouble(numberText);
            nr.add(number);
        }

        /// <summary>
        /// A viewn megadott módosított értéket számma konvertálja és a repository segítségével módosítja
        /// az indexedit elemet az új számra
        /// </summary>
        /// <param name="index">A sorszám, amely megadja, hogy hanyadik elemet kell változtatni</param>
        /// <param name="numberText">A módosított szám új értéke</param>
        public void modifyNumber(int index, string numberText)
        {
            double number = 0;
            number = Convert.ToDouble(numberText);
            nr.modify(index, number);
        }

        /// <summary>
        /// Indexedit elem törlése a repository segítségével
        /// </summary>
        /// <param name="index">Annak az elemnek a sorszáma a melyet törölni kell</param>
        public void deleteNumber(int index)
        {
            nr.remove(index);
        }
    }
}
