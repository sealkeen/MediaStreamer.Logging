using System.Collections.ObjectModel;

namespace MediaStreamer.Logging
{
    public class LogData
    {
        public static ObservableCollection<LogRecord> LogList { get; set; } = new ObservableCollection<LogRecord>();
    }
}