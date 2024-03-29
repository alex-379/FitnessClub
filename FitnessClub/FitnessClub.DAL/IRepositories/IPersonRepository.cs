﻿using FitnessClub.DAL.Dtos;

namespace FitnessClub.DAL.IRepositories
{
    public interface IPersonRepository
    {
        public int? AddPerson(PersonDto person);

        public void AddCoachSportType(int coachId, int sportTypeId);

        public void AddCoachWorkoutType(int coachId, int workoutTypeId);

        public List<PersonDto> GetAllPersons();

        public PersonDto GetPersonById(int id);
        
        public void UpdatePersonOnId(PersonDto person);

        public void DeletePersonById(int id);

        public void UndeletePersonById(int id);

        public void DeleteOneTimePasswordByPersonId(int id);

        public void DeleteCoachSportType(int coachId, int sportTypeId);

        public void DeleteCoachWorkoutType(int coachId, int workoutTypeId);

        public List<PersonDto> GetAllPersonsByRoleId(int roleId);

        public List<PersonDto> GetAllCoachesWithSportTypesWorkoutTypes();

        public PersonDto GetCoachWithSportTypesWorkoutTypesByCoachId(int coachId);
    }
}