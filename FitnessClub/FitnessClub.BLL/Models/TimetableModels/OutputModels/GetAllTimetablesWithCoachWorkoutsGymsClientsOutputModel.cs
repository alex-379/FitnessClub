﻿using FitnessClub.BLL.Models.GymModels;
using FitnessClub.BLL.Models.PersonModels.OutputModels;
using FitnessClub.BLL.Models.SportTypeModels;
using FitnessClub.BLL.Models.WorkoutModels.OutputModels;
using FitnessClub.DAL;
using FitnessClub.DAL.Dtos;

namespace FitnessClub.BLL.Models.TimetableModels.OutputModels
{
    public class GetAllTimetablesWithCoachWorkoutsGymsClientsOutputModel
    {
        public int Id { get; set; }

        public string DateTime { get; set; }

        public CoachForTimetableOutputModel Coach { get; set; }

        public List<ClientForTimetableOutputModel> Clients { get; set; }

        public WorkoutOutputModel Workout { get; set; }

        public GymOutputModel Gym { get; set; }

        public SportTypeOutputModel SportType { get; set; }
    }
}
