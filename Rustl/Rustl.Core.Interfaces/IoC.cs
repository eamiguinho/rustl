using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleInjector;

namespace Rustl.Core.Interfaces
{
    public class IoC
    {
        private static Container _container;
        public static Container Container { get { return _container ?? (_container = new Container()); } }

    }
}
