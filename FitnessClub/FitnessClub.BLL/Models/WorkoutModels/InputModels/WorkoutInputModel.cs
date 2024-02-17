using FitnessClub.DAL.Dtos;

namespace FitnessClub.BLL.Models.WorrkoutModels.InputModels
{
    public class WorkoutInputModel
    {
        public int SportTypeId { get; set; }

        public decimal Price { get; set; }

        public int Duration { get; set; }

        public int NumberPlaces { get; set; }

        public bool IsGroup { get; set; }

        public string? Comment { get; set; }
    }
}
