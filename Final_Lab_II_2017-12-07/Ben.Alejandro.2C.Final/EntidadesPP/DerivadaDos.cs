using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public class DerivadaDos:Base
    {
        public DerivadaDos():base(1,0)
        {
        }


        protected override static string VersionFull
        {
            get
            {
                DerivadaDos d2 = new DerivadaDos();
                return d2.MostrarVersion();
            }
        }

        protected override string MostrarVersion()
        {
            return this.MostrarVersion();
        }
    }
}
