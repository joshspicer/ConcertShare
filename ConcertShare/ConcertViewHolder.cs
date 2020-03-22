using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using ConcertShare;

public class ConcertViewHolder : RecyclerView.ViewHolder
{
    public ImageView Image { get; private set; }
    public TextView Name { get; private set; }
   

    public ConcertViewHolder(View itemView) : base(itemView)
    {
        // Locate and cache view references:
        Image = itemView.FindViewById<ImageView>(Resource.Id.concertItemImage);

        Name = itemView.FindViewById<TextView>(Resource.Id.concertItem);
    }
}