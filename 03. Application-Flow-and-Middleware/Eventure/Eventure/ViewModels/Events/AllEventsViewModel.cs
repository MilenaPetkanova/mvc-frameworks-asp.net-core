namespace Eventure.ViewModels.Events
{
    using System.Collections.Generic;

    public class AllEventsViewModel
    {
        public AllEventsViewModel()
        {
            this.AllEvents = new List<EventViewModel>();
        }

        public ICollection<EventViewModel> AllEvents { get; set; }
    }
}
