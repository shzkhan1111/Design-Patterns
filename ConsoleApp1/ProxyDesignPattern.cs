using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Proxy Controlling Access to an object ,
    /// Decorator : Injecting Functionality
    /// 
    /// Proxy we dont put the thing inside of it
    /// Proxy Control Access to the thing
    /// it hides iit  
    /// //infrastructure model
    /// With Proxy it is a compile time decision 
    /// </summary>
    public class ProxyDesignPattern
    {

    }
    public interface AbstractionProxy { }
    public class Concretion : AbstractionProxy { }

    public class ConcretionProxy : AbstractionProxy
    {
        Concretion concretion = new Concretion();
    }
    public class ConcretionDecorator : AbstractionProxy
    {
        AbstractionProxy _abstractionProxy;
        public ConcretionDecorator(AbstractionProxy abstractionProxy)
        {
            _abstractionProxy = abstractionProxy;
        }
    }
}
