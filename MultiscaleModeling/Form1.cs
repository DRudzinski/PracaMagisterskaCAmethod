using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiscaleModeling
{
    public partial class mainForm : Form
    {
        public class Matrix
        {

            public int width; //width of CA space
            public int height; // height of CA space
            public int seeds; // number of seeds
            public int ntype; //neighbourhood type if true then Mora else Von Neuman
            public bool btype; // boundary type if true then Periodic else non periodic
            public int[,] matTable; //Array to store state of cells
            public int[,] matTableTemp; //Array to store state of cell till the end of step
            public Color[] seedsCol; // Array to store seeds colors
            public int[] seedsID; //Array to store ID of seeds
            public Bitmap bmp; //bitmap to display results in pictue box 
            public bool end_flag;//flag to inform if all loops has been made

            public bool tpl;
            public Task taskStep;
            //Exercises 2 
            public int intrusions; //number of inclusions
            public int intr_radius_min; //radius of inclusions
            public int intr_radius_max; //radius of inclusions
            public int[,] intrusionsPos; //store position of inclusions

            //Exercises 3
            public bool GBC;
            public int prc_chance;

            //Exercises 4
            public int[,] PhaseTab; //table of grains to be deleted
            public Color[] PhaseprevColor; //Previous grain colors
            public Color initColor; //init color to be set after delete grain
            public int phase;

            public void Matrix_args(int w, int h, int seed, int n, bool b, int intrus, int radius_min, int radius_max,bool t)
            {
                width = w; //width of matrix
                height = h; // height of matrix
                seeds = seed; // number of seeds
                ntype = n; // neighbourhood type if true then Moora else Von Neuman
                btype = b; // Boundary type if true ten Periodic else Non Periodic
                end_flag = false; //Flag if all data has been processed
                intrusions = intrus;//number of intrusions
                intr_radius_min = radius_min;//min radius size
                intr_radius_max = radius_max;//max radius size
                tpl = t;
            }

            public void matTablegen()
            {
                //Method to generate CA space tables
                matTable = new int[height, width];
                matTableTemp = new int[height, width];
                bmp = new Bitmap(width, height);

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        matTable[i, j] = 0;
                        matTableTemp[i, j] = 0;
                    }
                }
            }

            public void genSeedsColor()
            {
                //Method to generate color table
                seedsCol = new Color[seeds + 1];
                seedsID = new int[seeds + 1];
            }

            //----------------------------------------------
            //-------Method to make one full step-----------
            public void step(PictureBox pic1)
            {
                SolidBrush myBrush = new SolidBrush(Color.Black);
                Graphics g = Graphics.FromImage(pic1.Image);
                int finish_flag = 0;//number of non empty cells
                int finish_target = width * height; //number of all cells

                //Moore neighbourhoods
                if (ntype == 1)
                {
                    //Periodic boundary
                    if (btype == true)
                    {
                        if (tpl == true)
                        {
                            Parallel.For(0, height, i =>
                            {
                                /*for (int j = 0; j < width; j++)
                                {
                                        StepProcess(i, j);

                                }*/
                                Parallel.For(0, width, j =>
                                {
                                    StepProcess(i, j);
                                });
                            });
            
                        }
                        else
                        {
                            for (int i = 0; i < height; i++)
                            {

                                for (int j = 0; j < width; j++)
                                {
                                        StepProcess(i, j);

                                }
                            }//loops ends here

                        }
                        //loops stars here

                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (matTable[i, j] > 0 || matTable[i, j] == -1)
                                {
                                    //chceck cell is active and if all data has been processed
                                    finish_flag += 1;
                                    if (finish_flag == finish_target) { end_flag = true; break; }
                                    else { continue; }

                                }
                                bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, matTableTemp[i, j])]);
                                matTable[i, j] = matTableTemp[i, j];
                            }
                        }


                    }// periodic boundary ends here
                    //Non Periodic Boundary starts here
                }//Moore neighbourhoods ends here
            }


            public void StepProcess(int i, int j)
            {
                int ul = 0; // Upper left Cell
                int um = 0; // Uper middle Cell
                int ur = 0; // Upper right Cell

                int ml = 0; // Middle left Cell
                int mr = 0; // Middle right Cell

                int dl = 0; // Down left Cell
                int dm = 0; // Down middle Cell
                int dr = 0; // Down right Cell


                //Middle of space
                if ((i > 0 && i < (height - 1)) && (j > 0 && j < (width - 1)))
                    {
                        ul = matTable[i - 1, j - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, j + 1];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[i + 1, j - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, j + 1];
                    }
                 //Left upper corner
                 else if (i == 0 && j == 0)
                    {
                        ul = matTable[height - 1, width - 1];
                        um = matTable[height - 1, j];
                        ur = matTable[height - 1, j + 1];

                        ml = matTable[i, width - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[i + 1, width - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, j + 1];
                    }
                 //left down corner
                 else if ((i == (height - 1)) && j == 0)
                    {
                        ul = matTable[i - 1, width - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, j + 1];

                        ml = matTable[i, width - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[0, width - 1];
                        dm = matTable[0, j];
                        dr = matTable[0, j + 1];
                    }
                  //right upper corner
                 else if (i == 0 && (j == (width - 1)))
                    {
                        ul = matTable[height - 1, 0];
                        um = matTable[height - 1, j];
                        ur = matTable[height - 1, j - 1];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, 0];

                        dl = matTable[i + 1, j - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, 0];
                    }
                 //right down corner
                 else if ((i == (height - 1)) && (j == (width - 1)))
                    {
                        ul = matTable[i - 1, j - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, 0];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, 0];

                        dl = matTable[0, j - 1];
                        dm = matTable[0, j];
                        dr = matTable[0, 0];
                    }
                  //first column
                 else if (i > 0 && j == 0)
                    {
                        ul = matTable[i - 1, width - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, j + 1];

                        ml = matTable[i, width - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[i + 1, width - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, j + 1];
                    }
                  //last column
                  else if (i > 0 && j == (width - 1))
                    {
                        ul = matTable[i - 1, j - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, 0];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, 0];

                        dl = matTable[i + 1, j - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, 0];
                    }
                  //first row
                  else if (i == 0 && j > 0)
                    {
                        ul = matTable[height - 1, j - 1];
                        um = matTable[height - 1, j];
                        ur = matTable[height - 1, j + 1];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[i + 1, j - 1];
                        dm = matTable[i + 1, j];
                        dr = matTable[i + 1, j + 1];
                    }
                  //last row
                  else if ((i == height - 1) && j > 0)
                    {
                        ul = matTable[i - 1, j - 1];
                        um = matTable[i - 1, j];
                        ur = matTable[i - 1, j + 1];

                        ml = matTable[i, j - 1];
                        mr = matTable[i, j + 1];

                        dl = matTable[0, j - 1];
                        dm = matTable[0, j];
                        dr = matTable[0, j + 1];
                    }

                if (phase == 0)
                  {
                      if (ul > 0) { matTableTemp[i, j] = ul; }
                      else if (um > 0) { matTableTemp[i, j] = um; }
                      else if (ur > 0) { matTableTemp[i, j] = ur; }
                      else if (ml > 0) { matTableTemp[i, j] = ml;}
                      else if (mr > 0) { matTableTemp[i, j] = mr;}
                      else if (dl > 0) { matTableTemp[i, j] = dl;}
                      else if (dm > 0) { matTableTemp[i, j] = dm;}
                      else if (dr > 0) { matTableTemp[i, j] = dr;}
                  }
                else
                  {
                    if (CheckPhase(ul) > 0) { matTableTemp[i, j] = ul; }
                    else if (CheckPhase(um) > 0) { matTableTemp[i, j] = um; }
                    else if (CheckPhase(ur) > 0) { matTableTemp[i, j] = ur; }
                    else if (CheckPhase(ml) > 0) { matTableTemp[i, j] = ml; }
                    else if (CheckPhase(mr) > 0) { matTableTemp[i, j] = mr; }
                    else if (CheckPhase(dl) > 0) { matTableTemp[i, j] = dl; }
                    else if (CheckPhase(dm) > 0) { matTableTemp[i, j] = dm; }
                    else if (CheckPhase(dr) > 0) { matTableTemp[i, j] = dr; }
                  }
                /*if (phase == 0)
                  {
                      if (ul > 0) { matTableTemp[i, j] = ul; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ul)]); }
                      else if (um > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                      else if (ur > 0) { matTableTemp[i, j] = ur; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ur)]); }
                      else if (ml > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                      else if (mr > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                      else if (dl > 0) { matTableTemp[i, j] = dl; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dl)]); }
                      else if (dm > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }
                      else if (dr > 0) { matTableTemp[i, j] = dr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dr)]); }
                  }
                else
                  {
                      if (CheckPhase(ul) > 0) { matTableTemp[i, j] = ul; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ul)]); }
                      else if (CheckPhase(um) > 0) { matTableTemp[i, j] = um; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, um)]); }
                      else if (CheckPhase(ur) > 0) { matTableTemp[i, j] = ur; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ur)]); }
                      else if (CheckPhase(ml) > 0) { matTableTemp[i, j] = ml; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, ml)]); }
                      else if (CheckPhase(mr) > 0) { matTableTemp[i, j] = mr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, mr)]); }
                      else if (CheckPhase(dl) > 0) { matTableTemp[i, j] = dl; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dl)]); }
                      else if (CheckPhase(dm) > 0) { matTableTemp[i, j] = dm; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dm)]); }
                      else if (CheckPhase(dr) > 0) { matTableTemp[i, j] = dr; bmp.SetPixel(j, i, seedsCol[Array.IndexOf(seedsID, dr)]); }
                  }*/

            }

            public int CheckPhase(int id)
            {
                int exist = 0;
                for (int i = 0; i < PhaseTab.GetLength(0); i++)
                {
                    if (id == PhaseTab[0, i])
                    {
                        exist = 1;
                        break;
                    }
                    else
                    {
                        exist = 0;
                    }
                }
                if (exist == 1)
                {
                    return 0;
                }
                else
                {
                    return id;
                }
            }

            public Color FindColor(int id)
            {
                int ok = 0;
                Color ret = initColor;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (matTable[i, j] == id)
                        {
                            ret = bmp.GetPixel(j, i);
                            ok = 1;
                            break;
                        }
                    }
                    if (ok == 1) { break; }

                }
                return ret;
            }
        }




        // testing class to generate seed object, not necessery
        public class Seed
        {
            public int X;
            public int Y;
            public int ID;

            public Seed(int x, int y, int id)
            {
                X = x;
                Y = y;
                ID = id;
            }
        }

        //testing varaibles to store values from text boxes, not neccesery if Matrix attributes are public
        int width;
        int height;
        int seeds;
        int ntype;
        int intrusions;
        int radius_min;
        int radius_max;
        bool btype;

        bool tpl;

        //timer to display animation
        Timer t = new Timer();
        Matrix m1 = new Matrix();
        Matrix m2 = new Matrix();
        Matrix m3 = new Matrix();

        Stopwatch sw = new Stopwatch();
        public mainForm()
        {
            InitializeComponent();
            //Initialize begining view
            seed_num.Enabled = false;
            seed_button.Enabled = false;
            more_check.Enabled = false;
            p_check.Enabled = false;
            start_button.Enabled = false;
            Animation_button.Enabled = false;
            pause_button.Enabled = false;
            nexts_button.Enabled = false;
            import_cond_button.Enabled = false;
            import_cond_button.Visible = false;

            m1.phase = 0;
            m2.phase = 0;
            m3.phase = 0;

            t.Interval = 200; // speed of animation
            t.Tick += new EventHandler(this.Animation_button_Click);

        }

        private void size_button_Click(object sender, EventArgs e)
        {
            //chceck if all values are int only and width and height >0
            int parse;
            if (!int.TryParse(width_txt.Text, out parse) || !int.TryParse(heigh_txt.Text, out parse))
            {
                MessageBox.Show("Please insert numbers only");
            }
            else
            {
                if (Int32.Parse(width_txt.Text) > 0 && Int32.Parse(heigh_txt.Text) > 0)
                {
                    width = Int32.Parse(width_txt.Text);
                    height = Int32.Parse(heigh_txt.Text);
                    seed_num.Enabled = true;
                    seed_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("width and height must be > 0");
                }
            }


        }

        private void seed_button_Click(object sender, EventArgs e)
        {
            //chceck if values are numbers only and >0
            int parse;
            if (!int.TryParse(seed_num.Value.ToString(), out parse))
            {
                MessageBox.Show("Please insert int number only");
            }
            else
            {

                if (Int32.Parse(seed_num.Value.ToString()) > 0)
                {
                    seeds = Int32.Parse(seed_num.Value.ToString());
                    if (m1.phase == 0)
                    {
                        more_check.Enabled = true;
                        p_check.Enabled = true;
                        start_button.Enabled = true;
                        
                    }

                }
                else
                {
                    MessageBox.Show("Number of seeds must be > 0");
                }

            }

        }

        private void start_button_Click(object sender, EventArgs e)
        {

            if (m1.phase == 0)
            {
                //Generate CA space, seeds, colors targets...
                if (width > 0 && height > 0 && seeds > 0)
                {
                    if (more_check.Checked) { ntype = 1; }
                    if (p_check.Checked == true) { btype = true; }
                    else { btype = false; }

                    if (tpl_checkbox.Checked == true) { tpl = true; }
                    else { tpl = false; }

                    width_txt.Enabled = false;
                    heigh_txt.Enabled = false;
                    size_button.Enabled = false;
                    seed_num.Enabled = false;
                    seed_button.Enabled = false;
                    more_check.Enabled = false;
                    p_check.Enabled = false;


                    m1.Matrix_args(width, height, seeds, ntype, btype, intrusions, radius_min, radius_max,tpl);

                    m2.Matrix_args(width, height, seeds, ntype, btype, intrusions, radius_min, radius_max, tpl);

                    m3.Matrix_args(width, height, seeds, ntype, btype, intrusions, radius_min, radius_max, tpl);

                    pic_box.Width = m1.width;
                    pic_box.Height = m1.height;

                    pic_box2.Width = m1.width;
                    pic_box2.Height = m1.height;

                    pic_box3.Width = m1.width;
                    pic_box3.Height = m1.height;

                    m1.matTablegen();
                    m1.genSeedsColor();

                    m2.matTablegen();
                    m2.genSeedsColor();

                    m3.matTablegen();
                    m3.genSeedsColor();
                    Random rnd = new Random();
                    //Pen blackPen = new Pen(Color.Black, 1);
                    SolidBrush myBrush = new SolidBrush(Color.Black);
                    pic_box.Image = m1.bmp;
                    pic_box.Image = m2.bmp;
                    pic_box.Image = m3.bmp;

                    m1.initColor = m1.bmp.GetPixel(0, 0);
                    m2.initColor = m2.bmp.GetPixel(0, 0);
                    m3.initColor = m3.bmp.GetPixel(0, 0);
                    Graphics g = Graphics.FromImage(pic_box.Image);
                    //set intrusions into bitmap
                    /*for (int i = 0; i < m1.intrusions; i++)
                    {
                        int ok = 0;

                        do
                        {
                            int X = rnd.Next(0, width);
                            int Y = rnd.Next(0, height);
                            int radius = rnd.Next(m1.intr_radius_min, m1.intr_radius_max);
                            if (m1.matTable[Y, X] == 0)
                            {
                                ok = 1;
                                m1.matTable[Y, X] = -1;
                                m1.matTableTemp[Y, X] = -1;
                                m1.bmp.SetPixel(X, Y, Color.Black);
                                g.FillEllipse(myBrush, X, Y, radius, radius);
                                m1.intrusionsPos[0, i] = Y;
                                m1.intrusionsPos[1, i] = X;
                                m1.intrusionsPos[2, i] = radius;
                                //g.DrawEllipse(blackPen, X, Y, radius, radius);
                            }
                        } while (ok == 0);

                        pic_box.Image = m1.bmp;
                    }*/

                    //set seeds into bitmap
                    for (int i = 1; i < m1.seeds + 1; i++)
                    {
                        int ok = 0;

                        do
                        {
                            int X = rnd.Next(0, width);
                            int Y = rnd.Next(0, height);
                            if (m1.matTable[Y, X] == 0)
                            {
                                Seed s1 = new Seed(Y, X, i);
                                ok = 1;
                                m1.matTable[Y, X] = i;
                                m1.matTableTemp[Y, X] = i;

                                m2.matTable[Y, X] = i;
                                m2.matTableTemp[Y, X] = i;

                                m3.matTable[Y, X] = i;
                                m3.matTableTemp[Y, X] = i;

                                Color randCol = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                                m1.bmp.SetPixel(X, Y, randCol);
                                m1.seedsID[i] = i;
                                m1.seedsCol[i] = randCol;

                                m2.bmp.SetPixel(X, Y, randCol);
                                m2.seedsID[i] = i;
                                m2.seedsCol[i] = randCol;

                                m3.bmp.SetPixel(X, Y, randCol);
                                m3.seedsID[i] = i;
                                m3.seedsCol[i] = randCol;
                            }
                        } while (ok == 0);

                        pic_box.Image = m1.bmp;
                        pic_box2.Image = m2.bmp;
                        pic_box3.Image = m3.bmp;
                    }

                    Animation_button.Enabled = true;
                    pause_button.Enabled = true;
                    nexts_button.Enabled = true;
                }
                else
                {
                    MessageBox.Show("insert values first");
                }

                m1.taskStep = new Task(() => { m1.step(pic_box); });
                m2.taskStep = new Task(() => { m2.step(pic_box2); });
                m3.taskStep = new Task(() => { m3.step(pic_box3); });

                //var task2 = new Task(doSomework());
                //var task3 = new Task(doSomework());
            }
           /* else
            {

                if (more_check.Checked) { ntype = 1; }

                if (p_check.Checked == true) { btype = true; }
                else { btype = false; }

                if (tpl_checkbox.Checked == true) { tpl = true; }
                else { tpl = false; }

                m1.seeds = seeds;
                m1.genSeedsColor();
                m1.end_flag = false;
                int id = 1;
                Random rnd = new Random();

                for (int i = 1; i < seeds + 1; i++)
                {
                    int ok = 0;
                    while (m1.CheckPhase(id) == 0)
                    {
                        id = id + 1;
                    }
                    do
                    {
                        int X = rnd.Next(0, m1.width);
                        int Y = rnd.Next(0, m1.height);
                        if (m1.matTable[Y, X] == 0)
                        {
                            Seed s1 = new Seed(Y, X, id);
                            ok = 1;
                            m1.matTable[Y, X] = id;
                            m1.matTableTemp[Y, X] = id;
                            Color randCol = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                            m1.bmp.SetPixel(X, Y, randCol);
                            m1.seedsID[i] = id;
                            m1.seedsCol[i] = randCol;
                        }
                    } while (ok == 0);
                    id += 1;
                    pic_box.Image = m1.bmp;
                }

                Animation_button.Enabled = true;
                pause_button.Enabled = true;
                nexts_button.Enabled = true;

            }*/


        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //reset everything
            width_txt.Enabled = true;
            heigh_txt.Enabled = true;
            size_button.Enabled = true;
            seed_num.Enabled = false;
            seed_button.Enabled = false;
            more_check.Enabled = false;
            p_check.Enabled = false;
            start_button.Enabled = false;
            Animation_button.Enabled = false;
            pause_button.Enabled = false;
            nexts_button.Enabled = false;
            import_cond_button.Enabled = false;
            import_cond_button.Visible = false;

            m1.phase = 0;

            width = 0;
            //m1.width = 0;
            height = 0;
            //m1.height = 0;
            seeds = 0;
            //m1.seeds = 0;
            intrusions = 0;
            radius_min = 0;
            radius_max = 0;
            m1.GBC = false;
        }
                                
        private void nexts_button_Click(object sender, EventArgs e)
        {
            if (tpl == true)
            {
                m1.taskStep.Start();
                m2.taskStep.Start();
                m3.taskStep.Start();
            }
            else
            {
                //one step button
                m1.step(pic_box);
                m2.step(pic_box);
                m3.step(pic_box);
            }


            if (m1.end_flag == true && m2.end_flag == true && m2.end_flag == true)
            {
                MessageBox.Show("All data processed");
            }
        }

        private void Animation_button_Click(object sender, EventArgs e)
        {
            //animation button
            Animation_button.Enabled = false;
            pause_button.Enabled = true;
            sw.Start();
            t.Start();

            m1.step(pic_box);
            m2.step(pic_box);
            m3.step(pic_box);

            pic_box.Image = m1.bmp;
            pic_box2.Image = m2.bmp;
            pic_box3.Image = m3.bmp;

            if (m1.end_flag == true && m2.end_flag == true && m2.end_flag == true)
            {
                sw.Stop();
                t.Stop();
                MessageBox.Show("All data processed");

                exectime.Text = sw.ElapsedMilliseconds.ToString();
            }
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            t.Stop();
            pause_button.Enabled = false;
            Animation_button.Enabled = true;
        }

        private void NextPhaseBut_Click(object sender, EventArgs e)
        {
            seed_label.Enabled = true;
            seed_button.Enabled = true;
            seed_num.Enabled = true;

            m1.phase = m1.phase + 1;
            seeds = 0;
            m1.seeds = 0;
            m1.seedsID = null;
            m1.seedsCol = null;

        }

        private void Width_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
