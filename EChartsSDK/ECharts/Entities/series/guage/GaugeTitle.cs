﻿using ECharts.Entities.style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class GaugeTitle
    {
        public bool? show { get; set; }
       
        public IList<object> offsetCenter { get; set; }
      
        public TextStyle textStyle { get; set; }
    }
}