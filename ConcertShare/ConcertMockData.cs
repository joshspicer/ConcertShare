using System.Collections.Generic;
using Android.Content.Res;

namespace ConcertShare
{
    internal class ConcertMockData
    {
        static Concert[] hardcodedConcerts = {
           new Concert("Bad Suns", "Bads Suns are playing Tuesday at the Sinclair!"),
           new Concert("Jon Bellion", "Album release show at House of Blues!"),
           new Concert("Lawrence", "\"The Weather\" just released",Resource.Drawable.lawrence),
           new Concert("Smallpools", "Show at Brighton Music Hall"),
           new Concert("Jon Bellion", "Album release show at House of Blues!"),
           new Concert("Jon Bellion", "Album release show at House of Blues!"),
           new Concert("Jon Bellion", "Album release show at House of Blues!")

            // ...
        };

        // Indexer (read only) for accessing a concert:
        public Concert this[int i]
        {
            get { return hardcodedConcerts[i]; }
        }

        public int Count
        {
            get { return hardcodedConcerts.Length; }
        }
    }
}