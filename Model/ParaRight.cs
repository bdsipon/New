﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class ParaRight
    {
        [Key]
        public int ParaId { get; set; }
        public string ParaText { get; set; }      
    }

    public class PostParaRight
    {        
        public string ParaText { get; set; }
        public int[] paraIds { get; set; }
    }
}
