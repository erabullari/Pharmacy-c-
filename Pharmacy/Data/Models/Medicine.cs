namespace Pharmacy.Data.Models
{
    public class Medicine
    {
        public int med_id { get; set; }
        public string med_name { get; set; }
        public int med_price { get; set; }
        public string med_description { get; set; }
        public DateTime med_expired_date { get; set; }

        public string med_produced_by { get; set; }


    }
}
