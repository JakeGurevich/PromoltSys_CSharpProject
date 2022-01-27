using Client.Interfaces;
using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace Client.Services
{
    public class SocialServices:ISocialServices
    {
        private readonly TwitterClient client;
        private IDictionary<string, int> hashtags=null!;

        public SocialServices()
        {
            client = new TwitterClient("0tO7j8zau21kQ0ADSF4O5ZZ28", "UNufXg6q7TjMoase5GjekgqRIP5IQ8IAld6tsZXRkp2vpWCGA6",
                "1485894302177927168-etJeYpqWsMDKsyJV02xXiBcgT9kfnc", "f7qnhJFZ4I2PU2WOsFaom83RTxoL6vQxQiXhlMkcRG7C0");
          

            
        }
        public async Task<ITweet[]> GetTweets(string userName)
        {
            try
            {
                var user = await client.Users.GetAuthenticatedUserAsync();
               // var publishedTweet = await client.Tweets.PublishTweetAsync("#SaveCars!");
                var userTimeline = await client.Timelines.GetUserTimelineAsync(userName);
                var count = userTimeline.Length;
                CountHashtags(userTimeline);
                return userTimeline;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public async void PostTweet(string msg)
        {
            var publishedTweet = await client.Tweets.PublishTweetAsync(msg);
        }
        public IDictionary<string, int> CountHashtags(IEnumerable<ITweet> tweets)
        {
            hashtags=new Dictionary<string,int>();
            
           // List <string> tags=new List<string>();
            foreach (var tweet in tweets)
            {
                var currentTweet = (ITweet)tweet;
                if (currentTweet.Hashtags.Count >0)
                {
                    if (!hashtags.ContainsKey(currentTweet.Hashtags[0].Text))
                    {
                        hashtags.Add((currentTweet.Hashtags[0].Text), 1);
                    }else
                    {
                      hashtags[currentTweet.Hashtags[0].Text]+=1;
                    }

                   
                }
               
            }
            return hashtags;
        }

        public int InitCash(List<string> hashtagsList)
        {
            var cash = 0;
            if(hashtagsList != null&& hashtags != null)
            {
                foreach (var tag in hashtags)
                {
                    if (hashtagsList.Contains(tag.Key))
                    {
                        cash++;
                    }
                }
            }
            return cash;    
        }
        public async Task<OrderModel> MakeOrder(UserModel user, int qty,DonationModel donation, IOrderServices orderServices)
        {
                var item=new ItemModel{Title=donation.ProductName,Qty=qty,Price=(Decimal)donation.Price };
                var cart=new List<ItemModel>();
                cart.Add(item);
                var order = new OrderModel { Cart = cart,TotalPrice=item.Price*item.Qty,CreatedBy=user.Id,CreatedAt=DateTime.Now};
                await orderServices.CreateOrder(order);
               return order;
           

        }
    }
}
