using System.ComponentModel.DataAnnotations;

namespace ProductAppApi.Entities
{
    public class Product
    {
        [Key]
        public int nStokID { get; set; }
        public string sBarkod { get; set; }
        public string sAciklama { get; set; }
        public double PS { get; set; }
        public double KR { get; set; }
        public double m1 { get; set; }
        public double m2 { get; set; }
        public double m3 { get; set; }
        public double m4 { get; set; }
        public double m5 { get; set; }
        public double m6 { get; set; }
        public double m7 { get; set; }
        public double m8 { get; set; }
        public double m9 { get; set; }
        public double m10 { get; set; }
        public double m11 { get; set; }
        public double m12 { get; set; }
    }
}