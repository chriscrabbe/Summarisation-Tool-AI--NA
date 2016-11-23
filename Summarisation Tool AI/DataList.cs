using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarisation_Tool_AI
{
    public abstract class DataList
    {
        protected string dataIn;
        public string DataIn
        {
            get { return dataIn; }
            set { dataIn = value; }
        }
    }
    public class WeightData : DataList
    {
        protected int weight;
        public int Weight
        {
            get { return weight;  }
            set { weight = value; }
        }
    }
    public class RankData : DataList
    {
        protected int occurance;
        protected int weightValue;
        public int Occurance
        {
            get { return occurance;  }
            set { occurance = value; }
        }
        public int WeightValue
        {
            get { return weightValue;  }
            set { weightValue = value; }
        }
    }
}
