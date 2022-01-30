using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi.Models;

namespace Client.Interfaces
{
    public interface ISocialServices
    {
        void PostTweet(string msg);
       // Task<string> GetUser();
        Task<ITweet[]> GetTweets(string userName);
        IDictionary<string, int> CountHashtags(IEnumerable<ITweet> tweets);
        int InitCash(List<string> hashtagsList);
        Task<OrderModel> MakeOrder(UserModel user, int qty, DonationModel donation, IOrderServices os);
        void UpdateHashtasFromTweets(string userName);
        void ConnectToTwitter();
    }
}
