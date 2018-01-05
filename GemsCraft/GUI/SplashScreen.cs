using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using GemsCraft.AppSystem;
using GemsCraft.GUI;
using GemsCraft.Utils;
using MetroFramework.Forms;
using Timer = System.Windows.Forms.Timer;

namespace GemsCraftGUI
{
    public partial class SplashScreen : Form
    {
        private Timer timer = new Timer();
        private bool finalOperationFinished = false;
        private bool finalCountdownStarted = false;
        private int countdownStart;
        public SplashScreen()
        {
            InitializeComponent();
            timer.Tick += timerTick;
            timer.Interval = 1000;
            timer.Enabled = true;
            Start();
        }

        private void Start()
        {
            Log("=-=-=GEMSCRAFT IS STARTING=-=-=");
            Log("Library has loaded successfully");
            Log("Version: " + SoftwareVersion.LatestStable());

            Log("Loading the saved servers");
            if (!LocalServerList.Load())
            {
                LocalServerList.FirstStart();
            }
            finalOperationFinished = true;
        }
        private void Log(string text)
        {
            StartUp.Log.Add(text);
        }
        private List<string> checkedList = new List<string>();
        private int currentTick = 0;
        private void timerTick(object sender, EventArgs e)
        {
            currentTick++;
            if (finalOperationFinished)
            {
                if (!finalCountdownStarted)
                {
                    finalCountdownStarted = true;
                    countdownStart = currentTick;
                }

                if (currentTick - countdownStart != 10) return;
                new MainScreen().Show();
                Hide();
            }
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
        }
        
    }

}
