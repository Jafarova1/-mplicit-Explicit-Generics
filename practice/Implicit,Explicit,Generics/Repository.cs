using Implicit_Explicit_Generics.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics
{ 
    public class Repository<T,U> where T: U   /*where T: new()*//*where T : ITest*/
                                  /*where T : class*/
    {                            //where T:struct
                                 //where T : Common
                                 

    }
}
