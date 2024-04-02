using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLSAndPl_0.DependencyInversion.BadUsage
{

    //Tightly coupled : Sıkı sıkıya baglı


    //Loosely coupled : Gevşek bir şekilde bağlı
    public class Kitap
    {
        public Yazar Yazari { get; set; }

    }
}
