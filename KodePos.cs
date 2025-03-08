using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022330091
{
    class KodePos
    {
        public string kelurahan;
        private String kodePos;

        public KodePos(string kelurahan, string kodePos)
        {
            this.kelurahan = kelurahan;
            this.kodePos = kodePos;
        }

        public string getKodePos()
        {
            return kodePos;
        }
    }
}
