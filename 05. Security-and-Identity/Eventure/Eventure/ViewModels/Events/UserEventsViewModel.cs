namespace Eventure.ViewModels.Events
{
    using System.Collections.Generic;

    public class UserEventsViewModel
    {
        public UserEventsViewModel()
        {
            this.Events = new List<EventViewModel>();
        }

        public ICollection<EventViewModel> Events { get; set; }

    }
}
