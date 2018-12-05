namespace Eventure.ViewModels.Events
{
    using Eventure.Helpers;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class EventViewModel
    {
        public string Id { get; set; }

        public string UUID { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [MinLength(10, ErrorMessage = Constants.EVENT_NAME_RESTRICTION_LENGHT)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        public string Place { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [DataType(DataType.Date, ErrorMessage = Constants.EVENT_DATE_RESTRICTION_VALID)]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [DataType(DataType.Date, ErrorMessage = Constants.EVENT_DATE_RESTRICTION_VALID)]
        public DateTime End { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [Range(0, Int32.MaxValue, ErrorMessage = Constants.EVENT_TICKETS_RESTRICTION_POSITIVENUMBER)]
        public int TotalTickets { get; set; }

        [Required(ErrorMessage = Constants.RESTRICTION_NOTNULL)]
        [Range(0.01, 999999999, ErrorMessage = Constants.EVENT_PRICE_RESTRICTION_DECIMAL)]
        public decimal PricePerTicket { get; set; }

        public string StartToStr => this.Start.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture);

        public string EndToStr => this.End.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture);
    }
}
