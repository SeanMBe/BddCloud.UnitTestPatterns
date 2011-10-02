using System;
using System.Net;

namespace BddCloud.UnitTestPatterns.Common
{
    public class DependencyToSeeIfTwitterIsOnline : IDependencyToSeeIfTwitterIsOnline
    {
        private const string _twitterUrl = "http://twitter.com";

        public bool IsTwitterOnline
        {
            get { return CanConnectToTwitter(); }
        }

        private static bool CanConnectToTwitter()
        {
            var urlCheck = new Uri(_twitterUrl);
            var request = (HttpWebRequest)WebRequest.Create(urlCheck);
            request.Timeout = 3000;
            return request.GetResponse() != null;
        }
    }
}