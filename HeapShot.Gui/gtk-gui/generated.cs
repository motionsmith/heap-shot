// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Stetic {
    
    
    internal class Gui {
        
        public static void Build(object obj, System.Type type) {
            Stetic.Gui.Build(obj, type.FullName);
        }
        
        public static void Build(object obj, string id) {
            System.Collections.Hashtable bindings = new System.Collections.Hashtable();
            if ((id == "HeapShot.Gui.SelectProcessDialog")) {
                Gtk.Dialog cobj = ((Gtk.Dialog)(obj));
                // Widget HeapShot.Gui.SelectProcessDialog
                cobj.Title = "Select process";
                cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                cobj.HasSeparator = false;
                cobj.Events = ((Gdk.EventMask)(256));
                cobj.Name = "HeapShot.Gui.SelectProcessDialog";
                // Internal child HeapShot.Gui.SelectProcessDialog.VBox
                Gtk.VBox w1 = cobj.VBox;
                w1.BorderWidth = ((uint)(2));
                w1.Events = ((Gdk.EventMask)(256));
                w1.Name = "dialog_VBox";
                // Container child dialog_VBox.Gtk.Box+BoxChild
                Gtk.VBox w2 = new Gtk.VBox();
                w2.Spacing = 6;
                w2.BorderWidth = ((uint)(12));
                w2.Events = ((Gdk.EventMask)(0));
                w2.Name = "vbox1";
                // Container child vbox1.Gtk.Box+BoxChild
                Gtk.Label w3 = new Gtk.Label();
                w3.LabelProp = "Select a process:";
                w3.Xalign = 0F;
                w3.Events = ((Gdk.EventMask)(0));
                w3.Name = "label1";
                bindings["label1"] = w3;
                w2.Add(w3);
                Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w2[w3]));
                w4.Position = 0;
                w4.Expand = false;
                w4.Fill = false;
                // Container child vbox1.Gtk.Box+BoxChild
                Gtk.ScrolledWindow w5 = new Gtk.ScrolledWindow();
                w5.VscrollbarPolicy = ((Gtk.PolicyType)(1));
                w5.HscrollbarPolicy = ((Gtk.PolicyType)(1));
                w5.ShadowType = ((Gtk.ShadowType)(1));
                w5.CanFocus = true;
                w5.Events = ((Gdk.EventMask)(0));
                w5.Name = "scrolledwindow1";
                // Container child scrolledwindow1.Gtk.Container+ContainerChild
                Gtk.TreeView w6 = new Gtk.TreeView();
                w6.CanFocus = true;
                w6.Events = ((Gdk.EventMask)(0));
                w6.Name = "list";
                bindings["list"] = w6;
                w5.Add(w6);
                bindings["scrolledwindow1"] = w5;
                w2.Add(w5);
                Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(w2[w5]));
                w8.Position = 1;
                // Container child vbox1.Gtk.Box+BoxChild
                Gtk.Label w9 = new Gtk.Label();
                w9.LabelProp = "<b>Warning:</b> Memory snapshots can only be taken from mono processes started with the option \"--profile=heap-shot\". If you select a process which was not started using this option, the process will be stopped.";
                w9.UseMarkup = true;
                w9.Wrap = true;
                w9.Xalign = 0F;
                w9.Events = ((Gdk.EventMask)(0));
                w9.Name = "label2";
                w9.WidthRequest = 492;
                bindings["label2"] = w9;
                w2.Add(w9);
                Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w2[w9]));
                w10.Position = 2;
                w10.Expand = false;
                w10.Fill = false;
                bindings["vbox1"] = w2;
                w1.Add(w2);
                Gtk.Box.BoxChild w11 = ((Gtk.Box.BoxChild)(w1[w2]));
                w11.Position = 0;
                bindings["dialog_VBox"] = w1;
                // Internal child HeapShot.Gui.SelectProcessDialog.ActionArea
                Gtk.HButtonBox w12 = cobj.ActionArea;
                w12.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
                w12.Spacing = 10;
                w12.BorderWidth = ((uint)(5));
                w12.Events = ((Gdk.EventMask)(256));
                w12.Name = "HeapShot.Gui.SelectProcessDialog_ActionArea";
                // Container child HeapShot.Gui.SelectProcessDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
                Gtk.Button w13 = new Gtk.Button();
                w13.UseStock = true;
                w13.UseUnderline = true;
                w13.CanFocus = true;
                w13.Events = ((Gdk.EventMask)(0));
                w13.Name = "button1";
                w13.CanDefault = true;
                w13.Label = "gtk-cancel";
                bindings["button1"] = w13;
                cobj.AddActionWidget(w13, -6);
                Gtk.ButtonBox.ButtonBoxChild w14 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[w13]));
                w14.Expand = false;
                w14.Fill = false;
                // Container child HeapShot.Gui.SelectProcessDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
                Gtk.Button w15 = new Gtk.Button();
                w15.UseStock = true;
                w15.UseUnderline = true;
                w15.CanFocus = true;
                w15.Events = ((Gdk.EventMask)(0));
                w15.Name = "button8";
                w15.CanDefault = true;
                w15.Label = "gtk-ok";
                bindings["button8"] = w15;
                cobj.AddActionWidget(w15, -5);
                Gtk.ButtonBox.ButtonBoxChild w16 = ((Gtk.ButtonBox.ButtonBoxChild)(w12[w15]));
                w16.Position = 1;
                w16.Expand = false;
                w16.Fill = false;
                bindings["HeapShot.Gui.SelectProcessDialog_ActionArea"] = w12;
                cobj.DefaultWidth = 531;
                cobj.DefaultHeight = 425;
                bindings["HeapShot.Gui.SelectProcessDialog"] = cobj;
                w3.Show();
                w6.Show();
                w5.Show();
                w9.Show();
                w2.Show();
                w1.Show();
                w13.Show();
                w15.Show();
                w12.Show();
                cobj.Show();
                cobj.Response += ((Gtk.ResponseHandler)(System.Delegate.CreateDelegate(typeof(Gtk.ResponseHandler), cobj, "OnResponse")));
            }
            else {
                if ((id == "MainWindow")) {
                    Gtk.Window cobj = ((Gtk.Window)(obj));
                    // Widget MainWindow
                    cobj.Title = "MainWindow";
                    Gtk.UIManager w1 = new Gtk.UIManager();
                    Gtk.ActionGroup w2 = new Gtk.ActionGroup("Default");
                    Gtk.Action w3 = new Gtk.Action("File", "File", null, null);
                    w3.ShortLabel = "File";
                    bindings["File"] = w3;
                    w2.Add(w3, null);
                    Gtk.Action w4 = new Gtk.Action("open", null, null, "gtk-open");
                    w4.IsImportant = true;
                    bindings["open"] = w4;
                    w2.Add(w4, null);
                    Gtk.Action w5 = new Gtk.Action("quit", null, null, "gtk-quit");
                    w5.IsImportant = true;
                    bindings["quit"] = w5;
                    w2.Add(w5, null);
                    Gtk.Action w6 = new Gtk.Action("MemorySnapshot", "Memory snapshot", null, null);
                    w6.ShortLabel = "Memory snapshot";
                    w6.IsImportant = true;
                    bindings["MemorySnapshot"] = w6;
                    w2.Add(w6, null);
                    Gtk.Action w7 = new Gtk.Action("new", null, null, "gtk-new");
                    w7.IsImportant = true;
                    bindings["new"] = w7;
                    w2.Add(w7, null);
                    w1.InsertActionGroup(w2, 0);
                    cobj.AddAccelGroup(w1.AccelGroup);
                    cobj.WindowPosition = ((Gtk.WindowPosition)(4));
                    cobj.Events = ((Gdk.EventMask)(0));
                    cobj.Name = "MainWindow";
                    // Container child MainWindow.Gtk.Container+ContainerChild
                    Gtk.VBox w8 = new Gtk.VBox();
                    w8.Spacing = 6;
                    w8.Events = ((Gdk.EventMask)(0));
                    w8.Name = "vbox1";
                    // Container child vbox1.Gtk.Box+BoxChild
                    w1.AddUiFromString("<ui><toolbar name='toolbar1'><toolitem action='new'/><toolitem action='open'/><toolitem action='quit'/><separator/><toolitem action='MemorySnapshot'/></toolbar></ui>");
                    Gtk.Toolbar w9 = ((Gtk.Toolbar)(w1.GetWidget("/toolbar1")));
                    w9.ShowArrow = false;
                    w9.Tooltips = true;
                    w9.ToolbarStyle = ((Gtk.ToolbarStyle)(3));
                    w9.IconSize = ((Gtk.IconSize)(3));
                    w9.Events = ((Gdk.EventMask)(0));
                    w9.Name = "toolbar1";
                    bindings["toolbar1"] = w9;
                    w8.Add(w9);
                    Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w8[w9]));
                    w10.Position = 0;
                    w10.Expand = false;
                    w10.Fill = false;
                    // Container child vbox1.Gtk.Box+BoxChild
                    HeapShot.Gui.Widgets.ObjectMapViewer w11 = new HeapShot.Gui.Widgets.ObjectMapViewer();
                    w11.Events = ((Gdk.EventMask)(256));
                    w11.Name = "viewer";
                    bindings["viewer"] = w11;
                    w8.Add(w11);
                    Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(w8[w11]));
                    w12.Position = 1;
                    // Container child vbox1.Gtk.Box+BoxChild
                    Gtk.Statusbar w13 = new Gtk.Statusbar();
                    w13.Events = ((Gdk.EventMask)(0));
                    w13.Name = "statusbar1";
                    bindings["statusbar1"] = w13;
                    w8.Add(w13);
                    Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(w8[w13]));
                    w14.Position = 2;
                    w14.Expand = false;
                    w14.Fill = false;
                    bindings["vbox1"] = w8;
                    cobj.Add(w8);
                    cobj.DefaultWidth = 711;
                    cobj.DefaultHeight = 466;
                    bindings["MainWindow"] = cobj;
                    w9.Show();
                    w11.Show();
                    w13.Show();
                    w8.Show();
                    cobj.Show();
                    cobj.DeleteEvent += ((Gtk.DeleteEventHandler)(System.Delegate.CreateDelegate(typeof(Gtk.DeleteEventHandler), cobj, "OnDeleteEvent")));
                    w4.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnOpenActivated")));
                    w5.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnQuitActivated")));
                    w6.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnMemorySnapshotActivated")));
                    w7.Activated += ((System.EventHandler)(System.Delegate.CreateDelegate(typeof(System.EventHandler), cobj, "OnNewActivated")));
                }
            }
            System.Reflection.FieldInfo[] fields = obj.GetType().GetFields(((System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic) | System.Reflection.BindingFlags.Instance));
            for (int n = 0; (n < fields.Length); n = (n + 1)) {
                System.Reflection.FieldInfo field = fields[n];
                object widget = bindings[field.Name];
                if (((widget != null) && field.FieldType.IsInstanceOfType(widget))) {
                    field.SetValue(obj, widget);
                }
            }
        }
    }
    
    internal class ActionGroups {
        
        public static Gtk.ActionGroup GetActionGroup(System.Type type) {
            return Stetic.ActionGroups.GetActionGroup(type.FullName);
        }
        
        public static Gtk.ActionGroup GetActionGroup(string name) {
            return null;
        }
    }
}
