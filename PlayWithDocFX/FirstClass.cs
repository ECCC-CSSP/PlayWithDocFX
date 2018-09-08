using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithDocFX
{
    public partial class FirstClass
    {
        #region Variables
        public string FirstVariable = "bonjour";
        private string FirstPrivateVariable = "testing";
        #endregion Variables

        #region Properties
        public string FirstProperty { get; set; }
        private string FirstPrivateProperty { get; set; }
        public SecondClass secondClass { get; set; }
        #endregion Properties

        #region Constructors
        public FirstClass()
        {
            secondClass = new SecondClass();
        }
        #endregion Constructors

        #region Functions public
        public string GetFirstVariable()
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
