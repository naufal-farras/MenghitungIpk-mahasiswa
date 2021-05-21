namespace MenghitungIpk5
{
    class HitungIpk
    {
        public float Total_bobot { get; set; }
        public float Total_sks { get; set; }
        public float Total_akhir { get; set; }


        public float Ips { get; set; }
        public float Jml_sks { get; set; }
        public float Jml_bobot { get; set; }

        public HitungIpk(float total_bobot, float total_sks, float total_akhir, float ips, float jml_sks, float jml_bobot)

        {
            Total_bobot = total_bobot;
            Total_sks = total_sks;
            Total_akhir = total_akhir;



            Ips = ips;
            Jml_sks = jml_sks;
            Jml_bobot = jml_bobot;


        }


    }
}
