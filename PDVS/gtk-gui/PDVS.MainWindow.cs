
// This file has been generated by the GUI designer. Do not modify.
namespace PDVS
{
	public partial class MainWindow
	{
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.VSeparator vseparator1;
		
		private global::Gtk.VSeparator vseparator2;
		
		private global::Gtk.DrawingArea drawingarea1;
		
		private global::Gtk.VSeparator vseparator3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView treeviewDllLog;
		
		private global::Gtk.Button btnAdicionar;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Button btnRemover;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ComboBoxEntry cmbOper;
		
		private global::Gtk.Button button9;
		
		private global::Gtk.Button btnCaptura;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView trvPar;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Button buttonLimpaLog;
		
		private global::Gtk.Button btnLimpaParametros;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PDVS.MainWindow
			this.Name = "PDVS.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child PDVS.MainWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.vseparator1 = new global::Gtk.VSeparator ();
			this.vseparator1.Name = "vseparator1";
			this.fixed1.Add (this.vseparator1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.vseparator1]));
			w1.X = 509;
			w1.Y = 168;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.vseparator2 = new global::Gtk.VSeparator ();
			this.vseparator2.Name = "vseparator2";
			this.fixed1.Add (this.vseparator2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.vseparator2]));
			w2.X = 475;
			w2.Y = 163;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.drawingarea1 = new global::Gtk.DrawingArea ();
			this.drawingarea1.Name = "drawingarea1";
			this.fixed1.Add (this.drawingarea1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.drawingarea1]));
			w3.X = 382;
			w3.Y = 120;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.vseparator3 = new global::Gtk.VSeparator ();
			this.vseparator3.Name = "vseparator3";
			this.fixed1.Add (this.vseparator3);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.vseparator3]));
			w4.X = 370;
			w4.Y = 362;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.treeviewDllLog = new global::Gtk.TreeView ();
			this.treeviewDllLog.WidthRequest = 400;
			this.treeviewDllLog.HeightRequest = 450;
			this.treeviewDllLog.CanFocus = true;
			this.treeviewDllLog.Name = "treeviewDllLog";
			this.treeviewDllLog.EnableSearch = false;
			this.treeviewDllLog.HeadersVisible = false;
			this.GtkScrolledWindow1.Add (this.treeviewDllLog);
			this.fixed1.Add (this.GtkScrolledWindow1);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.GtkScrolledWindow1]));
			w6.X = 535;
			w6.Y = 71;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnAdicionar = new global::Gtk.Button ();
			this.btnAdicionar.CanFocus = true;
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.UseUnderline = true;
			this.btnAdicionar.Label = global::Mono.Unix.Catalog.GetString ("Adicionar");
			this.fixed1.Add (this.btnAdicionar);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnAdicionar]));
			w7.X = 191;
			w7.Y = 130;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Parametros");
			this.fixed1.Add (this.label4);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
			w8.X = 27;
			w8.Y = 140;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnRemover = new global::Gtk.Button ();
			this.btnRemover.CanFocus = true;
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.UseUnderline = true;
			this.btnRemover.Label = global::Mono.Unix.Catalog.GetString ("Remover");
			this.fixed1.Add (this.btnRemover);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnRemover]));
			w9.X = 112;
			w9.Y = 130;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("PWINFO_OPERATION");
			this.fixed1.Add (this.label3);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
			w10.X = 25;
			w10.Y = 51;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.cmbOper = global::Gtk.ComboBoxEntry.NewText ();
			this.cmbOper.Name = "cmbOper";
			this.cmbOper.AddTearoffs = true;
			this.fixed1.Add (this.cmbOper);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.cmbOper]));
			w11.X = 183;
			w11.Y = 46;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button9 = new global::Gtk.Button ();
			this.button9.CanFocus = true;
			this.button9.Name = "button9";
			this.button9.UseUnderline = true;
			this.button9.Label = global::Mono.Unix.Catalog.GetString ("Executar");
			this.fixed1.Add (this.button9);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button9]));
			w12.X = 383;
			w12.Y = 45;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnCaptura = new global::Gtk.Button ();
			this.btnCaptura.CanFocus = true;
			this.btnCaptura.Name = "btnCaptura";
			this.btnCaptura.UseUnderline = true;
			this.btnCaptura.Label = global::Mono.Unix.Catalog.GetString ("PW-iPPGetUserData");
			this.fixed1.Add (this.btnCaptura);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnCaptura]));
			w13.X = 24;
			w13.Y = 80;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvPar = new global::Gtk.TreeView ();
			this.trvPar.WidthRequest = 350;
			this.trvPar.HeightRequest = 350;
			this.trvPar.CanFocus = true;
			this.trvPar.Name = "trvPar";
			this.trvPar.EnableSearch = false;
			this.trvPar.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.trvPar);
			this.fixed1.Add (this.GtkScrolledWindow);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.GtkScrolledWindow]));
			w15.X = 28;
			w15.Y = 166;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Log da Aplicação");
			this.fixed1.Add (this.label5);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
			w16.X = 666;
			w16.Y = 41;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.buttonLimpaLog = new global::Gtk.Button ();
			this.buttonLimpaLog.CanFocus = true;
			this.buttonLimpaLog.Name = "buttonLimpaLog";
			this.buttonLimpaLog.UseUnderline = true;
			this.buttonLimpaLog.Label = global::Mono.Unix.Catalog.GetString ("Limpa Log");
			this.fixed1.Add (this.buttonLimpaLog);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonLimpaLog]));
			w17.X = 531;
			w17.Y = 540;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.btnLimpaParametros = new global::Gtk.Button ();
			this.btnLimpaParametros.CanFocus = true;
			this.btnLimpaParametros.Name = "btnLimpaParametros";
			this.btnLimpaParametros.UseUnderline = true;
			this.btnLimpaParametros.Label = global::Mono.Unix.Catalog.GetString ("Limpa Parametros");
			this.fixed1.Add (this.btnLimpaParametros);
			global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnLimpaParametros]));
			w18.X = 27;
			w18.Y = 536;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1139;
			this.DefaultHeight = 694;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnAdicionar.Clicked += new global::System.EventHandler (this.OnBtnAdicionarClicked);
			this.btnRemover.Clicked += new global::System.EventHandler (this.OnBtnRemoverClicked);
			this.cmbOper.Changed += new global::System.EventHandler (this.OnCmbOperChanged);
			this.button9.Clicked += new global::System.EventHandler (this.OnButtonExecutarClicked);
			this.btnCaptura.Clicked += new global::System.EventHandler (this.OnBtnCapturaClicked);
			this.trvPar.SelectCursorRow += new global::Gtk.SelectCursorRowHandler (this.OnTrvParSelectCursorRow);
			this.buttonLimpaLog.Clicked += new global::System.EventHandler (this.OnButtonLimpaLogClicked);
			this.btnLimpaParametros.Clicked += new global::System.EventHandler (this.OnBtnLimpaParametrosClicked);
		}
	}
}
