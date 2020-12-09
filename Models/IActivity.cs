using System;

namespace TMmvc.Models
{
    public interface IActivity
    {

        int Id { get; set; }
        ActivityType ActivityType { get; set; }
        string Title { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; } // TODO controllo che sia successiva alla start
        ActivityState State { get; set; }
    }

}
