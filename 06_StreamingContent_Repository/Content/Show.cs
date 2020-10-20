using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Repository.Content
{
    public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public int EpisodeCount {
            get
            {
                return Episodes.Count();
            }
        }
        public double AverageRunTime { get; set; }
    }


    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
        public Episode() { }
        public Episode(string title, double runTime, int season)
        {
            Title = title;
            RunTime = runTime;
            SeasonNumber = season;
        }
    }

    //public Show(string title, string description, double starRating, Genre genre, MaturityRating maturityRating, )
}
