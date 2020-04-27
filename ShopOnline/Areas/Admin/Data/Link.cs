namespace ShopOnline.Areas.Admin.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Link")]
    public partial class Link
    {
        public int LinkID { get; set; }

        [StringLength(50)]
        public string LinkName { get; set; }

        [StringLength(50)]
        public string LinkURL { get; set; }

        [StringLength(10)]
        public string LinkDescription { get; set; }

        public int? CategoryID { get; set; }
    }
}
