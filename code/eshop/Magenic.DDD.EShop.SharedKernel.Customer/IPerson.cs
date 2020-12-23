using System;
using System.ComponentModel.DataAnnotations;

namespace Magenic.DDD.EShop.SharedKernel.Customer
{
    /// <summary>
    /// Interface: Person
    /// </summary>
    public interface IPerson
    {

        /// <summary>
        /// PK: Person
        /// </summary>
        [Required]
        Guid PersonId { get; set; }

        /// <summary>
        /// E-Mail 
        /// </summary>
        /// <remarks>
        /// Practically the <c>RFC 2821</c> limit of 320 is not generally supported, so <c>254</c> characters is the realistic upper limit
        /// </remarks>
        [Required]
        [EmailAddress]
        [StringLength(maximumLength: 254, MinimumLength = 5)]
        string EMail { get; set; }

        /// <summary>
        /// Phone
        /// <para>
        /// Length 4-32 characters
        /// </para>
        /// <para>
        /// Regex:
        /// <code>
        ///  Beginning of line or string
        ///  Match if suffix is absent. [0+$]
        ///      0+$
        ///          0, one or more repetitions
        ///          End of line or string
        ///  [1]: A numbered capture group. [\\+\\d{1,3}[- ]?], zero or one repetitions
        ///      \\+\\d{1,3}[- ]?
        ///          Literal \, one or more repetitions
        ///          Literal \
        ///          d, between 1 and 3 repetitions
        ///          Any character in this class: [- ], zero or one repetitions
        ///  Match if suffix is absent. [0+$]
        ///      0+$
        ///          0, one or more repetitions
        ///          End of line or string
        ///  \\d{10,15}$
        ///      Literal \
        ///      d, between 10 and 15 repetitions
        ///      End of line or string
        /// </code>
        /// </para>
        /// </summary>
        [Required]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Phone Incorrect Format")]
        [StringLength(maximumLength: 32, MinimumLength = 4)]
        string Phone { get; set; }

    }
}
