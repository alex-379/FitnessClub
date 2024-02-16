using AutoMapper;
using FitnessClub.BLL.Mapping;
using FitnessClub.BLL.Models.TimetableModels.OutputModels;
using FitnessClub.BLL.Models.WorkoutModels.OutputModels;
using FitnessClub.BLL.Models.WorrkoutModels.InputModels;
using FitnessClub.DAL;
using FitnessClub.DAL.Dtos;
using FitnessClub.DAL.IRepositories;

namespace FitnessClub.BLL
{
    public class WorkoutClient
    {
        private IWorkoutRepositories _workoutRepository;
        private Mapper _mapper;

        public WorkoutClient()
        {
            _workoutRepository = new WorkoutRepository();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new WorkoutMappingProfile());
            });

            _mapper = new Mapper(config);
        }

        public void AddWorkout(WorkoutInputModel workout)
        {

        }

        public List<WorkoutOutputModel> GetAllWorkouts()
        {
            List<WorkoutDto> workoutDtos = _workoutRepository.GetAllWorkouts();
            return _mapper.Map<List<WorkoutOutputModel>>(workoutDtos);
        }
    }
}
