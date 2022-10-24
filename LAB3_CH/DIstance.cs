using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_CH
{
    public enum MeasureType { Ms, KMh, Uz, Max };
    public class DIstance
    {
        private double value;
        private MeasureType type;

        public DIstance(double value, MeasureType type) 
        {
            this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.Ms:
                    typeVerbose = "м/с";
                    break;
                case MeasureType.KMh:
                    typeVerbose = "км/ч";
                    break;
                case MeasureType.Uz:
                    typeVerbose = "узлов";
                    break;
                case MeasureType.Max:
                    typeVerbose = "Max";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
    }
}
