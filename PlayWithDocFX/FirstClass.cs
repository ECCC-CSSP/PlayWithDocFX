using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithDocFX
{
    /// <summary>
    /// This is the first class summary
    /// </summary>
    public partial class FirstClass
    {
        #region Variables
        /// <summary>
        /// This is teh first variable which starts with "bonjour"
        /// </summary>
        public string FirstVariable = "bonjour";
        private string FirstPrivateVariable = "testing";
        #endregion Variables

        #region Properties
        public string FirstProperty { get; set; }
        private string FirstPrivateProperty { get; set; }
        public SecondClass secondClass { get; set; }
        #endregion Properties

        #region Constructors
        /// <summary>
        /// This is the first class constructor
        /// </summary>
        public FirstClass()
        {
            secondClass = new SecondClass();
        }
        /// <summary>
        /// This is the FirstClass constructor
        /// </summary>
        /// <param name="FirstPrivateProperty">The value of the first property</param>
        public FirstClass(string FirstPrivateProperty)
        {
            this.FirstPrivateProperty = FirstPrivateProperty;
            secondClass = new SecondClass();
        }
        #endregion Constructors

        #region Functions public
        /// <summary>
        /// this is the function summary
        /// </summary>
        /// <param name="Bon">The bon parameter</param>
        /// <param name="numb">Ths numb parameter</param>
        /// <param name="secondClass">And finaly the [SectondClass](PlayWithDocFX.SecondClass.html) Param</param>
        /// <returns>The return is important</returns>
        public string GetFirstVariable(string Bon, int numb, SecondClass secondClass)
        {
            return FirstVariable;
        }
        #endregion Functions public

        #region Functions private
        private string GetFirstPrivateVariable()
        {
            return FirstPrivateVariable;
        }
        #endregion Function private


    }
}
