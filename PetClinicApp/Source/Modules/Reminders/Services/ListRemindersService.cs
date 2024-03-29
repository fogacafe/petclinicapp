﻿using PetClinicApp.Source.Modules.Reminders.DTO;
using PetClinicApp.Source.Modules.Reminders.Entities;
using PetClinicApp.Source.Modules.Reminders.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetClinicApp.Source.Modules.Reminders.Services
{
    public class ListRemindersService
    {
        private readonly IRemindersRepository remindersRepository;
        public ListRemindersService(IRemindersRepository remindersRepository)
        {
            this.remindersRepository = remindersRepository;
        }

        public async Task<List<ReminderDTO>> ExecuteAsync(long petId, string search)
        {
            var reminders = await remindersRepository.ListByPetId(petId, search);

            return reminders.Select(r => r.ToDTO()).ToList();
        }
    }
}
