namespace Madentra.Model {
    internal class Patient {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public long PhoneNumber { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
