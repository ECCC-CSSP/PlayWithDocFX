using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// > [!NOTE]
/// > allo namespace
/// </summary>
namespace PlayWithDocFX.src
{
    /// <summary>
    /// ## testing ##
    /// * * *
    /// <code>
    /// &lt;div class="test"&gt;
    ///     &lt;span&gt;rouge&lt;/span&gt;
    /// &lt;/div&gt;
    /// </code>
    /// </summary>

    public partial class FirstClass
    {


        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Address ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Address ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the Addresses table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table Adresses")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Address ID
        /// 
        /// **Display (fr)** --- Address ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the Addresses table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table Adresses
        /// </returns>
        public int AddressID { get; set; }
        /// <returns>
        /// This is my property
        /// 
        /// This is a regular paragraph.
        /// 
        /// <table>
        ///     <tr>
        ///         <td>Foo</td>
        ///     </tr>
        ///  </table>
        ///
        /// This is another regular paragraph.
        /// </returns>
        public int MyProperty { get; set; }
        /// <returns>
        /// This is my property
        /// 
        /// **Display (en)** -- First Name
        /// 
        /// **Display (fr)** -- Prénom
        /// 
        /// </returns>
        public string propStr { get; set; }

        /// <summary>
        /// > [!NOTE]
        /// > testing
        /// </summary>
        public FirstClass()
        {

        }

        /// <summary>
        /// > [!NOTE]
        /// Gets the string
        /// </summary>
        /// <param name="bon">aaaaaa</param>
        /// <param name="allo">nnnnnn</param>
        /// <param name="lsiefj">ddddddddd</param>
        /// <remarks>
        /// <code>
        /// thisis lsefj lsiefj 
        /// </code>
        /// this is remarks
        /// </remarks>
        /// <returns>
        /// returens a string asfljief
        /// </returns>
        public string GetStr(string bon, string allo, int lsiefj)
        {
            return "";
        }

        /// <summary>
        /// > [!NOTE]
        /// > 
        /// > <para>**Return to some link**</para>
        /// * aslefj
        /// * selfij    
        /// * lsjfeilelsfj
        /// </summary>
        /// <remarks>
        /// <code>
        ///     public enum ActionDBTypeEnum
        ///     {
        ///         Create = 1,
        ///         Read = 2,
        ///         Update = 3,
        ///         Delete = 4,
        ///     }
        /// </code>
        /// </remarks>
        public enum ActionDBTypeEnum
        {
            /// <summary>
            /// 1 -- en [Create] ---- fr [Créer]
            /// </summary>
            Create = 1,
            /// <summary>
            /// 2 -- en [Read] ---- fr [Lire]
            /// </summary>
            Read = 2,
            /// <summary>
            /// 3 -- en [Update] ---- fr [Mettre à jour]
            /// </summary>
            Update = 3,
            /// <summary>
            /// 4 -- en [Delete] ---- fr [Effacer]
            /// </summary>
            Delete = 4,
        }
    }
}
