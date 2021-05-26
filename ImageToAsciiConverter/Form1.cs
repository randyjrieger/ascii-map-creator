using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToAsciiConverter
{
    public partial class Form1 : Form
    {
        private int fileWidth;
        private int fileHeight;
        private string myFilePath;
        private string mySavePath;
        private List<MapPoint> cloudPoints = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            AsciiArtCreator creator = new AsciiArtCreator(myFilePath);
            creator.Go(mySavePath);
        
        }

        private void ValidateControls()
        {

            if (lstTerrain.SelectedIndex < 0)
            {
                lblErrorMessage.Text = "Please choose a terrain style.";
                return;
            }

            if ((txtTL1.Text.Length == 0) || (txtTL2.Text.Length == 0) || (txtBR1.Text.Length == 0) || (txtBR2.Text.Length == 0))
            {
                lblErrorMessage.Text = "You are missing a coordinate.";
                return;
            }

            if (txtSource.Text.Length == 0)
            {
                lblErrorMessage.Text = "You are missing a source file.";
                return;
            }

            if (txtTargetPath.Text.Length == 0)
            {
                lblErrorMessage.Text = "You are missing a target file.";
                return;
            }
        }

        private void SetUp()
        {
            myFilePath = @txtSource.Text;
            mySavePath = @txtTargetPath.Text;
        }

        private void btnShallowWater_Click(object sender, EventArgs e)
        {
            SetUp();
            ShallowWaterMaker creator = new ShallowWaterMaker(myFilePath, mySavePath);
            creator.Go();
        }
                
        private void btnLorax_Click(object sender, EventArgs e)
        {
            var useCloudOption = optCloudShaped.Checked;            
            
            lblErrorMessage.Text = "";
            ValidateControls();

            SetUp();
            
            int[,] selectedPoints = new int[2, 2];

            var intensity = trackTreeSpray.Value;

            selectedPoints[0, 0] = int.Parse(txtTL1.Text);
            selectedPoints[0, 1] = int.Parse(txtTL2.Text);

            selectedPoints[1, 0] = int.Parse(txtBR1.Text);
            selectedPoints[1, 1] = int.Parse(txtBR2.Text);

            if (useCloudOption)
            {
                int xLine = selectedPoints[1, 0] - selectedPoints[0, 0];
                int xCloudPointCount = xLine / 30;

                cloudPoints = new List<MapPoint>();
                for (var c = 1; c <= xCloudPointCount; c++)
                {
                    cloudPoints.Add(new MapPoint(selectedPoints[0, 0] + 30 * c, selectedPoints[0, 1] ));
                }

                for (var c = 1; c <= xCloudPointCount; c++)
                {
                    cloudPoints.Add(new MapPoint(selectedPoints[0, 0] + 30 * c, selectedPoints[1, 1]));
                }
                
                int yLine = selectedPoints[1, 1] - selectedPoints[0, 1];
                int yCloudPointCount = yLine / 30;

                for (var c = 1; c <= yCloudPointCount; c++)
                {
                    cloudPoints.Add(new MapPoint(selectedPoints[0, 0], selectedPoints[0, 1] + 30 * c));
                }

                for (var c = 1; c <= yCloudPointCount; c++)
                {
                    cloudPoints.Add(new MapPoint(selectedPoints[1, 0], selectedPoints[0, 1] + 30 * c));
                }

            }

            string[] map = new string[fileHeight];
            string newRow;
            string readRow;

            string replaceCharLow = "";
            string replaceCharHigh = "";
            string replaceChar = "";

            int cloudIntensity = 3;
            if (useCloudOption)
            {
                var left = int.Parse(txtTL1.Text);
                var right = int.Parse(txtBR1.Text);

                int x1 = right + left / 2;
            }

            int trackValue = trackTreeSpray.Value;

            replaceChar = GetTerrainType();

            //backup source file
            File.Copy(myFilePath, @"c:\tmp\fileBackups\" + GetCopyFileName(myFilePath));

            if (lstTerrain.Text == "Trees")
            {
                 replaceCharLow = "Y";
                 replaceCharHigh = "F";

                if (trackValue > 5)
                    replaceChar = replaceCharLow;
            }

            using (var reader = new StreamReader(myFilePath))
            {
                for (var y = 0; y < fileHeight; y++)
                {
                    map[y] = reader.ReadLine();
                }
            }
            var i = 0;

            Random r = new Random();
            using (var writer = new StreamWriter(mySavePath))
            {
                for (var y = 0; y < fileHeight; y++)
                {
                    newRow = "";
                    readRow = "";
                    readRow = map[y];
                    for (var x = 0; x < fileWidth; x++)
                    {
                        if (y >= selectedPoints[0, 1] && y <= selectedPoints[1, 1])
                        {
                            if (x >= selectedPoints[0, 0] && x <= selectedPoints[1, 0])
                            {
                                i = r.Next(1, trackValue + 1);
                                if (i == 1)
                                {
                                    //change to allowed tile list, not just ^
                                    if (readRow[x] == '^')
                                    {
                                        if (LeaveASpace(map, ref readRow, x, y))
                                        {
                                            if (!useCloudOption)
                                            {
                                                newRow += replaceChar;
                                            }
                                            else if (!InTheCloudZone(map, ref readRow, x, y))
                                            {
                                                newRow += replaceChar;
                                            }
                                            else
                                            {
                                                newRow += readRow[x];
                                            }
                                            // else// if(useCloudOption && CloudSafe(map, ref readRow, x, y))
                                            //else if ((useCloudOption && CloudSafe(map, ref readRow, x, y)) || !useCloudOption)
                                            //{
                                            //    newRow += replaceChar;
                                            //}
                                        }
                                        else
                                        {
                                            newRow += readRow[x];
                                        }
                                    }
                                    else
                                    {
                                        newRow += readRow[x];
                                    }
                                }
                                else
                                {
                                    newRow += readRow[x];
                                }
                            }
                            else
                            {
                                newRow += readRow[x];
                            }
                        }
                        else
                        {
                            newRow += readRow[x];
                        }

                        if (i == 10)
                            i = 0;
                    }

                    writer.WriteLine(newRow);
                }
            }
        }
        
        private bool InTheCloudZone(string[] map, ref string newRow, int x, int y)
        {
            bool inTheZone = false;
            int cloudSize = trackCloudSize.Value;

            if ((Math.Abs(y - int.Parse(txtTL2.Text)) < cloudSize) || (Math.Abs(y - int.Parse(txtBR2.Text)) < cloudSize))
            {
                foreach (var cloudPoint in cloudPoints)
                {
                    if (Math.Abs(x - cloudPoint.X) < cloudSize)
                    {
                        inTheZone = true;
                    }
                }
            }

            if ((Math.Abs(x - int.Parse(txtTL1.Text)) < cloudSize) || (Math.Abs(x - int.Parse(txtBR1.Text)) < cloudSize))
            {
                foreach (var cloudPoint in cloudPoints)
                {
                    if (Math.Abs(y - cloudPoint.Y) < cloudSize)
                    {
                        inTheZone = true;
                    }
                }
            }

            return inTheZone;
        }

        private void btnSourceFile_Click(object sender, EventArgs e)
        {
            fileDialog.InitialDirectory = @"C:\tmp\";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Select Source File";
            fileDialog.Filter = "txt files (*.txt)|*.txt|jpg files(*.jpg)| *.jpg | All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = fileDialog.FileName;
            }

            fileHeight = 0;
            string newLine;
            using (var reader = new StreamReader(fileDialog.FileName))
            {
                do
                {
                    newLine = reader.ReadLine();
                    fileWidth = newLine.Length;
                    if (fileWidth > 0)
                    {
                        fileHeight++;
                    }
                } while (!reader.EndOfStream);
            }

            txtImgWidth.Text = fileWidth.ToString();
            txtImgHeight.Text = fileHeight.ToString();
        }

        private void btnTargetFile_Click(object sender, EventArgs e)
        {
            fileDialog.InitialDirectory = @"C:\tmp\";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title = "Select Target File";
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtTargetPath.Text = fileDialog.FileName;
            }
        }

        private string GetTerrainType()
        {
            var terrainChoice = lstTerrain.Text;
            var replaceChar = "";

            if (terrainChoice == "Ice")
            {
                replaceChar = "@";
            }
            else if (terrainChoice == "Sand")
            {
                replaceChar = ":";
            }
            else if (terrainChoice == "Grass")
            {
                replaceChar = "^";
            }
            else if (terrainChoice == "Trees")
            {
                replaceChar = "Y";
            }
            else if (terrainChoice == "Foothills")
            {
                replaceChar = "n";
            }
            else if (terrainChoice == "Mountains")
            {
                replaceChar = "m";
            }
            else if (terrainChoice == "Path")
            {
                replaceChar = "D";
            }

            return replaceChar;
        }

        private bool LeaveASpace(string[] map, ref string newRow, int x, int y)
        {
            string check;
            var done = false;
            // var fileWidth = 2000;
            // var fileHeight = 1558;
            List<char> barrierTiles = new List<char>();

            barrierTiles.Add('D'); //path
            barrierTiles.Add(','); //swallow water
            barrierTiles.Add('.'); //forest

            if (trackSpaceFromCoast.Value > 0)
            {
                //for each each direction
                //ADJACENT
                // if west is water
                if (((x - 1) >= 0) && (barrierTiles.Contains(newRow[x - 1])))
                {
                    done = true;
                }
                // if east is water
                if (((x + 1) < fileWidth) && (barrierTiles.Contains(newRow[x + 1])) && !done)
                {
                    done = true;

                }

                // if north is water
                if ((y - 1) >= 0 && !done)
                {
                    check = map[y - 1];
                    if (barrierTiles.Contains(check[x]))
                    {
                        done = true;
                    }
                }

                // if east is water
                if ((y + 1) < fileHeight && !done)
                {
                    check = map[y + 1];
                    if (barrierTiles.Contains(check[x]))
                    {
                        done = true;
                    }
                }

                //DIAGONAL
                // if northeast is land
                if ((y - 1) >= 0 && (x + 1 < fileWidth) && !done)
                {
                    check = map[y - 1];
                    if (barrierTiles.Contains(check[x]))
                    {
                        done = true;
                    }
                }

                // if northwest is land
                if ((y - 1) >= 0 && (x - 1 >= 0) && !done)
                {
                    check = map[y - 1];
                    if (barrierTiles.Contains(check[x]))
                    {
                        done = true;
                    }
                }

                // if southwest is land
                if ((y + 1) < fileHeight && (x - 1 >= 0) && !done)
                {
                    check = map[y + 1];
                    if (barrierTiles.Contains(check[x - 1]))
                    {
                        done = true;
                    }
                }

                // if southeast is land
                if ((y + 1) < fileHeight && (x + 1 < fileWidth) && !done)
                {
                    check = map[y + 1];
                    if (barrierTiles.Contains(check[x + 1]))
                    {
                        done = true;
                    }
                }

                if (trackSpaceFromCoast.Value > 1)
                {
                    //TWO AWAY ADJACENT
                    // if west is land
                    if (((x - 2) >= 0) && (barrierTiles.Contains(newRow[x - 2])) && !done)
                    {
                        done = true;
                    }
                    // if east is land
                    if (((x + 2) < fileWidth) && (barrierTiles.Contains(newRow[x + 2])) && !done)
                    {
                        done = true;

                    }

                    // if north is land
                    if ((y - 2) >= 0 && !done)
                    {
                        check = map[y - 2];
                        if (barrierTiles.Contains(check[x]))
                        {
                            done = true;
                        }
                    }

                    // if east is land
                    if ((y + 2) < fileHeight && !done)
                    {
                        check = map[y + 2];
                        if (barrierTiles.Contains(check[x]))
                        {
                            done = true;
                        }
                    }

                    // 2 AWAY DIAGONAL
                    // if northeast is land
                    if ((y - 2) >= 0 && (x + 2 < fileWidth) && !done)
                    {
                        check = map[y - 2];
                        if (barrierTiles.Contains(check[x + 2]))
                        {
                            done = true;
                        }
                    }

                    // if northwest is land
                    if ((y - 2) >= 0 && (x - 2 >= 0) && !done)
                    {
                        check = map[y - 2];
                        if (barrierTiles.Contains(check[x - 2]))
                        {
                            done = true;
                        }
                    }

                    // if southwest is land
                    if ((y + 2) < fileHeight && (x - 2 >= 0) && !done)
                    {
                        check = map[y + 2];
                        if (barrierTiles.Contains(check[x - 2]))
                        {
                            done = true;
                        }
                    }

                    // if southeast is land
                    if ((y + 2) < fileHeight && (x + 2 < fileWidth) && !done)
                    {
                        check = map[y + 2];
                        if (barrierTiles.Contains(check[x + 2]))
                        {
                            done = true;
                        }
                    }
                }

            }
            return !done;
        }

        private string GetCopyFileName(string sourceFileName)
        {
            return Path.GetFileNameWithoutExtension(sourceFileName) + DateTime.Now.ToShortDateString() + "_" + DateTime.Now.Hour + DateTime.Now.Minute + +DateTime.Now.Second + DateTime.Now.Millisecond + ".txt";
        }

    }
}
