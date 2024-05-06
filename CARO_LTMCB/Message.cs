using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO_LTMCB
{
    class Message
    {
        private int idSend;
        private int idReceive;
        private string content;
        private string ngayMess;

        public int IdSend { get => idSend; set => idSend = value; }
        public int IdReceive { get => idReceive; set => idReceive = value; }
        public string Content { get => content; set => content = value; }
        public string NgayMess { get => ngayMess; set => ngayMess = value; }
    }
}
