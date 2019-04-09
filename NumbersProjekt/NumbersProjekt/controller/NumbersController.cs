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
        ///  - bemutatja a példa az output szánt átalakítást
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
    }
}
