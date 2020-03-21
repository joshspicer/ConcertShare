using Android.Support.V7.Widget;
using Android.Views;

namespace ConcertShare
{
    internal class ConcertAdapter : RecyclerView.Adapter
    {
        private ConcertMockData concertMockData;

        public ConcertAdapter(ConcertMockData concertMockData)
        {
            this.concertMockData = concertMockData;
        }

        public override int ItemCount => throw new System.NotImplementedException();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new System.NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new System.NotImplementedException();
        }
    }
}