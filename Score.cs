using System;

namespace Vesuvius
{
    public class Score
    {
        public Score() {
            score = 0;
            name = "";    
        }

        public Score( int score, string name ) {
            this.score = score;
            this.name = name;
        }

        public int score { get; set;}

        public string name { get; set; }
        
        public static Score operator ++( Score s ) {
            s.score++;
            return s;
        }

        public static Score operator --( Score s ) {
            s.score--;
            return s;
        }
    }
}



