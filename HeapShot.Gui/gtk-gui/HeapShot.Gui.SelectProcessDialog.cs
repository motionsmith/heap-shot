
// This file has been generated by the GUI designer. Do not modify.
namespace HeapShot.Gui
{
	public partial class SelectProcessDialog
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Label label1;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TreeView list;
		private global::Gtk.Label label2;
		private global::Gtk.Button button1;
		private global::Gtk.Button button8;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget HeapShot.Gui.SelectProcessDialog
			this.Events = ((global::Gdk.EventMask)(256));
			this.Name = "HeapShot.Gui.SelectProcessDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Select process");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child HeapShot.Gui.SelectProcessDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Events = ((global::Gdk.EventMask)(256));
			w1.Name = "dialog_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog_VBox.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(12));
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = "Select a process:";
			this.vbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.list = new global::Gtk.TreeView ();
			this.list.CanFocus = true;
			this.list.Name = "list";
			this.scrolledwindow1.Add (this.list);
			this.vbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
			w4.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.WidthRequest = 492;
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Only Mono processes started with the option --profile=heap-shot are listed.");
			this.label2.UseMarkup = true;
			this.label2.Wrap = true;
			this.vbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label2]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			w1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox1]));
			w6.Position = 0;
			// Internal child HeapShot.Gui.SelectProcessDialog.ActionArea
			global::Gtk.HButtonBox w7 = this.ActionArea;
			w7.Events = ((global::Gdk.EventMask)(256));
			w7.Name = "HeapShot.Gui.SelectProcessDialog_ActionArea";
			w7.Spacing = 10;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child HeapShot.Gui.SelectProcessDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanDefault = true;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseStock = true;
			this.button1.UseUnderline = true;
			this.button1.Label = "gtk-cancel";
			this.AddActionWidget (this.button1, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.button1]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child HeapShot.Gui.SelectProcessDialog_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button8 = new global::Gtk.Button ();
			this.button8.CanDefault = true;
			this.button8.CanFocus = true;
			this.button8.Name = "button8";
			this.button8.UseStock = true;
			this.button8.UseUnderline = true;
			this.button8.Label = "gtk-ok";
			this.AddActionWidget (this.button8, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.button8]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 531;
			this.DefaultHeight = 425;
			this.Show ();
			this.Response += new global::Gtk.ResponseHandler (this.OnResponse);
		}
	}
}
