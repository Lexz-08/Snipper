using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Snipper
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

			Application.Run(new Form1());
		}

		private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs e)
		{
			using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream("Snipper.Transitions.dll"))
			{
				byte[] dll = new byte[s.Length];
				s.Read(dll, 0, dll.Length);
				return Assembly.Load(dll);
			}
		}
	}
}
