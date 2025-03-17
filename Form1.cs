using System;
using System.Diagnostics;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Schema;
using System.IO;


namespace DSplit
{
    public partial class Form1 : Form
    {
        RunData currentRun = new RunData { Game = "DefaultGame", RunCount = 0, Segment = new List<SegmentData>() };
        Stopwatch stopWatch = new Stopwatch();
        Timer updateTimer = new Timer();
        List<long> splits = new List<long>();
        public Form1()
        {
            InitializeComponent();
            lblTimer.Text = "00:00:00.00";

            updateTimer.Interval = 50;
            updateTimer.Tick += UpdateTimer_Tick;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = stopWatch.Elapsed.ToString("hh\\:mm\\:ss\\.ff");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                stopWatch.Start();
                updateTimer.Start();
                btnStartStop.Text = "Stop";
            }
            else
            {
                stopWatch.Stop();
                updateTimer.Stop();
                btnStartStop.Text = "Start";
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            splitTable();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            updateTimer.Stop();  // Stop the timer without disposing it.
            lblTimer.Text = "00:00:00.00";  // Immediately update the label to display 0:00:00.
            btnStartStop.Text = "Start";

            // Clear splits in the UI
            txtSplits.Clear();
            splits.Clear();

            currentRun.RunCount++;
        }



        private void btnClearSplits_Click(object sender, EventArgs e)
        {
            lstSplits.Items.Clear();
        }

        private void splitTable()
        {
            long currentTicks = stopWatch.Elapsed.Ticks;
            // Only add the split if it's unique
            if (!splits.Contains(currentTicks))
            {
                splits.Add(currentTicks);
                txtSplits.Clear();
                int splitIndex = 1;
                foreach (var tickValue in splits)
                {
                    TimeSpan splitTime = new TimeSpan(tickValue);
                    // Format each split line. This example shows the split number and time.
                    txtSplits.AppendText($"Split {splitIndex}: {splitTime.ToString(@"hh\:mm\:ss\.ff")}\r\n");
                    splitIndex++;
                }
            }
        }

        //TODO: Write the save to xml function after adding File/Settings to the form
        private void SaveToXML()
        {
            XDocument xml = new XDocument(
                new XElement("Game",
                    new XElement("RunCount",
                        new XElement("Segments",
                            new XElement("SegmentName",
                                new XElement("SplitTime")
                            )
                        )
                    )
                )
            );
        }

        private void XMLTest()
        {
            XmlDocument oConfigDoc = new XmlDocument();

            XmlElement gameElement = oConfigDoc.CreateElement("Game");
            gameElement.SetAttribute("Name", currentRun.Game);
            gameElement.SetAttribute("RunCount", currentRun.RunCount.ToString());

            XmlElement segmentsElement = oConfigDoc.CreateElement("Segments");

            if (currentRun.Segment != null)
            {
                foreach (SegmentData seg in currentRun.Segment)
                {
                    XmlElement segmentElement = oConfigDoc.CreateElement("Segment");

                    segmentElement.SetAttribute("SegmentName", seg.SegmentName);

                    segmentElement.SetAttribute("SplitTime", seg.SplitTime.ToString("hh\\:mm\\:ss\\.ff"));

                    segmentElement.AppendChild(segmentElement);
                }
            }

            gameElement.AppendChild(segmentsElement);

            oConfigDoc.AppendChild(gameElement);

            oConfigDoc.Save($"{currentRun.Game}.xml");

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                }
            }
            XMLTest();
        }

        string gameName;
        private void GameNameTxt_TextChanged(object sender, EventArgs e)
        {
            currentRun.Game = GameNameTxt.Text;
        }

        private void GameNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                currentRun.Game = GameNameTxt.Text;            
            }
        }
    }
}
