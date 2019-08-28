using Timesheet.Model;

namespace Timesheet.Interfaces
{
    public interface ITimesheetRepository
    {
        void Save(Timesheet timesheet);
    }
}