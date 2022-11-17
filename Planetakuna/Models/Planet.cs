namespace Planetakuna.Models
{
    public class Planet
    {
        public int Id_Planet { get; set; }
        public string Name_Planet { get; set; }
        public string Image_Planet { get; set; }
        public int Temperature_Planet { get; set; }
        public string Distance_from_Earth_Planet { get; set; }
        public double Average_Orbital_Speed_Planet { get; set; }
        public int Satellites_Planet { get; set; }
        public object Surface_Area_Planet { get; set; }
        public double Rotation_Period_Planet { get; set; }
    }

}