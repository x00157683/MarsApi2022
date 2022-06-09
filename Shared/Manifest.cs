using EAD_Ca3.Data;

public class Manifest
{
    public string name { get; set; }
    public string landing_date { get; set; }
    public string launch_date { get; set; }
    public string status { get; set; }
    public int max_sol { get; set; }
    public string max_date { get; set; }
    public int total_photos { get; set; }
    public List<Photo> photos { get; set; }
}