using System.Collections.Generic;

public class AttendanceService
{
    private Dictionary<int, List<string>> attendanceRecords = new();

    public void RecordAttendance(int eventId, string userName)
    {
        if (!attendanceRecords.ContainsKey(eventId))
            attendanceRecords[eventId] = new();

        attendanceRecords[eventId].Add(userName);
    }

    public List<string> GetAttendees(int eventId) =>
        attendanceRecords.TryGetValue(eventId, out var list) ? list : new List<string>();
}
