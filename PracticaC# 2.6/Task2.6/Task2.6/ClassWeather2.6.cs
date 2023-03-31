namespace WetherApp
{
    class Weather
    {
        public int visibility { get; set; }
        public Indicators Main { get; set; }
        public string Name { get; set; }
        public Indicators[] weather { get; set; }
        public Indicators wind { get; set; }
    }
}