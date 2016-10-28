using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive;
using System.Reactive.PlatformServices;
using System.Reactive.Concurrency;

namespace RxNETSample_ReadWriteFiles
{
    public partial class Form1 : Form
    {
        private IObservable<EventPattern<EventArgs>> read;
        private IObserver<EventPattern<EventArgs>> ob;

        public Form1()
        {
            InitializeComponent();
            createEventHandlerToBtnRead();
        }

        private void createEventHandlerToBtnRead()
        {
            ob = Observer.Create<EventPattern<EventArgs>>(o => 
            {
                if (File.Exists(txtFileToRead.Text))
                {
                    string[] lines = File.ReadAllLines(txtFileToRead.Text);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        dataGridFile.Rows.Add(lines[i]);
                        Thread.Sleep(1000);
                    }
                }
            });

            read = Observable.FromEventPattern<EventArgs>(btnReadFile, "Click");
            read.Subscribe(ob);
        }
    }
}
