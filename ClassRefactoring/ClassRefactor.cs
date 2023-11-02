using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {

            Dictionary<(SwallowType, SwallowLoad), double> dict = new Dictionary<(SwallowType, SwallowLoad), double>();

            dict.Add((SwallowType.African, SwallowLoad.None), 22);
            dict.Add((SwallowType.African, SwallowLoad.Coconut), 18);
            dict.Add((SwallowType.European, SwallowLoad.None), 20);
            dict.Add((SwallowType.European, SwallowLoad.Coconut), 16);

            if (dict.TryGetValue((Type, Load), out double vel))
            {
                return vel;
            }
            throw new InvalidOperationException();
        }
    }
}