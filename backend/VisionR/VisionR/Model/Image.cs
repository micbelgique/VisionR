namespace VisionR.Model
{
    public class Image:Entity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public VisionResult VisionResult { get; set; }
    }
}
