using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithDocFX
{
    public partial class SecondClass
    {
        #region Variables
        public string SecondVariable = "bonjour";
        private string SecondPrivateVariable = "testing";
        #endregion Variables

        #region Properties
        public string SecondProperty { get; set; }
        private string SecondPrivateProperty { get; set; }
        #endregion Properties

        #region Constructors
        public SecondClass()
        {

        }
        #endregion Constructors

        #region Functions public
        public string GetSecondVariable()
        {
            return SecondVariable;
        }
        #endregion Functions public

        #region Functions private
        private string GetSecondPrivateVariable()
        {
            return SecondPrivateVariable;
        }
        #endregion Function private


    }
}
