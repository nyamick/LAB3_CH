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
        public static DIstance operator +(DIstance instance, double number)
        {
            var newValue = instance.value + number;
            var distance = new DIstance(newValue, instance.type);
            return distance;
        }
        public static DIstance operator +(double number, DIstance instance)
        {
            return instance + number;
        }
        public static DIstance operator *(DIstance instance, double number)
        {
            var newValue = instance.value * number;
            var distance = new DIstance(newValue, instance.type);
            return distance;
        }

        public static DIstance operator *(double number, DIstance instance)
        {
            return instance * number;
        }

        public static DIstance operator -(DIstance instance, double number)
        {
            var newValue = instance.value - number;
            var distance = new DIstance(newValue, instance.type);
            return distance;
        }

        public static DIstance operator -(double number, DIstance instance)
        {
            return instance - number;
        }

        public static DIstance operator  /(DIstance instance, double number)
        {
            var newValue = instance.value / number;
            var distance = new DIstance(newValue, instance.type);
            return distance;
        }

        public static DIstance operator /(double number, DIstance instance)
        {
            return instance / number;
        }

        public DIstance To(MeasureType newType)
        {
            var newValue = this.value;
            if (this.type == MeasureType.Ms)
            {
                switch (newType)
                {
                    case MeasureType.Ms:
                        newValue = this.value;
                        break;
                    case MeasureType.KMh:
                        newValue = this.value * 3.6 ;
                        break;
                    case MeasureType.Uz:
                        newValue = this.value / 1.944;
                        break;
                    case MeasureType.Max:
                        newValue = this.value / 333.000333;
                        break;
                }
            }
            else if (newType == MeasureType.Ms) 
            {
                switch (this.type) 
                {
                    case MeasureType.Ms:
                        newValue = this.value;
                        break;
                    case MeasureType.KMh:
                        newValue = this.value / 3.6 ; 
                        break;
                    case MeasureType.Uz:
                        newValue = this.value * 1.944; 
                        break;
                    case MeasureType.Max:
                        newValue = this.value * 333.000333; 
                        break;
                }
            }
            else 
            {
                newValue = this.To(MeasureType.Ms).To(newType).value;
                
            }
            return new DIstance(newValue, newType);
        }
        public static DIstance operator +(DIstance instance1, DIstance instance2)
        { 
            return instance1 + instance2.To(instance1.type).value;
        }

        
        public static DIstance operator -(DIstance instance1, DIstance instance2)
        {
            
            return instance1 - instance2.To(instance1.type).value;
        }
    }
 }

