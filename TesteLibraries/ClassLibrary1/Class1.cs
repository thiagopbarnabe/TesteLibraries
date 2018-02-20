using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Class1
    {
        public static void teste()
        {


            //var start = new StartOptions {
            //    ServerFactory=
            //};
            Trace.TraceInformation(typeof(Microsoft.Owin.Host.HttpListener.OwinHttpListener).FullName);
            WebApp.Start<Class2>("http://localhost:8124");
        }
        
    }
}
