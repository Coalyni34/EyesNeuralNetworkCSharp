using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesNeuralNetwork.NeuranNetworkWorking
{
    public class Neuron
    {
        public decimal Weight { get; set; }
        public byte Value { get; set; }
        public decimal Smoothing { get; set; } = 0.00001m;
        public decimal LastError { get; set; }        
        public byte GetNeuronValue(decimal thresholdValue) 
        {
            if(Weight >= thresholdValue) 
            {
                return Value;
            }
            else
            {
                return 0;
            }
        }
        public decimal ProcessInputData(decimal input) 
        {
            return input * Weight;
        }
        public decimal RestoreInputData(decimal output) 
        {
            return output * Weight;
        }
        public void Train() 
        {

        }
    }
    public class FirstLayerNeuron : Neuron 
    {
    }
    public class SecondLayerNeuron : Neuron 
    {
    }
    public class LastNeuron 
    {
    }
}
