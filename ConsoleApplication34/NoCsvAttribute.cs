using System;

namespace ConsoleApplication34
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    sealed class NoCsvAttribute : Attribute
    {
      
    }
}