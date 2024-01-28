namespace Iservice
{
    public class PutMedicine
    {
        internal string med_name { get; set; }
        internal int med_price { get; set; }
        internal string med_description{ get; set; }
        public DateTime med_expired_date { get; set; }

        public string med_produced_by { get; set; }
    }
}