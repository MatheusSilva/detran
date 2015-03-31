using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Detran 
{
    /// <summary>classe Main</summary>
	static class Program
	{
		/// <summary>
		/// O principal ponto de entrada para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMulta());
		}
	}
}
