/*Author: Bryce Zimmerman
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    /// <summary>
    /// initialize class with ITrie Interface
    /// </summary>
    public class TrieWithNoChildren : ITrie
    {
        /// <summary>
        /// add method
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ITrie Add(string s)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// contains method
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool Contains(string s)
        {
            throw new NotImplementedException();
        }

        private bool hasEmpty = false;

    }
}
