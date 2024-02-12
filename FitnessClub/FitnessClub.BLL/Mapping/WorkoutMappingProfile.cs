using System;
using AutoMapper;
using FitnessClub.DAL.Dtos;
using FitnessClub.BLL.Models.WorkoutModels.InputModels;
using FitnessClub.BLL.Models.WorkoutModels.OutputModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessClub.BLL.Mapping
{
    public class WorkoutMappingProfile: Profile
    {
        public WorkoutMappingProfile() 
        {
            CreateMap<WorkoutDto, WorkoutOutputModel>();

            CreateMap<WorkoutInputModel, WorkoutDto>();
        }
    }
}
