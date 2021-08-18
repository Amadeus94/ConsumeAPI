using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly DataContext _context;
        public ActivityRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ActivityEntity>> GetActivitiesAsync()
        {
            return await _context.Activities.ToListAsync();
        }

        public async Task<ActivityEntity> GetActivityAsync(int id)
        {
            return await _context.Activities.FindAsync(id);
        }

        // Returns true if changes have been made
        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;

        }

        public void StoreEntity(ActivityEntity activity)
        {
            Console.WriteLine("Storing ActivityEntity to Database...\n");


            Console.WriteLine($"Activity: {activity.Activity}");
            Console.WriteLine($"Accessibility: {activity.Accessibility}");
            Console.WriteLine($"Key: {activity.Key}");
            Console.WriteLine($"Participants: {activity.Participant}");
            Console.WriteLine($"Price:  {activity.Price}");
            Console.WriteLine($"Stored Timestamp: {activity.Stored}");

            _context.Activities.Add(activity);
            _context.SaveChangesAsync();
        }
    }
}