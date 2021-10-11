namespace TracNghiemCSDLPT.Models
{
    class Khoa
    {

        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string MaCoSo { get; set; }
        public ActionType ActionType { get; set; }

        public Khoa(string maKhoa, string tenKhoa, string maCoSo)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            MaCoSo = maCoSo;
        }

        public void Update(string maKhoa, string tenKhoa, string maCoSo)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            MaCoSo = maCoSo;
        }

        public void Update(string maKhoa, string tenKhoa, string maCoSo, ActionType action)
        {
            this.Update(maKhoa, tenKhoa, maCoSo);
            this.ActionType = action;
        }

        public Khoa() : base() { }
    }
}
