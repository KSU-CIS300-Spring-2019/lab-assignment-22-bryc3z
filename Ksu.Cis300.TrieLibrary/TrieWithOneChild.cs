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
    /// TrieWithOneChild class with ITrie Interface implimented
    /// </summary>
    public class TrieWithOneChild : ITrie
    {
        public TrieWithOneChild(string s, bool empty)
        {
            if (s == "" || (s[0]-'a' < 'a' || s[0]-'a' > 'z'))
            {
                throw new ArgumentException();
            }
            hasempty = empty;
            childLabel = s[0];
            //what is this doing?
            onlyChild = new TrieWithNoChildren(s.Substring[1]);
        }

        /// <summary>
        /// field indicating if string is empty
        /// </summary>
        /// 
        private bool hasempty;
        /// <summary>
        /// field of ITrie with the child
        /// </summary>
        private ITrie onlyChild;

        /// <summary>
        /// fild of char for lable
        /// </summary>
        private char childLabel;

        /// <summary>
        /// adds string
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

    }
}
