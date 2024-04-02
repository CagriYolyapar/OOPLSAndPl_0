using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOPLSAndPl_0.DependencyInversion.GoodUsage
{
    public class Kitap
    {
        readonly ICreator _creator;

        public Kitap(ICreator creator)
        {
            _creator = _creator;
        }

        

    }
}
