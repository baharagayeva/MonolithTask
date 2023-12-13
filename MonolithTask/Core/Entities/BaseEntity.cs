using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /// <summary>
    /// Data table model classes must be inherit from this class
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Unique Identity of Row
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Inserting Date of Row
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Last Modification Date of Row
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }
        /// <summary>
        /// Contains Identificator of Deleted Row ==> Soft Delete
        /// </summary>
        public int Deleted { get; set; }
    }
}
