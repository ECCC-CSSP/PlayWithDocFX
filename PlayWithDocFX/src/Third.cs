using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithDocFX
{
    public partial class ThirdClass
    {
        #region Variables
        public string ThirdVariable = "bonjour";
        private string ThirdPrivateVariable = "testing";
        #endregion Variables

        #region Properties
        /// <summary>
        /// This is the summary
        /// </summary>
        /// <param name="ThirdProperty">This is the Third Property</param>
        public string ThirdProperty { get; set; }
        private string ThirdPrivateProperty { get; set; }
        public SecondClass secondClass { get; set; }
        public FirstClass firstClass { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        ///  this is the constructor
        /// </summary>
        /// <remarks>bonjour remarks</remarks>
        public ThirdClass()
        {
            secondClass = new SecondClass();
            firstClass = new FirstClass();
        }
        #endregion Constructors

        #region Functions public
        /// <summary>
        /// aaaaaaaaaaaaaaaaaaaaaa
        /// </summary>
        /// <param name="slifj">bbbbbbbbbbbbbb</param>
        /// <param name="sc">ccccccccccccccccccc</param>
        /// <param name="sleifjijf">dddddddddddddddd</param>
        /// <returns>Retuns this</returns>
        public string GetThirdVariable(int slifj, SecondClass sc, string sleifjijf)
        {
            return ThirdVariable;
        }
        #endregion Functions public

        #region Functions private
        private string GetThirdPrivateVariable(int slifj, SecondClass sc, string sleifjijf)
        {
            return ThirdPrivateVariable;
        }
        #endregion Function private


    }
}
