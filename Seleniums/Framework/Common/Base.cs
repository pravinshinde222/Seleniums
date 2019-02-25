using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Seleniums.Framework.Common
{
    public class Base
    {
        public Helper _helper;
        public IWebDriver driver;
        public Wait wait;
        public Base()
        {
            
            _helper=new Helper();
            
        }
    }
}
