
// This file has been generated by the GUI designer. Do not modify.
namespace punto.gui
{
	public partial class IngresarProductosDialog
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label3;
		private global::Gtk.Alignment alignment3;
		private global::Gtk.VBox vbox6;
		private global::Gtk.Table table1;
		private global::Gtk.CheckButton checkbutton7;
		private global::Gtk.CheckButton checkbutton8;
		private global::Gtk.ComboBox combobox4;
		private global::Gtk.Entry entry12;
		private global::Gtk.Entry entry13;
		private global::Gtk.Entry entry16;
		private global::Gtk.Label label19;
		private global::Gtk.Label label20;
		private global::Gtk.Label label21;
		private global::Gtk.Label label22;
		private global::Gtk.Label label23;
		private global::Gtk.Label label24;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Button BotonAgregarP;
		private global::Gtk.Button button15;
		private global::Gtk.Label label1;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label4;
		private global::Gtk.Alignment alignment4;
		private global::Gtk.VBox vbox7;
		private global::Gtk.Table table2;
		private global::Gtk.Button button65;
		private global::Gtk.Entry entry17;
		private global::Gtk.Entry entry18;
		private global::Gtk.Label label26;
		private global::Gtk.Label label27;
		private global::Gtk.Label label28;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label2;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget punto.gui.IngresarProductosDialog
			this.Name = "punto.gui.IngresarProductosDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child punto.gui.IngresarProductosDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Ypad = 10;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Ingreso de productos de la Base de Datos");
			this.vbox3.Add (this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label3]));
			w2.Position = 0;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			// Container child alignment3.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), true);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(7));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton7 = new global::Gtk.CheckButton ();
			this.checkbutton7.CanFocus = true;
			this.checkbutton7.Name = "checkbutton7";
			this.checkbutton7.Label = global::Mono.Unix.Catalog.GetString ("Pesable");
			this.checkbutton7.DrawIndicator = true;
			this.checkbutton7.UseUnderline = true;
			this.table1.Add (this.checkbutton7);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton7]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XPadding = ((uint)(40));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.checkbutton8 = new global::Gtk.CheckButton ();
			this.checkbutton8.CanFocus = true;
			this.checkbutton8.Name = "checkbutton8";
			this.checkbutton8.Label = global::Mono.Unix.Catalog.GetString ("Vigente");
			this.checkbutton8.DrawIndicator = true;
			this.checkbutton8.UseUnderline = true;
			this.table1.Add (this.checkbutton8);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkbutton8]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.combobox4 = global::Gtk.ComboBox.NewText ();
			this.combobox4.Name = "combobox4";
			this.table1.Add (this.combobox4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.combobox4]));
			w5.TopAttach = ((uint)(5));
			w5.BottomAttach = ((uint)(6));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry12 = new global::Gtk.Entry ();
			this.entry12.CanFocus = true;
			this.entry12.Name = "entry12";
			this.entry12.IsEditable = true;
			this.entry12.InvisibleChar = '●';
			this.table1.Add (this.entry12);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry12]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry13 = new global::Gtk.Entry ();
			this.entry13.CanFocus = true;
			this.entry13.Name = "entry13";
			this.entry13.IsEditable = true;
			this.entry13.InvisibleChar = '●';
			this.table1.Add (this.entry13);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry13]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entry16 = new global::Gtk.Entry ();
			this.entry16.CanFocus = true;
			this.entry16.Name = "entry16";
			this.entry16.IsEditable = true;
			this.entry16.InvisibleChar = '●';
			this.table1.Add (this.entry16);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.entry16]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Codigo de Barra: ");
			this.table1.Add (this.label19);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label19]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Familia:");
			this.table1.Add (this.label20);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label20]));
			w10.TopAttach = ((uint)(5));
			w10.BottomAttach = ((uint)(6));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("       Precio Venta:");
			this.table1.Add (this.label21);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label21]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Vigente:");
			this.table1.Add (this.label22);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label22]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("        Nombre:");
			this.table1.Add (this.label23);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label23]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("Pesable:");
			this.table1.Add (this.label24);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label24]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.table1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.table1]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			this.alignment3.Add (this.vbox6);
			this.vbox3.Add (this.alignment3);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.alignment3]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.BotonAgregarP = new global::Gtk.Button ();
			this.BotonAgregarP.CanFocus = true;
			this.BotonAgregarP.Name = "BotonAgregarP";
			this.BotonAgregarP.UseUnderline = true;
			this.BotonAgregarP.Label = global::Mono.Unix.Catalog.GetString ("Agregar");
			this.hbox1.Add (this.BotonAgregarP);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.BotonAgregarP]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button15 = new global::Gtk.Button ();
			this.button15.CanFocus = true;
			this.button15.Name = "button15";
			this.button15.UseUnderline = true;
			this.button15.Label = global::Mono.Unix.Catalog.GetString ("Borrar");
			this.hbox1.Add (this.button15);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button15]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			this.notebook1.Add (this.vbox3);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Registrar Producto");
			this.notebook1.SetTabLabel (this.vbox3, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Ypad = 10;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Modificar productos de la Base de Datos");
			this.vbox4.Add (this.label4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label4]));
			w22.Position = 0;
			w22.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			// Container child alignment4.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), true);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			this.table2.BorderWidth = ((uint)(7));
			// Container child table2.Gtk.Table+TableChild
			this.button65 = new global::Gtk.Button ();
			this.button65.CanFocus = true;
			this.button65.Name = "button65";
			this.button65.UseUnderline = true;
			this.button65.Label = global::Mono.Unix.Catalog.GetString ("Buscar");
			this.table2.Add (this.button65);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table2 [this.button65]));
			w23.TopAttach = ((uint)(1));
			w23.BottomAttach = ((uint)(2));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(1));
			// Container child table2.Gtk.Table+TableChild
			this.entry17 = new global::Gtk.Entry ();
			this.entry17.CanFocus = true;
			this.entry17.Name = "entry17";
			this.entry17.IsEditable = true;
			this.entry17.InvisibleChar = '●';
			this.table2.Add (this.entry17);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry17]));
			w24.TopAttach = ((uint)(5));
			w24.BottomAttach = ((uint)(6));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entry18 = new global::Gtk.Entry ();
			this.entry18.CanFocus = true;
			this.entry18.Name = "entry18";
			this.entry18.IsEditable = true;
			this.entry18.InvisibleChar = '●';
			this.table2.Add (this.entry18);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table2 [this.entry18]));
			w25.TopAttach = ((uint)(3));
			w25.BottomAttach = ((uint)(4));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label26 = new global::Gtk.Label ();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString ("Precio Venta:");
			this.table2.Add (this.label26);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table2 [this.label26]));
			w26.TopAttach = ((uint)(3));
			w26.BottomAttach = ((uint)(4));
			w26.XOptions = ((global::Gtk.AttachOptions)(1));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label27 = new global::Gtk.Label ();
			this.label27.Name = "label27";
			this.label27.Xalign = 0F;
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString ("             Vigente:");
			this.table2.Add (this.label27);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table2 [this.label27]));
			w27.TopAttach = ((uint)(5));
			w27.BottomAttach = ((uint)(6));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("Código Barra:");
			this.table2.Add (this.label28);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.label28]));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox7.Add (this.table2);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.table2]));
			w29.Position = 0;
			this.alignment4.Add (this.vbox7);
			this.vbox4.Add (this.alignment4);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.alignment4]));
			w31.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w32.Position = 2;
			this.notebook1.Add (this.vbox4);
			global::Gtk.Notebook.NotebookChild w33 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox4]));
			w33.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Modificar Producto");
			this.notebook1.SetTabLabel (this.vbox4, this.label2);
			this.label2.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w34.Position = 0;
			// Internal child punto.gui.IngresarProductosDialog.ActionArea
			global::Gtk.HButtonBox w35 = this.ActionArea;
			w35.Name = "dialog1_ActionArea";
			w35.Spacing = 10;
			w35.BorderWidth = ((uint)(5));
			w35.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w36 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w35 [this.buttonCancel]));
			w36.Expand = false;
			w36.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w35 [this.buttonOk]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 437;
			this.Show ();
			this.checkbutton8.Toggled += new global::System.EventHandler (this.OnCheckbutton8Toggled);
			this.checkbutton7.Toggled += new global::System.EventHandler (this.OnCheckbutton7Toggled);
			this.BotonAgregarP.Clicked += new global::System.EventHandler (this.OnBotonAgregarPClicked);
		}
	}
}