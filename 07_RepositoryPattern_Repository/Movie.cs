﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public Movie() { }
        public Movie(string title, string description, float starRating, MaturityRating mRating, bool isFamFriendly, GenreType tOG, double runTime)
            : base(title, description, starRating, mRating, isFamFriendly, tOG)
        {
            RunTime = runTime;
        }




    }
}
//instead of rewriting all values we can put all into base constructor to assign
//everytime we new up movie, will call on base constructor to utilize overloaded 
