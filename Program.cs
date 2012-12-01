using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SleepMon
{
	static class Program
	{
		private static int SC_MONITORPOWER = 0xF170;
		private static uint WM_SYSCOMMAND = 0x0112;

		[DllImport("user32.dll")]
		static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			dummy form1 = new dummy();

			SendMessage(form1.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)2);
		}
	}
}
