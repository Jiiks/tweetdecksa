using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Awesomium.Core;

namespace TweetDeckSA
{
    public partial class FormMain : Form
    {

        private const int PrefWidth = 1655;
        private const int PrefHeight = 800;
        private readonly String _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public FormMain()
        {
            InitializeComponent();

            string sessionFolder = Path.Combine(_appData, "TweetDeckSA");

            Width = PrefWidth;
            Height = PrefHeight;
            Debug.Print(sessionFolder);
            WebSession session = WebCore.CreateWebSession(@sessionFolder, WebPreferences.Default);

            webControl.ShowCreatedWebView += (sender, args) => Process.Start(args.TargetURL.ToString());

        }
    }
}
