using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSEFTPC4Core3Objects.Ac4yObjects
{
    public partial class Ac4yPersistent : Ac4y
    {
        [Key]
        public int persistentChildId { get; set; }
        public string id { get; set; }
        public string guid { get; set; }
        public string owner { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }
}
