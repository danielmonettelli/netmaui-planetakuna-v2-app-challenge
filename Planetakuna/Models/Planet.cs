namespace Planetakuna.Models
{
    public class Planet
    {
        public int Id_Planet { get; set; }
        public string Name_Planet { get; set; }
        public string Short_Description_Planet { get; set; }
        public string Image_Planet { get; set; }
        public List<Feature> Features { get; set; }
    }
}