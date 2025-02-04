using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private static List<EventModel> events = new List<EventModel>
        {
            new EventModel { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 5, 20), Location = "New York, USA", Description = "Showcasing the latest in tech." },
            new EventModel { Id = 2, Name = "Corporate Meetup", Date = new DateTime(2025, 6, 15), Location = "Berlin, Germany", Description = "Networking for professionals." },
            new EventModel { Id = 3, Name = "Startup Pitch Night", Date = new DateTime(2025, 7, 10), Location = "San Francisco, USA", Description = "Pitch your ideas to investors." }
        };

        public static List<EventModel> GetEvents() => events;

        public static void AddEvent(EventModel newEvent)
        {
            newEvent.Id = events.Max(e => e.Id) + 1;
            events.Add(newEvent);
        }
    }
}
