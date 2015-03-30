#!/usr/bin/python

import pygtk
pygtk.require('2.0')
import gtk
from gtk import gdk

def destroy(widget, data=None):
    gtk.main_quit()

w = gtk.Window(gtk.WINDOW_TOPLEVEL)
w.connect('destroy', destroy)

v = gtk.TextView()
v.set_editable(False)
b = v.get_buffer()

w.add(v)
w.show_all()

b.insert_at_cursor("Hello")
b.insert_pixbuf(b.get_end_iter(), gdk.pixbuf_new_from_file_at_size("1F389.png", -1, 16))

gtk.main()
