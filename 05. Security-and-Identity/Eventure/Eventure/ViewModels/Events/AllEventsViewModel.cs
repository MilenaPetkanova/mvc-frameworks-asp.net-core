namespace Eventure.ViewModels.Events
{
    using System.Collections.Generic;

    public class AllEventsViewModel
    {
        public AllEventsViewModel()
        {
            this.Events = new List<EventViewModel>();
        }

        public ICollection<EventViewModel> Events { get; set; }
    }
}
