using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFacturaClicked (object sender, EventArgs e)

	{
		double pt1 = double.Parse (this.p1.Text);
		double pt2 = double.Parse (this.p2.Text);
		double pt3 = double.Parse (this.p3.Text);



		double subtotal = pt1 + pt2 + pt3;
		this.sub.Text = subtotal.ToString ();
		double iiv = subtotal * .16 ;
		this.Iva.Text = iiv.ToString ();
		double total = subtotal + iiv;
		this.tot.Text = total.ToString ();


		

	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.p1.Text = "";
		this.p2.Text = "";
		this.p3.Text = "";
		this.sub.Text = "";
		this.Iva.Text = "";
		this.tot.Text = "";

	}
	}