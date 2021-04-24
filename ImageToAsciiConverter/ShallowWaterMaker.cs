using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAsciiConverter
{
    public class ShallowWaterMaker
    {
        public string SourceLocation { get; set; }
        public string TargetLocation { get; set; }

        public ShallowWaterMaker(string sourceLocation, string targetLocation)
        {
            this.SourceLocation = sourceLocation;
            this.TargetLocation = targetLocation;
        }

        public void Go()
        {
            var fileWidth = 2000;// 3066;
            var fileHeight = 1558;//2388;
            string[] map = new string[fileHeight];
            string newRow;
            var done = false;

            using (var reader = new StreamReader(SourceLocation))
            {
                for (var y = 0; y < fileHeight; y++)
                {
                    newRow = reader.ReadLine();
                    map[y] = newRow;
                }
            }
            string check;
            
            using (var writer = new StreamWriter(TargetLocation))
            {
                for (var y = 0; y < fileHeight; y++)
                {
                    newRow = map[y];
                    for (var x = 0; x < fileWidth; x++)
                    {
                        //if (y==1 & x==2)
                        //{
                        //    System.Diagnostics.Debugger.Break();
                        //}
                        //use reader to check char
                        if (newRow[x] == '.')
                        {
                            //for each each direction
                            //ADJACENT
                            // if west is land
                            if (((x - 1) >= 0) && (newRow[x - 1] == '#'))
                            {
                                writer.Write(',');
                                done = true;
                            }
                            // if east is land
                            else if (((x + 1) < fileWidth) && (newRow[x + 1] == '#') && !done)
                            {
                                writer.Write(',');
                                done = true;

                            }

                            // if north is land
                            if ((y - 1) >= 0 && !done)
                            {
                                check = map[y - 1];
                                if (check[x] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if east is land
                            if ((y + 1) < fileHeight && !done)
                            {
                                check = map[y + 1];
                                if (check[x] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            //DIAGONAL
                            // if northeast is land
                            if ((y - 1) >= 0 && (x + 1 < fileWidth) && !done)
                            {
                                check = map[y - 1];
                                if (check[x+1] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if northwest is land
                            if ((y - 1) >= 0 && (x - 1>= 0) && !done)
                            {
                                check = map[y - 1];
                                if (check[x - 1] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if southwest is land
                            if ((y + 1) < fileHeight && (x - 1 >= 0) && !done)
                            {
                                check = map[y + 1];
                                if (check[x - 1] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if southeast is land
                            if ((y + 1) < fileHeight && (x + 1 < fileWidth) && !done)
                            {
                                check = map[y + 1];
                                if (check[x + 1] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            //TWO AWAY ADJACENT
                            // if west is land
                            if (((x - 2) >= 0) && (newRow[x - 2] == '#') && !done)
                            {
                                writer.Write(',');
                                done = true;
                            }
                            // if east is land
                            if (((x + 2) < fileWidth) && (newRow[x + 2] == '#') && !done)
                            {
                                writer.Write(',');
                                done = true;

                            }

                            // if north is land
                            if ((y - 2) >= 0 && !done)
                            {
                                check = map[y - 2];
                                if (check[x] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if east is land
                            if ((y + 2) < fileHeight && !done)
                            {
                                check = map[y + 2];
                                if (check[x] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // 2 AWAY DIAGONAL
                            // if northeast is land
                            if ((y - 2) >= 0 && (x + 2 < fileWidth) && !done)
                            {
                                check = map[y - 2];
                                if (check[x + 2] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if northwest is land
                            if ((y - 2) >= 0 && (x - 2 >= 0) && !done)
                            {
                                check = map[y - 2];
                                if (check[x - 2] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if southwest is land
                            if ((y + 2) < fileHeight && (x - 2 >= 0) && !done)
                            {
                                check = map[y + 2];
                                if (check[x - 2] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }

                            // if southeast is land
                            if ((y + 2) < fileHeight && (x + 2 < fileWidth) && !done)
                            {
                                check = map[y + 2];
                                if (check[x + 2] == '#')
                                {
                                    writer.Write(',');
                                    done = true;
                                }
                            }


                            if (!done)
                            {
                                writer.Write(newRow[x]);
                            }
                            done = false;
                        }
                        else
                        {
                            writer.Write(newRow[x]);
                        }
                    }
                    writer.WriteLine();
                }
            }

            }

    }
}
