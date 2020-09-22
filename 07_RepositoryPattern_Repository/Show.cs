using System;
using System.Collections.Generic;
using System.Text;

namespace _07_RepositoryPattern_Repository
{
    public class Show : StreamingContent
    {
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public int AverageRunTime { get; set; }
        public List<Episode> Episodes { get; set; } = new List<Episode>();
    }
    
        public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
  
        
 
}
