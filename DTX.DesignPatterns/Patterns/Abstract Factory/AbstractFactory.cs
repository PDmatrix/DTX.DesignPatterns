using System.Collections.Generic;
using DTX.DesignPatterns.Definition.PatternTypes;

namespace DTX.DesignPatterns.Patterns.Abstract_Factory
{
    public class AbstractFactory : CreationalPattern
    {
        public AbstractFactory(IDictionary<string, string> args)
        {
            
        }

        public override void Excecute()
        {
            throw new System.NotImplementedException();
        }

        public override string Description()
        {
            throw new System.NotImplementedException();
        }
    }
}