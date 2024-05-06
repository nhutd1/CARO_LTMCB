using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO_LTMCB
{
    class Match
    {
        private int idWin;
        private int idLoss;
        private string ngayMatch;

        public int IdWin { get => idWin; set => idWin = value; }
        public int IdLoss { get => idLoss; set => idLoss = value; }
        public string NgayMatch { get => ngayMatch; set => ngayMatch = value; }
    }
}
