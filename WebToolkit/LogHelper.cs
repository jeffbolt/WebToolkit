using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace WebToolkit
{
	public static class LogHelper
	{
		private const string StandardFormat = "MM/dd/yyyy hh:mm:ss:fff tt";
		private const string MilitaryFormat = "MM/dd/yyyy HH:mm:ss:fff";

		public enum TimeFormat
		{
			None = -1,
			Standard = 0,
			Military = 1,
			UnixTime = 2
		}

		public enum TimeZone
		{
			Local = 0,
			Utc = 1
		}

		/// <summary>
		/// Returns the log file path.
		/// </summary>
		/// <returns></returns>
		public static string GetLogFilePath()
		{
			string appDir = Directory.GetCurrentDirectory();
			string appName = Assembly.GetExecutingAssembly().GetName().Name;
			string fileName = string.Concat(appName, ".log");
			return Path.Combine(appDir, fileName);
		}

		/// <summary>
		/// Writes a message to the log file, and optionally prepend a timestamp.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="timeFormat"></param>
		/// <param name="timeZone"></param>
		public static void WriteLine(string message, TimeFormat timeFormat = TimeFormat.Standard, TimeZone timeZone = TimeZone.Local)
		{
			Write(message, timeFormat, timeZone);
		}

		private static void Write(string message, TimeFormat format, TimeZone timeZone)
		{
			try
			{
				Debug.WriteLine(message);
				Console.WriteLine(message);

				string filePath = GetLogFilePath();
				DateTime dtNow;

				if (timeZone == TimeZone.Utc)
					dtNow = DateTime.Now.ToUniversalTime();
				else
					dtNow = DateTime.Now;

				using (StreamWriter writer = File.AppendText(filePath))
				{
					if (format == TimeFormat.Standard)
						writer.WriteLine(dtNow.ToString(StandardFormat));
					else if (format == TimeFormat.Military)
						writer.WriteLine(dtNow.ToString(MilitaryFormat));
					else if (format == TimeFormat.UnixTime)
						writer.WriteLine(UnixTimeHelper.ToUnixTime(DateTime.Now));

					writer.WriteLine(message);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}
	}
}

