using System.Collections.Generic;

namespace ConcertShare
{
    internal class ConcertMockData
    {
        static Concert[] hardcodedConcerts = {
            new Concert("Bad Suns", "Bads Suns are playing Tuesday at the Sinclair!"),
            new Concert("Jon Bellion", "Ft. Lawrence at House of Blues!")
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