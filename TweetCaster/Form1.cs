using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace TweetCaster
{
    public partial class Form1 : Form
    {
        ArrayList TweetQueue = new ArrayList();
        bool alreadyStopping = false;

        // Setup your credentials to the API
        private string consumerKey;
        private string consumerSecret;
        private string accessToken;
        private string accessTokenSecret;

        public Form1()
        {
            InitializeComponent();

            consumerKey = "UGtYegZHpfTq2wSZUhr82ugDt";
            consumerSecret = "P9R4mZywqMzKNcrdxJZ4dsraqXDQqJ1ST815aEhFQmknurVhfS";
            accessToken = "21025456-f5zJRhf0FiJva36uiUCoK9YSLTA03Nbbe3lAVTVZB";
            accessTokenSecret = "E8jmxmnV9ya9RsLMfxkPNYVztthee3GRQoBo1FtGe0yKN";
        }

        private void Form1_Load(object caller, EventArgs e)
        {
            // Clear the form, hide the graphic
            // Set to the starting point
            lblName.Text = "";
            lblScreenName.Text = "";
            txtTweet.Text = "";
            imgTweet.Visible = false;
            imgAvatar.Image = imgAvatar.ErrorImage;
            imgTweet.Visible = false;
            pnlCurtain.Width = pnlTweet.Width;

            try
            {
                TwitterCredentials.SetCredentials(accessToken, accessTokenSecret, consumerKey, consumerSecret);
            }
            catch (Exception ex)
            {
                txtTweetQueue.Text += buildErrorMessage("setting credentials", ex);
            }

            startStream();
        }

        private void startStream()
        {
            string tweetFormat = "{0}\r\n{1} (@{2})\r\n{3}\r\n\r\n\r\n";

            var userStream = Stream.CreateUserStream();
            userStream.TweetFavouritedByMe += (s, a) =>
            {
                TweetQueue.Add(a);
                txtTweetQueue.Text = string.Format(tweetFormat, a.Tweet.Creator.ProfileImageUrl, a.Tweet.Creator.Name, a.Tweet.Creator.ScreenName, formatTweetText(a.Tweet.Text)) + txtTweetQueue.Text;
            };

            userStream.StartStreamAsync();
        }

        private string buildErrorMessage(string actionBeingAttempted, Exception ex)
        {
            string s = "\r\n\r\n========================================\r\n";
            s += "An exception occurred while " + actionBeingAttempted + ":\r\n";
            s += ex.Message + "\r\n";
            s += "========================================\r\n\r\n\r\n";
            return s;
        }

        public string formatTweetText(string text)
        {
            text = text.Replace("\n", "  ");

            Regex regex = new Regex("((http://|www\\.)([A-Z0-9.-:]{1,})\\.[0-9A-Z?;~&#=\\-_\\./]{2,})", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (Match match in regex.Matches(text))
            {
                text = text.Replace(match.Value, "");
            }

            text = text.Replace("  ", " ").Trim();

            return text;
        }

        public static Image getImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (System.IO.Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public void displayTweet(Tweetinvi.Core.Events.EventArguments.TweetEventArgs a)
        {
            if (a.Tweet.Creator.ProfileImageFullSizeUrl != "")
            {
                try
                {
                    imgAvatar.Load(a.Tweet.Creator.ProfileImageFullSizeUrl);
                }
                catch (Exception)
                {
                    try
                    {
                        imgAvatar.Load(a.Tweet.Creator.ProfileImageUrl);
                    }
                    catch (Exception)
                    {
                        imgAvatar.Image = imgAvatar.ErrorImage;
                    }
                }
            }

            string tweetCreatorName = a.Tweet.Creator.Name;
            string tweetCreatorScreenName = "@" + a.Tweet.Creator.ScreenName;
            string tweetText = formatTweetText(a.Tweet.Text);
            bool boolDisplayPicture = false;

            if ((a.Tweet.Entities.Medias != null) && (a.Tweet.Entities.Medias.First().MediaType == "photo") && (a.Tweet.Entities.Medias.First().MediaURL != ""))
            {
                try
                {
                    string strFirstMediaURL = a.Tweet.Entities.Medias.First().MediaURL;
                    string strFirstMediaType = a.Tweet.Entities.Medias.First().MediaType;
                    string strFirstURL = a.Tweet.Entities.Medias.First().URL;

                    imgTweet.Load(strFirstMediaURL);
                    tweetText = tweetText.Replace(strFirstURL, "").Trim();

                    boolDisplayPicture = true;
                }
                catch (Exception)
                {
                    boolDisplayPicture = false;
                }
            }
            else
            {
                boolDisplayPicture = false;
            }

            lblName.Text = tweetCreatorName;
            lblScreenName.Text = tweetCreatorScreenName;
            txtTweet.Text = tweetText;
            imgTweet.Visible = boolDisplayPicture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Make sure there are tweets in the queue, if not, just stop
            if (TweetQueue.Count <= 0)
            {
                return;
            }
            else
            {
                timerShowTweetBox.Enabled = true;

                imgAvatar.Image = imgAvatar.ErrorImage;
                lblName.Text = "";
                lblScreenName.Text = "";
                txtTweet.Text = txtPromotionTweet.Text;

                // Start the timer
                timer1.Enabled = true;
            }
        }

        private void displayFirstTweetInQueue()
        {
            // Display the first tweet in the array on the page
            Tweetinvi.Core.Events.EventArguments.TweetEventArgs a = (Tweetinvi.Core.Events.EventArguments.TweetEventArgs)TweetQueue[0];
            displayTweet(a);

            // Remove that Tweet from the array
            TweetQueue.RemoveAt(0);

            updateStatusbar();
        }

        public void updateStatusbar()
        {
            toolStripStatusLabelTweetQueueCount.Text = TweetQueue.Count.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerShowTweetBox_Tick(object sender, EventArgs e)
        {
            if (pnlCurtain.Width > 0)
            {
                pnlCurtain.Width = pnlCurtain.Width - 20;
            }
            else
            {
                timerShowTweetBox.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Enabled = false;

            // Hide the box
            timerHideTweetBox.Enabled = true;
        }

        private void timerHideTweetBox_Tick(object sender, EventArgs e)
        {
            if (pnlCurtain.Width < pnlTweet.Width)
            {
                pnlCurtain.Width = pnlCurtain.Width + 20;
            }
            else
            {
                timerHideTweetBox.Enabled = false;
            }
        }
    }
}
