//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ImageToAsciiConverter
//{
//    public class Terraformer
//    {
//        public string SourceLocation { get; set; }
//        public string TargetLocation { get; set; }

//        public Terraformer(string sourceLocation, string targetLocation)
//        {
//            this.SourceLocation = sourceLocation;
//            this.TargetLocation = targetLocation;
//        }

//        public void Go(int[,] selectedPoints, string terrainChoice)
//        {
//            string replaceChar = "^";

//            if (terrainChoice == "Ice")
//            {
//                replaceChar = "@";
//            }
//            else if(terrainChoice == "Sand")
//            {
//                replaceChar = ":";
//            }
//            else if (terrainChoice == "Grass")
//            {
//                replaceChar = "^";
//            }
//            else if (terrainChoice == "Trees")
//            {
//                replaceChar = "Y";
//            }
//            else if (terrainChoice == "Foothills")
//            {
//                replaceChar = "n";
//            }
//            else if (terrainChoice == "Mountains")
//            {
//                replaceChar = "m";
//            }
//            else if (terrainChoice == "Path")
//            {
//                replaceChar = "D";
//            }

//            if (terrainChoice == "Path")
//            {
//               // MakePath(selectedPoints, terrainChoice, replaceChar);
//            }
//            else
//            {
//                ChangeLandscape(selectedPoints, terrainChoice, replaceChar);
//            }

//        }
//        public void ChangeLandscape(int[,] selectedPoints, string terrainChoice, string replaceChar)
//        {
//            var fileWidth = 2000;
//            var fileHeight = 1558;
//            string[] map = new string[fileHeight];
//            string newRow;
//            string readRow;

//            using (var reader = new StreamReader(SourceLocation))
//            {
//                for (var y = 0; y < fileHeight; y++)
//                {
//                    map[y] = reader.ReadLine();
//                }
//            }

//            using (var writer = new StreamWriter(TargetLocation))
//            {
//                for (var y = 0; y < fileHeight; y++)
//                {
//                    newRow = "";
//                    readRow = "";
//                    readRow = map[y];
//                    for (var x = 0; x < fileWidth; x++)
//                    {
//                        if (y >= selectedPoints[0, 1] && y <= selectedPoints[1, 1])
//                        {
//                            if (x >= selectedPoints[0, 0] && x <= selectedPoints[1, 0])
//                            {
//                                if (readRow[x] != '.' & readRow[x] != ',')
//                                {
//                                    newRow += replaceChar;
//                                }
//                                else
//                                {
//                                    newRow += readRow[x];
//                                }
//                            }
//                            else
//                            {
//                                newRow += readRow[x];
//                            }
//                        }
//                        else
//                        {
//                            newRow += readRow[x];
//                        }
//                    }

//                    writer.WriteLine(newRow);
//                }
//            }

//        }
//        /*
//        public void MakePath(int[,] selectedPoints, string terrainChoice, string replaceChar)
//        {
//            var fileWidth = 2000;
//            var fileHeight = 1558;
//            string[] map = new string[fileHeight];
//            string newRow;
//            string readRow;


//            using (var reader = new StreamReader(SourceLocation))
//            {
//                for (var y = 0; y < fileHeight; y++)
//                {
//                    map[y] = reader.ReadLine();
//                }
//            }

//            if (terrainChoice == "Path")
//            {
//                newRow = "";
//                readRow = "";
//                readRow = map[y];
//                for (var x = 0; x < fileWidth; x++)
//                {
//                    if (y >= selectedPoints[0, 1] && y <= selectedPoints[1, 1])
//                    {
//                        if (x >= selectedPoints[0, 0] && x <= selectedPoints[1, 0])
//                        {
//                            if (readRow[x] != '.' & readRow[x] != ',')
//                            {
//                                newRow += replaceChar;
//                            }
//                            else
//                            {
//                                newRow += readRow[x];
//                            }
//                        }
//                        else
//                        {
//                            newRow += readRow[x];
//                        }
//                    }
//                    else
//                    {
//                        newRow += readRow[x];
//                    }
//                }

//            }
//        }
//    }*/
//    }
//}
