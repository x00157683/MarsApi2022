namespace EAD_Ca3.Data
{
    public class Photo  //first node after root
    {
        public int id { get; set; }
        public int sol { get; set; }
        public Camera ?camera { get; set; }  
        public string ?img_src { get; set; }
        public string ?earth_date { get; set; }
        public Rover ?rover { get; set; }


        public override string ToString()  
        {
            string b = $"ID: {id} Sol Day: {sol} Earth Day: {earth_date} ";

            return b;
        }
    }
}
