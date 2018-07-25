using System;
namespace samplecode.InputForm
{
    public class InputFormViewModel : BaseViewModel
    {
        public string TitleColor { get; set; }
        public string StringEntryPlaceholer { get; set; }
        public string DateTimeTitle { get; set; }
        public string EditorPlaceholder { get; set; }

        private string name;
        public string Name 
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private DateTime estimatedDateTime;
        public DateTime EstimatedDateTime
        {
            get => estimatedDateTime;
            set => SetProperty(ref estimatedDateTime, value);
        }

        public string GetEstimatedDateTime
        {
            get => EstimatedDateTime.ToString("dd MMM yyyy HH:mm");
        }

        private string description;
        public string Desription
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public InputFormViewModel()
        {
            TitleColor = "#B71C1C";
            StringEntryPlaceholer = "Name";
            DateTimeTitle = "Estimated DateTime";
            EditorPlaceholder = "Description";

            EstimatedDateTime = DateTime.Now;
        }
    }
}
