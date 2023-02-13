using System;
namespace OOP_ngay11_1
{
    public class Program 
    { }
    public class Cuocthi { }
    
    public class DOI
    {
        private int maDoi;
        private int donVi;
        private List<VDV> dsVDV = new List<VDV>();
        public DOI(int maDoi, int donVi)
        {
            this.maDoi = maDoi;
            this.donVi = donVi;
        }
        public int MaDoi { get => maDoi; }
        public int DonVi { get => donVi; }
        internal List<VDV> DsVDV { get => dsVDV; }

        public void AddVDV(VDV vdv)
        {
            dsVDV.Add(vdv);
        }

        public void tongTG(VDV vDV)
        {
            int tongthgian = 0;
            foreach (VDV v in dsVDV)
            {
                tongthgian += v.Thgian;
            }
        }
    }
        
    public class VDV 
    {
        private string maso;
        private string tenVDV;
        private int tuoi;
        
        private DOI doi;
        private int thoigian;


        public string TenVDV { get => tenVDV; }
        public string Tuoi { get => tuoi; }
        public string Thgian { get => thgian; set => thgian = value; }
        //output
        public VDV(string ma, string ten,int tuoi)
        {
            this.maso = ma;
            this.tenVDV = ten;
            this.tuoi = tuoi;
        }
        public void xepDoi(DOI doi)
        {
            this.doi = doi;
            doi.AddVDV(this);
        }
    }
}
