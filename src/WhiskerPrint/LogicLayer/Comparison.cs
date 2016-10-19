namespace WhiskerPrint.LogicLayer
{
    public class Comparison
    {
        public Comparison()
        {
        }

        public Comparison(string t, string s, double d)
        {
            id = t;
            name = s;
            score = d;
        }

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        private string id;
        private string name;
        private double score;
    }
}
