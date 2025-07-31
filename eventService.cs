using System;
using System.Collections.Generic;
using System.Linq;

public class EventService
{
    private List<EventData> events = new()
    {
        new EventData { Id = 1, Name = "Tech Expo 2024", Date = new DateTime(2024, 11, 12), Location = "Tokyo Big Sight" },
        new EventData { Id = 2, Name = "Innovation Summit", Date = new DateTime(2024, 12, 5), Location = "Raipur Convention Center" }
    };

    public List<EventData> GetAllEvents() => events;
    public EventData GetEventById(int id) => events.FirstOrDefault(e => e.Id == id);
}
