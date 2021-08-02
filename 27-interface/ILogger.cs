using System;

namespace _27_interface
{
    public interface ILogger
    {
        //  we shouldn't use access modifers in interface (public,private,protected)
        //  they don't have constructors
        //  Objects cannot be created from interfaces

        void  WriteLog();
    }
}