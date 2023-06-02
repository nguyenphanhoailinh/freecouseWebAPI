namespace MyWebApiApp.Models
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; } = null!;
        public double DonGia { get; set; }

        
    }
    public class HangHoa :HangHoaVM
    {
        public Guid MaHangHoa { get; set; }


    }
}
