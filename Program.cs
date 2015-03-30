using System;
using Gtk;
using Gdk;

namespace bufferimage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			GLib.Thread.Init();
			Gtk.Application.Init("foo", ref args);

			var w = new Gtk.Window(Gtk.WindowType.Toplevel);
			var v = new Gtk.TextView();
			var b = v.Buffer;

			b.InsertAtCursor("foo");
			var iter = b.EndIter;
			b.InsertPixbuf(ref iter, new Pixbuf("1F389.png"));

			w.Add(v);
			w.ShowAll();

			Gtk.Application.Run();
		}
	}
}
