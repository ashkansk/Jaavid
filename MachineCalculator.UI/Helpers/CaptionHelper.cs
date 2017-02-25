using PostSharp.Patterns.Model;

namespace MachineCalculator.UI.Helpers
{
	[NotifyPropertyChanged]
	public class CaptionHelper
	{
		public string MachineName { get; set; }
		public string WorkQuantityLabel { get; set; }
		public string WorkMetricUnit { get; set; }
		public string EnvFactorLabel { get; set; }

		public string MachineTypeLabel { get { return string.Format("نوع {0}", MachineName); } }
		public string MachinePerformanceLabel { get { return string.Format("توان {0}", MachineName); } }
		public string MachineRealPerformanceLabel { get { return string.Format("توان واقعی {0}", MachineName); } }
		public string MachineRequiredCountLabel { get { return string.Format("تعداد {0} مورد نیاز", MachineName); } }
		public string MachineRoundedRequiredCountLabel { get { return string.Format("تعداد {0} مورد نیاز اصلاح شده", MachineName); } }
	}
}
