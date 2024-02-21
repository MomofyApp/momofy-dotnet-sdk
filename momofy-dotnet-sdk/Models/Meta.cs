namespace Momofy.NET.Models;
public class Meta
{
    public int Total { get; set; }
    public int Per_page { get; set; }
    public int Current_page { get; set; }
    public int Last_page { get; set; }
    public int First_page { get; set; }
    public string? First_page_url { get; set; }
    public string? Last_page_url { get; set; }
    public string? Next_page_url { get; set; }
    public string? Prev_page_url { get; set; }
}
