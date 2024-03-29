namespace FitnessClub.BLL.Models.WorkoutModels.OutputModels
{
    public class WorkoutOutputModel
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Duration { get; set; }

        public int NumberPlaces { get; set; }

        public bool IsGroup { get; set; }

        public string? Comment { get; set; }
    }
}