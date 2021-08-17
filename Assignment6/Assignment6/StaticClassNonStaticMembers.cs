using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{

    /// <summary>
    /// Observation on adding non-static members in static class:
    /// 1. Static class cannot have non-static or instance members such as methods and variables
    /// 2. Constructor of static class must be static.
    /// 3. We cannot create instance of static class.
    /// </summary>
    public static class StaticClassNonStaticMembers
    {

        //public int Number;

        //public StaticClassNonStaticMembers()
        //{
        //}
    }
}
