using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CARO_LTMCB
{
    public class User
    {
        public int avatar { get; set; }
        public int isOnline { get; set; }
        public DateTime ngayTao { get; set; }
        public int score { get; set; }
        public int slMatch { get; set; }
        public int userID { get; set; }
        public string userMail { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }
        public double winRate { get; set; }
        public string gender { get; set; }
        public User()
        {
            gender = "male"; // Thiết lập giá trị mặc định là "male" khi tạo đối tượng
        }
    }
    public class UserIdentity
    {
        public int ID { get; set; }
    }
    public class Message
    {
        public int idMess { get; set; }
        public int idSend { get; set; }
        public int idReceive { get; set; }
        public string content { get; set; }
        public DateTime ngayMess { get; set; }
    }
    public class MessageIdentity
    {
        public int ID { get; set; }
    }
    public class Match
    {
        public int idMatch { get; set; }
        public int idUserWin { get; set; }
        public int idUserLoss { get; set; }
        public DateTime ngayMatch { get; set; }
    }
    public class MatchIdentity
    {
        public int ID { get; set; }
    }
    public class BotMatch
    {
        public int idBotMatch { get; set; }
        public int idUser { get; set; }
        public bool isUserWin { get; set; }
        public DateTime ngayMatch { get; set; }

    }
    public class BotMatchIdentity
    {
        public int ID { get; set; }
    }
    public class Friend
    {
        public int idFriend { get; set; }
        public int idUser1 { get; set; }
        public int idUser2 { get; set; }
    }
    public class FriendIdentity
    {
        public int ID { get; set; }
    }

    public class AddInvite
    {
        public int idAddInvite { get; set; }
        public int idReceive { get; set; }
        public int idSend { get; set; }
    }

    public class AddInviteIdentity
    {
        public int ID { get; set; }
    }

    public class Request
    {
        public int idRequest { get; set; }
        public int idReceive { get; set; }
        public int idSend { get; set; }
        public string ipAddress { get; set; }
    }

    public class RequestIdentity
    {
        public int ID { get; set; }
    }
}
