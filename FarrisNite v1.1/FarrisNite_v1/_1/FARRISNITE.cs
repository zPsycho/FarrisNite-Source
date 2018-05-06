namespace FarrisNite_v1._1
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.IO.Ports;
    using System.Runtime.CompilerServices;
    using System.ServiceProcess;
    using System.Windows.Forms;
    using System.Windows.Forms.Integration;

    [DesignerGenerated]
    public class FARRISNITE : Form
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();
        private IContainer components;
        [AccessedThroughProperty("Avvia")]
        private CheckBox _Avvia;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Avvia2")]
        private CheckBox _Avvia2;
        [AccessedThroughProperty("Avvia3")]
        private CheckBox _Avvia3;
        [AccessedThroughProperty("Avvia4")]
        private CheckBox _Avvia4;
        [AccessedThroughProperty("Avvia5")]
        private CheckBox _Avvia5;
        [AccessedThroughProperty("Key")]
        private Label _Key;
        [AccessedThroughProperty("ProgressBar1")]
        private ProgressBar _ProgressBar1;
        [AccessedThroughProperty("Proxy")]
        private Button _Proxy;
        [AccessedThroughProperty("Avvia1")]
        private Button _Avvia1;
        [AccessedThroughProperty("Blocco1")]
        private Label _Blocco1;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Attivo1")]
        private Label _Attivo1;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;
        [AccessedThroughProperty("LinkLabel2")]
        private LinkLabel _LinkLabel2;
        [AccessedThroughProperty("LinkLabel3")]
        private LinkLabel _LinkLabel3;
        [AccessedThroughProperty("Process1")]
        private Process _Process1;
        [AccessedThroughProperty("ErrorProvider1")]
        private ErrorProvider _ErrorProvider1;
        [AccessedThroughProperty("SerialPort1")]
        private SerialPort _SerialPort1;
        [AccessedThroughProperty("ElementHost1")]
        private ElementHost _ElementHost1;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("ServiceController1")]
        private ServiceController _ServiceController1;
        [AccessedThroughProperty("FileSystemWatcher1")]
        private FileSystemWatcher _FileSystemWatcher1;
        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _ColorDialog1;

        [DebuggerNonUserCode]
        public FARRISNITE()
        {
            __ENCAddToList(this);
            this.InitializeComponent();
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    for (int i = 0; i <= num3; i++)
                    {
                        WeakReference reference = __ENCList[i];
                        if (reference.IsAlive)
                        {
                            if (i != index)
                            {
                                __ENCList[index] = __ENCList[i];
                            }
                            index++;
                        }
                    }
                    __ENCList.RemoveRange(index, __ENCList.Count - index);
                    __ENCList.Capacity = __ENCList.Count;
                }
                __ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Avvia = new CheckBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.Avvia2 = new CheckBox();
            this.Avvia3 = new CheckBox();
            this.Avvia4 = new CheckBox();
            this.Avvia5 = new CheckBox();
            this.Key = new Label();
            this.ProgressBar1 = new ProgressBar();
            this.Proxy = new Button();
            this.Avvia1 = new Button();
            this.Blocco1 = new Label();
            this.Label6 = new Label();
            this.Attivo1 = new Label();
            this.Label7 = new Label();
            this.LinkLabel1 = new LinkLabel();
            this.LinkLabel2 = new LinkLabel();
            this.LinkLabel3 = new LinkLabel();
            this.Process1 = new Process();
            this.ErrorProvider1 = new ErrorProvider(this.components);
            this.SerialPort1 = new SerialPort(this.components);
            this.Timer1 = new Timer(this.components);
            this.ElementHost1 = new ElementHost();
            this.ServiceController1 = new ServiceController();
            this.FileSystemWatcher1 = new FileSystemWatcher();
            this.ColorDialog1 = new ColorDialog();
            ((ISupportInitialize) this.ErrorProvider1).BeginInit();
            this.FileSystemWatcher1.BeginInit();
            this.SuspendLayout();
            this.Avvia.AutoSize = true;
            Point point2 = new Point(0x4f, 0x25);
            this.Avvia.Location = point2;
            this.Avvia.Name = "Avvia";
            Size size2 = new Size(0x34, 0x11);
            this.Avvia.Size = size2;
            this.Avvia.TabIndex = 0;
            this.Avvia.Text = "Avvia";
            this.Avvia.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            point2 = new Point(13, 0x25);
            this.Label1.Location = point2;
            this.Label1.Name = "Label1";
            size2 = new Size(0x3e, 13);
            this.Label1.Size = size2;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "PlayStation";
            this.Label2.AutoSize = true;
            point2 = new Point(13, 60);
            this.Label2.Location = point2;
            this.Label2.Name = "Label2";
            size2 = new Size(30, 13);
            this.Label2.Size = size2;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Xbox";
            this.Label3.AutoSize = true;
            point2 = new Point(12, 0x51);
            this.Label3.Location = point2;
            this.Label3.Name = "Label3";
            size2 = new Size(0x37, 13);
            this.Label3.Size = size2;
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Computer";
            this.Label4.AutoSize = true;
            point2 = new Point(12, 0x68);
            this.Label4.Location = point2;
            this.Label4.Name = "Label4";
            size2 = new Size(0x2e, 13);
            this.Label4.Size = size2;
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Android";
            this.Label5.AutoSize = true;
            point2 = new Point(13, 0x7e);
            this.Label5.Location = point2;
            this.Label5.Name = "Label5";
            size2 = new Size(0x29, 13);
            this.Label5.Size = size2;
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Iphone";
            this.Avvia2.AutoSize = true;
            point2 = new Point(0x40, 0x3b);
            this.Avvia2.Location = point2;
            this.Avvia2.Name = "Avvia2";
            size2 = new Size(0x34, 0x11);
            this.Avvia2.Size = size2;
            this.Avvia2.TabIndex = 6;
            this.Avvia2.Text = "Avvia";
            this.Avvia2.UseVisualStyleBackColor = true;
            this.Avvia3.AutoSize = true;
            point2 = new Point(70, 80);
            this.Avvia3.Location = point2;
            this.Avvia3.Name = "Avvia3";
            size2 = new Size(0x34, 0x11);
            this.Avvia3.Size = size2;
            this.Avvia3.TabIndex = 7;
            this.Avvia3.Text = "Avvia";
            this.Avvia3.UseVisualStyleBackColor = true;
            this.Avvia4.AutoSize = true;
            point2 = new Point(0x3d, 0x68);
            this.Avvia4.Location = point2;
            this.Avvia4.Name = "Avvia4";
            size2 = new Size(0x34, 0x11);
            this.Avvia4.Size = size2;
            this.Avvia4.TabIndex = 8;
            this.Avvia4.Text = "Avvia";
            this.Avvia4.UseVisualStyleBackColor = true;
            this.Avvia5.AutoSize = true;
            point2 = new Point(0x3b, 0x7f);
            this.Avvia5.Location = point2;
            this.Avvia5.Name = "Avvia5";
            size2 = new Size(0x34, 0x11);
            this.Avvia5.Size = size2;
            this.Avvia5.TabIndex = 9;
            this.Avvia5.Text = "Avvia";
            this.Avvia5.UseVisualStyleBackColor = true;
            this.Key.AutoSize = true;
            point2 = new Point(0x159, 0xdb);
            this.Key.Location = point2;
            this.Key.Name = "Key";
            size2 = new Size(0x18, 13);
            this.Key.Size = size2;
            this.Key.TabIndex = 10;
            this.Key.Text = "Key";
            point2 = new Point(0x4f, 0xeb);
            this.ProgressBar1.Location = point2;
            this.ProgressBar1.Name = "ProgressBar1";
            size2 = new Size(0x21e, 30);
            this.ProgressBar1.Size = size2;
            this.ProgressBar1.TabIndex = 11;
            point2 = new Point(0x6d, 0x10f);
            this.Proxy.Location = point2;
            this.Proxy.Name = "Proxy";
            size2 = new Size(0x7e, 0x2d);
            this.Proxy.Size = size2;
            this.Proxy.TabIndex = 12;
            this.Proxy.Text = "Attiva Proxy";
            this.Proxy.UseVisualStyleBackColor = true;
            point2 = new Point(0x1ce, 0x10f);
            this.Avvia1.Location = point2;
            this.Avvia1.Name = "Avvia1";
            size2 = new Size(0x7c, 0x2d);
            this.Avvia1.Size = size2;
            this.Avvia1.TabIndex = 13;
            this.Avvia1.Text = "Avvia";
            this.Avvia1.UseVisualStyleBackColor = true;
            this.Blocco1.AutoSize = true;
            point2 = new Point(0x20a, 0x24);
            this.Blocco1.Location = point2;
            this.Blocco1.Name = "Blocco1";
            size2 = new Size(0x51, 13);
            this.Blocco1.Size = size2;
            this.Blocco1.TabIndex = 14;
            this.Blocco1.Text = "Blocco Hater =";
            this.Label6.AutoSize = true;
            point2 = new Point(0x20a, 0x3b);
            this.Label6.Location = point2;
            this.Label6.Name = "Label6";
            size2 = new Size(0x65, 13);
            this.Label6.Size = size2;
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Blocco Modifiche =";
            this.Attivo1.AutoSize = true;
            this.Attivo1.ForeColor = Color.Lime;
            point2 = new Point(0x25f, 0x25);
            this.Attivo1.Location = point2;
            this.Attivo1.Name = "Attivo1";
            size2 = new Size(0x24, 13);
            this.Attivo1.Size = size2;
            this.Attivo1.TabIndex = 0x10;
            this.Attivo1.Text = "Attivo";
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = Color.Lime;
            point2 = new Point(0x272, 0x3b);
            this.Label7.Location = point2;
            this.Label7.Name = "Label7";
            size2 = new Size(0x24, 13);
            this.Label7.Size = size2;
            this.Label7.TabIndex = 0x11;
            this.Label7.Text = "Attivo";
            this.LinkLabel1.AutoSize = true;
            point2 = new Point(0x20d, 0x68);
            this.LinkLabel1.Location = point2;
            this.LinkLabel1.Name = "LinkLabel1";
            size2 = new Size(140, 13);
            this.LinkLabel1.Size = size2;
            this.LinkLabel1.TabIndex = 0x12;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "FarrisTv Channel YouTube ";
            this.LinkLabel2.AutoSize = true;
            point2 = new Point(0x20d, 0x7f);
            this.LinkLabel2.Location = point2;
            this.LinkLabel2.Name = "LinkLabel2";
            size2 = new Size(0x60, 13);
            this.LinkLabel2.Size = size2;
            this.LinkLabel2.TabIndex = 0x13;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "Sito Web Ufficiale";
            this.LinkLabel3.AutoSize = true;
            point2 = new Point(0x20d, 0x97);
            this.LinkLabel3.Location = point2;
            this.LinkLabel3.Name = "LinkLabel3";
            size2 = new Size(0x65, 13);
            this.LinkLabel3.Size = size2;
            this.LinkLabel3.TabIndex = 20;
            this.LinkLabel3.TabStop = true;
            this.LinkLabel3.Text = "Account Instagram";
            this.Process1.StartInfo.Domain = "";
            this.Process1.StartInfo.LoadUserProfile = false;
            this.Process1.StartInfo.Password = null;
            this.Process1.StartInfo.StandardErrorEncoding = null;
            this.Process1.StartInfo.StandardOutputEncoding = null;
            this.Process1.StartInfo.UserName = "";
            this.Process1.SynchronizingObject = this;
            this.ErrorProvider1.ContainerControl = this;
            point2 = new Point(0xda, 0x40);
            this.ElementHost1.Location = point2;
            this.ElementHost1.Name = "ElementHost1";
            size2 = new Size(200, 100);
            this.ElementHost1.Size = size2;
            this.ElementHost1.TabIndex = 0x15;
            this.ElementHost1.Text = "ElementHost1";
            this.ElementHost1.Child = null;
            this.FileSystemWatcher1.EnableRaisingEvents = true;
            this.FileSystemWatcher1.SynchronizingObject = this;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Red;
            size2 = new Size(0x2b6, 0x13d);
            this.ClientSize = size2;
            this.Controls.Add(this.ElementHost1);
            this.Controls.Add(this.LinkLabel3);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Attivo1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Blocco1);
            this.Controls.Add(this.Avvia1);
            this.Controls.Add(this.Proxy);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Avvia5);
            this.Controls.Add(this.Avvia4);
            this.Controls.Add(this.Avvia3);
            this.Controls.Add(this.Avvia2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Avvia);
            this.Font = new Font("Segoe Marker", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "FARRISNITE";
            this.Text = "FarrisNite v1.1 Beta";
            ((ISupportInitialize) this.ErrorProvider1).EndInit();
            this.FileSystemWatcher1.EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/user/FarrisTvOne");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://farrisnostrosignore.altervista.org/sito/index.html");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/farristv/");
        }

        private void Process1_Exited(object sender, EventArgs e)
        {
        }

        internal virtual CheckBox Avvia
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia = value);
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label1 = value);
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label2 = value);
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label3 = value);
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label4 = value);
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label5 = value);
        }

        internal virtual CheckBox Avvia2
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia2 = value);
        }

        internal virtual CheckBox Avvia3
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia3 = value);
        }

        internal virtual CheckBox Avvia4
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia4 = value);
        }

        internal virtual CheckBox Avvia5
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia5 = value);
        }

        internal virtual Label Key
        {
            [DebuggerNonUserCode]
            get => 
                this._Key;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Key = value);
        }

        internal virtual ProgressBar ProgressBar1
        {
            [DebuggerNonUserCode]
            get => 
                this._ProgressBar1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._ProgressBar1 = value);
        }

        internal virtual Button Proxy
        {
            [DebuggerNonUserCode]
            get => 
                this._Proxy;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Proxy = value);
        }

        internal virtual Button Avvia1
        {
            [DebuggerNonUserCode]
            get => 
                this._Avvia1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Avvia1 = value);
        }

        internal virtual Label Blocco1
        {
            [DebuggerNonUserCode]
            get => 
                this._Blocco1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Blocco1 = value);
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label6 = value);
        }

        internal virtual Label Attivo1
        {
            [DebuggerNonUserCode]
            get => 
                this._Attivo1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Attivo1 = value);
        }

        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Label7 = value);
        }

        internal virtual LinkLabel LinkLabel1
        {
            [DebuggerNonUserCode]
            get => 
                this._LinkLabel1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked -= handler;
                }
                this._LinkLabel1 = value;
                if (this._LinkLabel1 != null)
                {
                    this._LinkLabel1.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel2
        {
            [DebuggerNonUserCode]
            get => 
                this._LinkLabel2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
                if (this._LinkLabel2 != null)
                {
                    this._LinkLabel2.LinkClicked -= handler;
                }
                this._LinkLabel2 = value;
                if (this._LinkLabel2 != null)
                {
                    this._LinkLabel2.LinkClicked += handler;
                }
            }
        }

        internal virtual LinkLabel LinkLabel3
        {
            [DebuggerNonUserCode]
            get => 
                this._LinkLabel3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                LinkLabelLinkClickedEventHandler handler = new LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
                if (this._LinkLabel3 != null)
                {
                    this._LinkLabel3.LinkClicked -= handler;
                }
                this._LinkLabel3 = value;
                if (this._LinkLabel3 != null)
                {
                    this._LinkLabel3.LinkClicked += handler;
                }
            }
        }

        internal virtual Process Process1
        {
            [DebuggerNonUserCode]
            get => 
                this._Process1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Process1_Exited);
                if (this._Process1 != null)
                {
                    this._Process1.Exited -= handler;
                }
                this._Process1 = value;
                if (this._Process1 != null)
                {
                    this._Process1.Exited += handler;
                }
            }
        }

        internal virtual ErrorProvider ErrorProvider1
        {
            [DebuggerNonUserCode]
            get => 
                this._ErrorProvider1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._ErrorProvider1 = value);
        }

        internal virtual SerialPort SerialPort1
        {
            [DebuggerNonUserCode]
            get => 
                this._SerialPort1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._SerialPort1 = value);
        }

        internal virtual ElementHost ElementHost1
        {
            [DebuggerNonUserCode]
            get => 
                this._ElementHost1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._ElementHost1 = value);
        }

        internal virtual Timer Timer1
        {
            [DebuggerNonUserCode]
            get => 
                this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._Timer1 = value);
        }

        internal virtual ServiceController ServiceController1
        {
            [DebuggerNonUserCode]
            get => 
                this._ServiceController1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._ServiceController1 = value);
        }

        internal virtual FileSystemWatcher FileSystemWatcher1
        {
            [DebuggerNonUserCode]
            get => 
                this._FileSystemWatcher1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._FileSystemWatcher1 = value);
        }

        internal virtual ColorDialog ColorDialog1
        {
            [DebuggerNonUserCode]
            get => 
                this._ColorDialog1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                (this._ColorDialog1 = value);
        }
    }
}

