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
        private TwitterClient client;

        private IDictionary<string, int> hashtags=null!;

        public SocialServices()
        {
            client = new TwitterClient("8IHi9cghPmiLRqXcpHb7KBzVK", "mPmbvmvOSjwNyPHsTWUNIp6vrFxEbXx8YGsCrn0ApWSl13Usf5",
                "1485894302177927168-bvOFb6OazsCQwDnIrKV8OtIPNz8WfK", "XOnwGpB7eB6P2BZ5YjvSxmkr7XDuqydo0SCrh8MYifgNX");
          

            
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
        public void ConnectToTwitter()
        {
            client = new TwitterClient("8IHi9cghPmiLRqXcpHb7KBzVK", "mPmbvmvOSjwNyPHsTWUNIp6vrFxEbXx8YGsCrn0ApWSl13Usf5",
                "1485894302177927168-bvOFb6OazsCQwDnIrKV8OtIPNz8WfK", "XOnwGpB7eB6P2BZ5YjvSxmkr7XDuqydo0SCrh8MYifgNX");

        }

        public async void UpdateHashtasFromTweets(string userName)
        {

            try
            {
                ConnectToTwitter();
                var user = await client.Users.GetAuthenticatedUserAsync();

                var userTimeline = await client.Timelines.GetUserTimelineAsync(userName);
              
                CountHashtags(userTimeline);
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            var SumForOnePost = 5;
            var cash = 0;
            if(hashtagsList != null&& hashtags != null)
            {
                foreach (var tag in hashtags)
                {
                    if (hashtagsList.Contains(tag.Key))
                    {
                        cash+=tag.Value*SumForOnePost;
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
