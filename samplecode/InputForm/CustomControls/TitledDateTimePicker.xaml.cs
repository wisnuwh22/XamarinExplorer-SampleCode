using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace samplecode.InputForm
{
    public partial class TitledDateTimePicker : ContentView
    {
        public TitledDateTimePicker()
        {
            InitializeComponent();
            LabelTitle.BindingContext = this;
            DatePickerContent.BindingContext = this;
            TimePickerContent.BindingContext = this;
        }

        public static BindableProperty SelectedDateTimeProperty =
            BindableProperty.Create(nameof(SelectedDateTime), typeof(DateTime?), typeof(TitledDateTimePicker), DateTime.Now, BindingMode.TwoWay);

        public DateTime? SelectedDateTime
        {
            get => (DateTime?)GetValue(SelectedDateTimeProperty);
            set => SetValue(SelectedDateTimeProperty, value);
        }

        public static BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(TitledDateTimePicker), null, BindingMode.TwoWay);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static BindableProperty TitleColorProperty =
            BindableProperty.Create(nameof(TitleColor), typeof(string), typeof(TitledDateTimePicker), "#cccccc", BindingMode.TwoWay);

        public string TitleColor
        {
            get { return (string)GetValue(TitleColorProperty); }
            set { SetValue(TitleColorProperty, value); }
        }

        public static BindableProperty DatetimeProperty =
            BindableProperty.Create(nameof(Datetime), typeof(DateTime), typeof(TitledDateTimePicker), DateTime.Today, BindingMode.TwoWay);

        public DateTime Datetime
        {
            get => (DateTime)GetValue(DatetimeProperty);
            set => SetValue(DatetimeProperty, value);
        }

        public static BindableProperty TimespanProperty =
            BindableProperty.Create(nameof(Timespan), typeof(TimeSpan), typeof(TitledDateTimePicker), DateTime.Today.TimeOfDay, BindingMode.TwoWay);

        public TimeSpan Timespan
        {
            get => (TimeSpan)GetValue(TimespanProperty);
            set => SetValue(TimespanProperty, value);
        }

        public static BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(int), typeof(TitledDateTimePicker), 12, BindingMode.TwoWay);

        public int FontSize
        {
            get => (int)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public static BindableProperty IsEditableProperty =
            BindableProperty.Create(nameof(IsEditable), typeof(bool), typeof(TitledDateTimePicker), true, BindingMode.TwoWay);

        public bool IsEditable
        {
            get => (bool)GetValue(IsEditableProperty);
            set => SetValue(IsEditableProperty, value);
        }



        void Handle_DateSelected(object sender, DateChangedEventArgs e)
        {
            UpdateSelectedDatime();
        }

        void Handle_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Time")
            {
                UpdateSelectedDatime();
            }
        }

        void Handle_BindingContextChanged(object sender, EventArgs e)
        {
            if (SelectedDateTime.HasValue)
                SetDateTime();
        }

        void UpdateSelectedDatime()
        {
            SelectedDateTime = Datetime.Add(Timespan);
        }

        void SetDateTime()
        {
            Datetime = SelectedDateTime.Value;
            Timespan = SelectedDateTime.Value.TimeOfDay;
        }
    }
}
