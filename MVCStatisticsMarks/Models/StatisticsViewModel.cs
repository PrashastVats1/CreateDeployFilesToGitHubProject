using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStatisticsMarks.Models
{
    public class StatisticsViewModel
    {
        public double AverageScore { get; set; }
        public double HighestScore { get; set; }
        public double LowestScore { get; set; }
    }
}