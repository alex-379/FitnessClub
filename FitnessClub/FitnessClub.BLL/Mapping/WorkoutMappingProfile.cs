using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.DAL.Dtos;
using FitnessClub.BLL;
using FitnessClub.BLL.Models.WorkoutModels.OutputModels;


namespace FitnessClub.BLL.Mapping
{
    public class WorkoutMappingProfile: Profile
    {
        public WorkoutMappingProfile() 
        {
            CreateMap<WorkoutDto, WorkoutOutputModel>();
        }
    }
}
