﻿using System;
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
using System.Reactive.Concurrency;


namespace RxNETSample_ReadWriteFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            attachUIEvents();
        }

        private void attachUIEvents()
        {
            var cancel = new CancellationDisposable();

            var scheduler = new NewThreadScheduler(t => new Thread(t) { Name = "Thread1" });
            var gridSch = new ControlScheduler(dataGridFile);
            
            var ob = Observer.Create<EventPattern<object>>(o => 
            {
                //wait a moment
                //non blocking
                Thread.Sleep(5000);

                string[] lines = getLinesFromFile();

                if(lines != null)
                {
                    lines.ToObservable().ObserveOn(gridSch)
                    .Subscribe(l =>
                    {
                        addLineToGrid(l);
                    });
                }                
            });

            Observable.FromEventPattern(
                h => this.btnReadFile.Click += h,
                h => this.btnReadFile.Click -= h)
                .ObserveOn(scheduler)
                .Subscribe(ob, cancel.Token);

            Observable.FromEventPattern(
                h => Application.ApplicationExit += h,
                h => Application.ApplicationExit -= h)
                .Subscribe( _ => {
                        cancel.Dispose();
                    });      
                       
        }

        private string[] getLinesFromFile()
        {
            if (File.Exists(txtFileToRead.Text))
            {
                string[] lines = File.ReadAllLines(txtFileToRead.Text);                
                return lines;
            }
            return null;
        }

        private void addLineToGrid(string line)
        {
            dataGridFile.Rows.Add(line);            
        }
    }
}
