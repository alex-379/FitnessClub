using AutoMapper;
using FitnessClub.BLL.Models.WorkoutModels.OutputModels;
using FitnessClub.BLL.Models.WorrkoutModels.InputModels;
using FitnessClub.DAL.Dtos;

namespace FitnessClub.BLL.Mapping
{
    public class WorkoutMappingProfile : Profile
    {
        public WorkoutMappingProfile()
        {
            CreateMap<WorkoutDto, WorkoutOutputModel>();
            CreateMap<WorkoutInputModel, WorkoutDto>();
        }
    }
}