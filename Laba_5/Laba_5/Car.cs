namespace Laba_5
{
    public static class Car
    {
        public static string CarName { get; set; }
        public static string CarType { get; set; }
        public static string CarModel { get; set; }
        static Car()
        {
            CarName = "Vesta";
            CarType = "Sedan";
            CarModel = "Lada";
        }
    }
}
