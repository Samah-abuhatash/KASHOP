using KASHOP.DAl.Moadels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KASHOP.DAl.DTOS.Response
{
    public  class Responsecategory
    {
        public int Id { get; set; }
        
        public Status status { get; set; }
        
        public  List<Responsetarnslation> translations { get; set; }
    }
}
