using System;

using Gtk;


namespace gtkhi
{
	class gtkhi {
 
        static void Main()
        // This program has been edited by the editor in MD 8.1.5 and works!
        {
                Application.Init ();
 
                Window w = new Window ("Hello Gtk# 2.12.0 on dotdevelop-main");
				w.SetDefaultSize (450, 200);

                w.DeleteEvent += delete_event;
                w.Show();
		   
                Application.Run ();
 
        }
        
        static void delete_event (object obj, DeleteEventArgs args)
        {
			// Quit application when window is deleted (closed)   
			Application.Quit ();
        }
 

	}
}

