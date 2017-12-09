using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public sealed class DerivadaUno:Base
    {
        protected int revision;

        static DerivadaUno()
        { }

        public DerivadaUno(int version, int subversion, int revision):base(version, subversion)
        {
            this.revision = revision;
        }

        protected override string MostrarVersion()
        {
            StringBuilder sb = new StringBuilder(this.MostrarVersion());
            sb.AppendFormat(" Revision: {0}",this.revision);
            return sb.ToString();
        }
    }
}
