using System;
using CoreTweet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFE
{
    class tweet
    {
        public void easytweet(Tokens tokens, string text)
        {
            if (text.Length <= 140)
            {
                tokens.Statuses.Update(status => text);
            }
        }

    }
}
