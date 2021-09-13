using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Transitions;

namespace Snipper
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			pnlTitleBar.MouseDown += new MouseEventHandler(DragForm);
			lblTitle.MouseDown += new MouseEventHandler(DragForm);

			pnlClose.Click += new EventHandler(CloseForm);
			pnlMaximize.Click += new EventHandler(MaximizeForm);
			pnlMinimize.Click += new EventHandler(MinimizeForm);

			lblClose.Click += new EventHandler(CloseForm);
			lblMaximize.Click += new EventHandler(MaximizeForm);
			lblMinimize.Click += new EventHandler(MinimizeForm);
		}

		#region Window Functionality
		private struct Native
		{
			[DllImport("user32.dll")]
			public static extern bool ReleaseCapture();

			[DllImport("user32.dll")]
			private static extern int SendMessage(IntPtr HWnd, int Msg, int WParam, int LParam);

			public static int SendMessage(IntPtr HWnd, int Msg, int WParam) => SendMessage(HWnd, Msg, WParam, 0);
		}

		/// <summary>
		/// Gets a snapshot of the screen based on the coordinates specified.
		/// </summary>
		/// <param name="X">The x-location of the snapshot from the screen.</param>
		/// <param name="Y">The y-location of the snapshot from the screen.</param>
		/// <param name="Width">The width of the snapshot from the screen.</param>
		/// <param name="Height">The height of the snapshot from the screen.</param>
		/// <returns>A bitmap containing a snaphshot of the screen based on the specified parameters.</returns>
		private Bitmap ScreenSnip(int X, int Y, int Width, int Height)
		{
			Bitmap bmp = new Bitmap(Width, Height);
			using (Graphics gfx = Graphics.FromImage(bmp))
			{
				gfx.CopyFromScreen(new Point(X, Y), new Point(0, 0), new Size(Width, Height), CopyPixelOperation.SourceCopy);
			}
			return bmp;
		}

		private void DragForm(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Native.ReleaseCapture();
				Native.SendMessage(Handle, 161, 2);
			}
		}

		private void CloseForm(object sender, EventArgs e)
		{
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity -= 0.05;

				if (Opacity <= 0)
				{
					t.Enabled = false;
					Opacity = 0;
					Close();
				}
			};
			t.Start();
		}
		private void MaximizeForm(object sender, EventArgs e)
		{
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity -= 0.05;

				if (Opacity <= 0)
				{
					t.Enabled = false;
					Opacity = 0;

					switch (WindowState)
					{
						case FormWindowState.Maximized: WindowState = FormWindowState.Normal; break;
						case FormWindowState.Normal: WindowState = FormWindowState.Maximized; break;
					}

					Timer t2 = new Timer { Interval = 15 };
					t2.Tick += (ss, eee) =>
					{
						Opacity += 0.05;

						if (Opacity >= 1)
						{
							t2.Enabled = false;
							Opacity = 1;
						}
					};
					t2.Start();
				}
			};
			t.Start();
		}
		private void MinimizeForm(object sender, EventArgs e)
		{
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity -= 0.05;

				if (Opacity <= 0)
				{
					t.Enabled = false;
					Opacity = 0;
					WindowState = FormWindowState.Minimized;
				}
			};
			t.Start();
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			Opacity = 0;
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity += 0.05;

				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}
		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);

			if (WindowState == FormWindowState.Minimized) Opacity = 0;
			Timer t = new Timer { Interval = 15 };
			t.Tick += (s, ee) =>
			{
				Opacity += 0.05;

				if (Opacity >= 1)
				{
					t.Enabled = false;
					Opacity = 1;
				}
			};
			t.Start();
		}

		protected override void WndProc(ref Message m)
		{
			try
			{
				switch (WindowState)
				{
					case FormWindowState.Maximized: lblMaximize.Text = "2"; break;
					case FormWindowState.Normal: lblMaximize.Text = "1"; break;
				}
			}
			catch { return; }

			base.WndProc(ref m);
		}

		private void Close_MSEnter(object sender, EventArgs e)
		{
			Transition.run(pnlClose, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
			Transition.run(lblClose, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
		}
		private void Close_MSLeave(object sender, EventArgs e)
		{
			Transition.run(pnlClose, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
			Transition.run(lblClose, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
		}

		private void Maximize_MSEnter(object sender, EventArgs e)
		{
			Transition.run(pnlMaximize, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
			Transition.run(lblMaximize, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
		}
		private void Maximize_MSLeave(object sender, EventArgs e)
		{
			Transition.run(pnlMaximize, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
			Transition.run(lblMaximize, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
		}

		private void Minimize_MSEnter(object sender, EventArgs e)
		{
			Transition.run(pnlMinimize, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
			Transition.run(lblMinimize, "BackColor", Color.Gainsboro, new TransitionType_Linear(70));
		}
		private void Minimize_MSLeave(object sender, EventArgs e)
		{
			Transition.run(pnlMinimize, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
			Transition.run(lblMinimize, "BackColor", SystemColors.Control, new TransitionType_Linear(70));
		}
		#endregion

		private void TakeSnapshot(object sender, EventArgs e)
		{
			int x = (int)numXLocation.Value;
			int y = (int)numYLocation.Value;
			int w = (int)numWidth.Value;
			int h = (int)numHeight.Value;

			picSnapshot.Image = ScreenSnip(x, y, w, h);
		}
		private void SaveSnapshot(object sender, EventArgs e)
		{
			if (picSnapshot.Image != null)
			{
				using (SaveFileDialog sfd = new SaveFileDialog
				{
					Title = "Please choose where to save the snapshot to...",
					Filter = "Bitmap|*.bmp|Joint Photographic Experts Groups|*.jpeg; *.jpg|Portable Network Graphics|*.png|Supported Types|*.bmp; *.jpeg; *.jpg; *.png",
					FilterIndex = 6,
				})
				{
					if (sfd.ShowDialog() == DialogResult.OK)
					{
						string imageFile = sfd.FileName;
						string extension = imageFile.Split('.')[1];

						switch (extension)
						{
							case "bmp": picSnapshot.Image.Save(imageFile, ImageFormat.Bmp); break;
							case "jpeg": picSnapshot.Image.Save(imageFile, ImageFormat.Jpeg); break;
							case "jpg": picSnapshot.Image.Save(imageFile, ImageFormat.Jpeg); break;
							case "png": picSnapshot.Image.Save(imageFile, ImageFormat.Png); break;
						}
					}
				}
			}
			else MessageBox.Show("A snapshot is required in order to save it to an image file.", "Snapshot Required",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
