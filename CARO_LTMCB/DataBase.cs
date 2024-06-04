using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Serialization.JsonNet;
using Newtonsoft.Json;
using FireSharp;

namespace CARO_LTMCB
{
    static public class DTBase
    {
        #region Khởi tạo kết nối 
        static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "KvzCKIAhrr7tSzigv3koZWSZSmx2IcbR31V6AJOK",
            BasePath = "https://caro-c7978-default-rtdb.firebaseio.com/"
        };
        static public IFirebaseClient client = new FirebaseClient(config);
        #endregion

        static public bool uNameExists;
        static public bool isOK;
        static public bool IsUsernameExists(string uName)
        {
            FirebaseResponse rep = client.Get("USER/");
            Dictionary<int, User> getUser = rep.ResultAs<Dictionary<int, User>>();

            foreach (var user in getUser)
            {
                if (user.Value.userName == uName)
                {
                    return true;
                }
            }
            return false;
        }
        static public async void AddNewUser(string uName, string pass, string mail)
        {
            FirebaseResponse rep = client.Get("UserIdentity/");
            UserIdentity id = rep.ResultAs<UserIdentity>();
            DateTime date = DateTime.Now;

            var user = new User()
            {
                userID = id.ID,
                userName = uName,
                userPass = pass,
                userMail = mail,
                ngayTao = date,
                winRate = 0,
                score = 0,
                avatar = 0,
                isOnline = 0,
                slMatch = 0
            };

            FirebaseResponse rep1 = await client.SetAsync("USER/" + id.ID.ToString(), user);
            id.ID += 1;
            FirebaseResponse rep2 = await client.SetAsync("UserIdentity/", id);
        }
        static public bool CheckLogin(string uName, string uPass)
        {
            FirebaseResponse rep = client.Get("USER/");
            Dictionary<int, User> getUser = rep.ResultAs<Dictionary<int, User>>();
            foreach (var user in getUser)
            {
                if (user.Value.userName == uName && user.Value.userPass == uPass)
                {
                    return true;
                }
            }
            return false;
        }
        static public bool CheckUNameUMail(string uName, string uMail)
        {
            FirebaseResponse rep = client.Get("USER/");
            Dictionary<int, User> getUser = rep.ResultAs<Dictionary<int, User>>();
            foreach (var user in getUser)
            {
                if (user.Value.userName == uName && user.Value.userMail == uMail)
                {
                    return true;
                }
            }
            return false;
        }
        static public void GetUserUName(string uName)
        {
            FirebaseResponse rep = client.Get("USER/");
            Dictionary<int, User> getUser = rep.ResultAs<Dictionary<int, User>>();
            foreach (var user in getUser)
            {
                if (user.Value.userName == uName)
                {
                    MyUser.user = user.Value;
                }
            }
        }
        static public User GetUserUID(int uID)
        {
            FirebaseResponse rep = client.Get("USER/" + uID.ToString());
            User user = rep.ResultAs<User>();

            return user;
        }
        static public async void ChangePass(string newPass)
        {
            MyUser.user.userPass = newPass;
            FirebaseResponse rep = await client.UpdateAsync("USER/" + MyUser.user.userID.ToString(), MyUser.user);
        }
        static public async void ChangeAvatar(int index)
        {
            MyUser.user.avatar = index;
            FirebaseResponse rep = await client.UpdateAsync("USER/" + MyUser.user.userID.ToString(), MyUser.user);
        }
        static public async void SendFriendRequest(int idRcv)
        {
            FirebaseResponse rep = client.Get("AddinviteIdentity/");
            AddInviteIdentity id = rep.ResultAs<AddInviteIdentity>();

            var addInvite = new AddInvite()
            {
                idAddInvite = id.ID,
                idSend = MyUser.user.userID,
                idReceive = idRcv
            };

            FirebaseResponse rep1 = await client.SetAsync("ADDINVITE/" + id.ID.ToString(), addInvite);
            id.ID += 1;
            FirebaseResponse rep2 = await client.SetAsync("AddinviteIdentity/", id);
        }
        static public async void AcceptFriendRequest(int idSend)
        {
            FirebaseResponse rep = client.Get("FriendIdentity/");
            FriendIdentity id = rep.ResultAs<FriendIdentity>();

            var friend = new Friend()
            {
                idFriend = id.ID,
                idUser1 = idSend,
                idUser2 = MyUser.user.userID
            };

            FirebaseResponse rep1 = await client.SetAsync("FRIEND/" + id.ID.ToString(), friend);
            id.ID += 1;
            FirebaseResponse rep2 = await client.SetAsync("FriendIdentity/", id);
            FirebaseResponse rep3 = await client.GetAsync("ADDINVITE/");
            List<AddInvite> getInvite = rep3.ResultAs<List<AddInvite>>();
            foreach (var invite in getInvite)
            {
                if (invite != null)
                {
                    if ((invite.idSend == idSend && invite.idReceive == MyUser.user.userID)
                      || (invite.idSend == MyUser.user.userID && invite.idReceive == idSend))
                    {
                        FirebaseResponse rep4 = await client.DeleteAsync("ADDINVITE/" + invite.idAddInvite.ToString());
                    }
                }
            }
        }
        static public async void RejectFriendRequest(int idSend)
        {
            FirebaseResponse rep3 = await client.GetAsync("ADDINVITE/");
            List<AddInvite> getInvite = rep3.ResultAs<List<AddInvite>>();
            foreach (var invite in getInvite)
            {
                if (invite != null)
                {
                    if ((invite.idSend == idSend && invite.idReceive == MyUser.user.userID)
                      || (invite.idSend == MyUser.user.userID && invite.idReceive == idSend))
                    {
                        FirebaseResponse rep4 = await client.DeleteAsync("ADDINVITE/" + invite.idAddInvite.ToString());
                    }
                }
            }
        }
        static public List<int> ListRequests()
        {
            List<int> listRequests = new List<int>();
            FirebaseResponse rep3 = client.Get("ADDINVITE/");
            List<AddInvite> getInvite = rep3.ResultAs<List<AddInvite>>();
            foreach (var invite in getInvite)
            {
                if (invite != null)
                {
                    if (invite.idReceive == MyUser.user.userID)
                    {
                        listRequests.Add(invite.idSend);
                    }
                }
            }
            return listRequests;
        }
        static public List<int> ListFriends()
        {
            List<int> listFriends = new List<int>();
            FirebaseResponse rep = client.Get("FRIEND/");
            List<Friend> getFriend = rep.ResultAs<List<Friend>>();
            foreach (var friend in getFriend)
            {
                if (friend != null)
                {
                    if (friend.idUser1 == MyUser.user.userID)
                    {
                        listFriends.Add(friend.idUser2);
                    }
                    else if (friend.idUser2 == MyUser.user.userID)
                    {
                        listFriends.Add(friend.idUser1);
                    }
                }
            }
            return listFriends;
        }
        static public List<int> ListNotFriends()
        {
            List<int> list = new List<int>();

            List<int> listFriends = new List<int>();
            listFriends = DTBase.ListFriends();

            FirebaseResponse rep = client.Get("USER/");
            Dictionary<int, User> getUser = rep.ResultAs<Dictionary<int, User>>();

            foreach (var user in getUser)
            {
                if (!listFriends.Contains(user.Value.userID))
                {
                    list.Add(user.Value.userID);
                }
            }
            return list;
        }
        static public async void SendMessTo(int uReceive, string content)
        {
            FirebaseResponse rep = client.Get("MessIdentity/");
            MessageIdentity id = rep.ResultAs<MessageIdentity>();
            DateTime date = DateTime.Now;

            var mess = new Message()
            {
                idMess = id.ID,
                idReceive = uReceive,
                idSend = MyUser.user.userID,
                content = content,
                ngayMess = date
            };

            FirebaseResponse rep1 = await client.SetAsync("MESS/" + id.ID.ToString(), mess);
            id.ID += 1;
            FirebaseResponse rep2 = await client.SetAsync("MessIdentity/", id);
        }
        static public List<Message> ListMessWith(int idUser)
        {
            List<Message> list = new List<Message>();
            FirebaseResponse rep = client.Get("MESS/");
            List<Message> getMess = rep.ResultAs<List<Message>>();

            foreach (var mess in getMess)
            {
                if (mess != null)
                {
                    if ((mess.idSend == MyUser.user.userID && mess.idReceive == idUser)
                     || (mess.idSend == idUser && mess.idReceive == MyUser.user.userID))
                    {
                        list.Add(mess);
                    }
                }
            }
            return list;
        }
        static public async void AddMatch(int idUser)
        {
            FirebaseResponse rep = client.Get("MatchIdentity/");
            MatchIdentity id = rep.ResultAs<MatchIdentity>();
            DateTime date = DateTime.Now;

            var match = new Match()
            {
                idMatch = id.ID,
                idUserWin = MyUser.user.userID,
                idUserLoss = idUser,
                ngayMatch = date
            };

            FirebaseResponse rep1 = await client.SetAsync("MATCH/" + id.ID.ToString(), match);
            id.ID += 1;
            FirebaseResponse rep2 = await client.SetAsync("MatchIdentity/", id);

            DTBase.SetScore_Winrate(idUser);
        }
        static public async void SetScore_Winrate(int idUser)
        {
            MyUser.user.score += 1;
            MyUser.user.slMatch += 1;
            double rate = ((double)MyUser.user.score * 100) / (double)MyUser.user.slMatch;
            MyUser.user.winRate = Math.Round(rate, 3);
            FirebaseResponse rep = await client.UpdateAsync("USER/" + MyUser.user.userID.ToString(), MyUser.user);

            User anotherUser = DTBase.GetUserUID(idUser);
            anotherUser.slMatch += 1;
            double rate1 = ((double)anotherUser.score * 100) / (double)anotherUser.slMatch;
            anotherUser.winRate = Math.Round(rate1, 3);
            FirebaseResponse rep1 = await client.UpdateAsync("USER/" + idUser.ToString(), anotherUser);
        }
        static public List<Match> HistoryMatch()
        {
            List<Match> myMatch = new List<Match>();
            FirebaseResponse rep = client.Get("MATCH/");
            List<Match> listMatch = rep.ResultAs<List<Match>>();

            foreach (var match in listMatch)
            {
                if (match != null)
                {
                    if ((match.idUserWin == MyUser.user.userID) || (match.idUserLoss == MyUser.user.userID))
                    {
                        myMatch.Add(match);
                    }
                }
            }
            return myMatch;
        }
    }

    static public class MyUser
    {
        static public User user;

    }
}
