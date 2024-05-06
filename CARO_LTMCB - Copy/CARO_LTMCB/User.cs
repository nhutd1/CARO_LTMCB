using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CARO_LTMCB
{
    class User
    {
        private int userID;
        private string userName;
        private string mail;
        private double winRate;
        private int score;
        private DateTime ngayTao;
        private int avatar;
        private List<string> listFriend;
        private List<string> listNotFriend;
        private List<string> listRequest;

        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Mail { get => mail; set => mail = value; }
        public double WinRate { get => winRate; set => winRate = value; }
        public int Score { get => score; set => score = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public int Avatar { get => avatar; set => avatar = value; }
        public List<string> ListFriend { get => listFriend; set => listFriend = value; }
        public List<string> ListNotFriend { get => listNotFriend; set => listNotFriend = value; }
        public List<string> ListRequest { get => listRequest; set => listRequest = value; }

        public User(string userName)
        {
            GetValues(userName);
            GetListFriend();
            GetListNotFriend();
            GetListRequest();
        }
        public User(string userID,int i)
        {
            GetValuesFromID(userID, i);
            GetListFriend();
            GetListNotFriend();
            GetListRequest();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=34.87.92.114;Initial Catalog=CARO;User ID=sqlserver;Password=carogame123");

        public void GetValues(string userName)
        {
            try
            {
                connect.Open();
                string getUser = $"SELECT iduser, username, mail, winrate, score, avatar, ngaytao FROM users WHERE username = '{userName}'";
                SqlCommand cmd = new SqlCommand(getUser, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        UserID = read.GetInt32(0);
                        UserName = read.GetString(1);
                        Mail = read.GetString(2);
                        WinRate = Convert.ToDouble(read.GetValue(3));
                        Score = Convert.ToInt32(read.GetValue(4));
                        Avatar = Convert.ToInt32(read.GetValue(5));
                        NgayTao = Convert.ToDateTime(read.GetValue(6));
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void GetValuesFromID(string userID, int i)
        {
            try
            {
                connect.Open();
                string getUser = $"SELECT iduser, username, mail, winrate, score, avatar, ngaytao FROM users WHERE iduser = '{userID}'";
                SqlCommand cmd = new SqlCommand(getUser, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        UserID = read.GetInt32(0);
                        UserName = read.GetString(1);
                        Mail = read.GetString(2);
                        WinRate = Convert.ToDouble(read.GetValue(3));
                        Score = Convert.ToInt32(read.GetValue(4));
                        Avatar = Convert.ToInt32(read.GetValue(5));
                        NgayTao = Convert.ToDateTime(read.GetValue(6));
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public int SLMatchs()
        {
            int count = 0;
            try
            {
                connect.Open();
                string check = $"SELECT COUNT(*) FROM matchs WHERE iduserwin = '{userID}' OR iduserlose = '{userID}'";
                SqlCommand cmd = new SqlCommand(check, connect);
                using(SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        count = Convert.ToInt32(read.GetValue(0));
                    }
                }
            }
            catch
            {
                count = -1;
            }
            finally
            {
                connect.Close();
            }
            return count;
        }
        public void GetListFriend()
        {
            List<string> list = new List<string>();
            try
            {
                connect.Open();
                string getFriend = $"SELECT iduser1 FROM FRIEND WHERE iduser2 = '{userID}' UNION SELECT iduser2 FROM FRIEND WHERE iduser1 = '{userID}' ";
                SqlCommand cmd = new SqlCommand(getFriend, connect);
                using(SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(read.GetValue(0).ToString());
                    }
                }
                ListFriend = list;
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void GetListNotFriend()
        {
            List<string> list = new List<string>();
            try
            {
                connect.Open();
                string getFriend = $"SELECT iduser FROM users WHERE iduser NOT IN (SELECT iduser1 FROM FRIEND WHERE iduser2 = '{userID}' UNION SELECT iduser2 FROM FRIEND WHERE iduser1 = '{userID}') AND iduser <> '{UserID}' ";
                SqlCommand cmd = new SqlCommand(getFriend, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(read.GetValue(0).ToString());
                    }
                }
                ListNotFriend = list;
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void GetListRequest()
        {
            List<string> list = new List<string>();
            try
            {
                connect.Open();
                string getRequest = $"SELECT iduser_guiinvite FROM addinvite WHERE iduser_nhaninvite = '{userID}'";
                SqlCommand cmd = new SqlCommand(getRequest, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add(read.GetValue(0).ToString());
                    }
                }
                ListRequest = list;
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void ChangeAvatar(int index)
        {
            try
            {
                connect.Open();
                string change = $"UPDATE users SET avatar = '{index}' WHERE iduser = {userID}";
                using(SqlCommand cmd = new SqlCommand(change, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch 
            {
                
            }
            finally
            {
                connect.Close();
            }
        }
        public void FriendRequest(string userIDNhan)
        {
            try
            {
                connect.Open();
                string insert = $"INSERT INTO addinvite VALUES ('{userID}','{userIDNhan}')";
                using (SqlCommand cmd = new SqlCommand(insert, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void AceptFriendRequest(string userIDRequest)
        {
            try
            {
                connect.Open();
                string insert = $"INSERT INTO friend VALUES ('{userIDRequest}','{userID}')";
                using (SqlCommand cmd = new SqlCommand(insert, connect))
                {
                    cmd.ExecuteNonQuery();
                }

                string deleteRequest = $"DELETE FROM addinvite WHERE iduser_guiinvite IN ('{userID}','{userIDRequest}') AND iduser_nhaninvite IN ('{userID}','{userIDRequest}')";
                using(SqlCommand cmd = new SqlCommand(deleteRequest, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void NoAceptFriendRequest(string userIDRequest)
        {
            try
            {
                connect.Open();
                string deleteRequest = $"DELETE FROM addinvite WHERE iduser_guiinvite IN ('{userID}','{userIDRequest}') AND iduser_nhaninvite IN ('{userID}','{userIDRequest}')";
                using (SqlCommand cmd = new SqlCommand(deleteRequest, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void UnFriend(string userIDFriend)
        {
            try
            {
                connect.Open();
                string unFr = $"DELETE FROM friend WHERE iduser1 IN ('{userID}','{userIDFriend}') AND iduser2 IN ('{userID}','{userIDFriend}')";
                using (SqlCommand cmd = new SqlCommand(unFr, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public void SendTo(string userIDReceive, string data)
        {
            DateTime ngayMess = DateTime.Now;
            try
            {
                connect.Open();
                string insert = $"INSERT INTO mess VALUES ('{userID}','{userIDReceive}','{data}','{ngayMess}')";
                using (SqlCommand cmd = new SqlCommand(insert, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }
        }
        public List<Message> GetMess(string id)
        {
            List<Message> list = new List<Message>();
            try
            {
                connect.Open();
                string getMess = $"SELECT * FROM mess WHERE idsend IN ('{userID}','{id}') AND idreceive IN ('{userID}','{id}') ";
                SqlCommand cmd = new SqlCommand(getMess, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Message msg = new Message();
                        msg.IdSend = Convert.ToInt32(read.GetValue(1));
                        msg.IdReceive = Convert.ToInt32(read.GetValue(2));
                        msg.Content = read.GetValue(3).ToString();
                        DateTime day = new DateTime();
                        day = Convert.ToDateTime(read.GetValue(4));
                        msg.NgayMess = $"{day.Day}/{day.Month}/{day.Year}  {day.Hour}:{day.Minute}";

                        list.Add(msg);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            return list;
        }
        public List<Match> GetMatch()
        {
            List<Match> list = new List<Match>();
            try
            {
                connect.Open();
                string getMatch = $"SELECT * FROM matchs WHERE iduserwin = '{userID}' OR iduserlose = '{userID}' ORDER BY IDMATCH DESC";
                SqlCommand cmd = new SqlCommand(getMatch, connect);
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        Match m = new Match();
                        m.IdWin = Convert.ToInt32(read.GetValue(1));
                        m.IdLoss = Convert.ToInt32(read.GetValue(2));
                        DateTime day = new DateTime();
                        day = Convert.ToDateTime(read.GetValue(3));
                        m.NgayMatch = $"{day.Day}/{day.Month}/{day.Year}  {day.Hour}:{day.Minute}";

                        list.Add(m);
                    }
                }
            }
            catch
            {

            }
            finally
            {
                connect.Close();
            }

            return list;
        }
        
    }
}
