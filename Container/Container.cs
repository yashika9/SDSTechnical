using System;
using System.Reflection;

namespace DeveloperSample.Container
{
    public class Container
    {
        InterfaceMapping GetInterfaceMap;
        public void Bind(Type interfaceType, Type implementationType)
        {
            GetInterfaceMap =  implementationType.GetInterfaceMap(interfaceType);
        }
        public T Get<T>() 
        {
            return (T)Activator.CreateInstance(GetInterfaceMap.TargetType);
        }
    }
}