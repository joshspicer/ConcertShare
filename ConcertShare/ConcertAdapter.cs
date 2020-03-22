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

        public override int ItemCount => concertMockData.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ConcertViewHolder vh = holder as ConcertViewHolder;

            // Load the resource's photo image
            vh.Image.SetImageResource(concertMockData[position].photoID);

            // Load the photo caption from the photo album:
            vh.Name.Text = concertMockData[position].name;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            // Inflate view.
            View itemView = LayoutInflater.From(parent.Context).
                        Inflate(Resource.Layout.atomic_concert_item, parent, false);

            // Create a ViewHolder to hold view references inside the CardView:
            ConcertViewHolder vh = new ConcertViewHolder(itemView);
            return vh;
        }
    }
}