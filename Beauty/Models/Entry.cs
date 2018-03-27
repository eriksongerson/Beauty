namespace Beauty
{
    public class Entry
    {
        public Master master { get; set; }
        public Client client { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int price { get; set; }

        public Entry()
        {

        }

        public Entry(Master master, Client client, string date, string time, int price)
        {
            this.master = master;
            this.client = client;
            this.date = date;
            this.time = time;
            this.price = price;
        }

    }
}
