using System;

namespace ClassLib
{
    public class Episode
    {
        private int Viewers { get; set; }
        private double TotalScore { get; set; }
        private double MaxScore { get; set; }
        
        public Episode()
        {

        }

        public Episode(int views, double totalSc, double maxSc)
        {
            Viewers = views;
            TotalScore = totalSc;
            MaxScore = maxSc;
        }
        
        public void AddView(double rndScore)
        {
            Viewers++;
            TotalScore = TotalScore + rndScore;
            if (MaxScore < rndScore)
            {
                MaxScore = rndScore;
            }
        }

        public double GetMaxScore()
        {
            return MaxScore;
        }

        public double GetAverageScore()
        {
            double avg = TotalScore / Viewers;
            return avg;
        }

        public int GetViewerCount()
        {
            return Viewers;
        }
        
    }
}
