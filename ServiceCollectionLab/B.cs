using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceCollectionLab
{
    class B:BaseInformation
    {
        A dependency;
        public B(A dependency)
        {
            this.dependency = dependency;
            NotifyCreate();
        }
    }
}
