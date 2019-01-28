using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex32_linkedlist
{
    public class ClubMember
    {
        public int nr;
        public string FNavn;
        public string LNavn;
        public int alder;

        public ClubMember(int Nr, string fname, string ename, int Alder)
        {
            this.nr = Nr;
            this.FNavn = fname;
            this.LNavn = ename;
            this.alder = Alder;

        }
        public override string ToString()
        {
            return "" + nr + " " + FNavn + " " + LNavn + " " + alder; 
        }
    }
}
