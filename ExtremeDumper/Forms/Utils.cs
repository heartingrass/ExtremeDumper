using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtremeDumper.Forms;

static class Utils {
	public static Color DotNetColor => Color.YellowGreen;

	public static void EnableDoubleBuffer(ListView listView) {
		typeof(ListView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, listView, new object[] { true });
	}

	public static void RefreshListView<T>(ListView listView, IEnumerable<T> sources, Func<T, ListViewItem> itemCreator, int layoutInterval) {
		listView.SuspendLayout();
		listView.Items.Clear();

		int c = 0;
		foreach (var source in sources) {
			listView.Items.Add(itemCreator(source));
			if (layoutInterval != -1 && c++ % layoutInterval == 0)
				listView.PerformLayout();
		}

		listView.ResumeLayout();
		listView.AutoResizeColumns(false);
	}

	// Only used with very slow sources
	public static async Task RefreshListViewAsync<T>(ListView listView, IEnumerable<T> sources, Func<T, ListViewItem> itemCreator, int layoutInterval) {
		listView.SuspendLayout();
		listView.Items.Clear();

		var buffer = await Task.Run(() => sources.ToArray());
		int c = 0;
		foreach (var source in buffer) {
			listView.Items.Add(itemCreator(source));
			if (layoutInterval != -1 && c++ % layoutInterval == 0)
				listView.PerformLayout();
		}

		listView.ResumeLayout();
		listView.AutoResizeColumns(false);
	}

	public static void ScaleByDpi(Form form) {
		using var g = Graphics.FromHwnd(IntPtr.Zero);
		var size = form.ClientSize;
		size.Width = (int)(size.Width * (g.DpiX / 96));
		size.Height = (int)(size.Height * (g.DpiY / 96));
		form.ClientSize = size;
	}
}
