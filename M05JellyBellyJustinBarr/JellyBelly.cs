using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace M05JellyBellyJustinBarr
{
    [Table("JellyBellyTable")]
    public class JellyBelly
    {
        //Creates readable and writeable variable for use in database
        [Key]
        public int JellyBellyID { get; set; }

        [StringLength(40)]
        public string jellyBellyFlavor { get; set; }

        [StringLength(60)]
        public string category { get; set; }
    }
}
