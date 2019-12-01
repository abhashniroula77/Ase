using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace ASE_Component_I
{
    /// <summary>
    /// class form 1 
    /// </summary>
    public partial class Form1 : Form

    {
        string[] commands = { "drawto", "moveto", "rectangle", "circle", "triangle"};
        public bool command2 = false;
        public int xAxis = 0;
        public int yAxis = 0;
        public bool execute = false;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is a method to move pen
        /// </summary>
        /// <param name="x"> x for taking postion of x axis </param>
        /// <param name="y">position of y axis</param>
        public void movepen(int x, int y)//method to move pen
        {
            Pen p = new Pen(Color.Black, 3);
            xAxis = x;
            yAxis = y;




        }
        /// <summary>
        /// this method is for checking commands 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool methodcheck(string line)
        {
            for (int j = 0; j < commands.Length ; j++)
            {
                if (line.Contains(commands[j]))
                {
                    return true;
                } 


                        }return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this nethod is for drawwing in panel
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void drawpen(int a, int b)
        {
            Pen p = new Pen(Color.Black, 3);
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(p, xAxis, yAxis, a, b);
            xAxis = a;
            yAxis = b;
        }
        /// <summary>
        /// buttton for run which executes all the processes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {
            execute = false;
            var command = textBox1.Text;
            string[] multipleLine = command.Split('\n');

            for (int k = 0; k < multipleLine.Length-1;k++)

            {
                bool test = methodcheck(multipleLine[k].ToLower());
                if (!test)
                {
                    textBox2.Text = "Command not found : Error on line" +(k + 1);
                    panel1.Refresh();
                    break;
                }
                String abc = multipleLine[k].Trim();
                string[] split = abc.Split('(');//split array 


                try
                {


                    if (string.Compare(split[0].ToLower(), "moveto") == 0)
                    {
                        String[] split1 = split[1].Split(',');
                        String[] split2 = split1[1].Split(')');//for draw to and move to
                        String a = split1[0];
                        String b = split2[0];
                        movepen(int.Parse(a), int.Parse(b));//converting
                        if (split1.Length == 2)
                            movepen(int.Parse(a), int.Parse(b));
                        else
                            throw new ArgumentException("This takes only two parameter");

                    }
                    else if (split[0].Equals("\n"))
                    {

                    }
                    else if (string.Compare(split[0].ToLower(), "drawto") == 0)
                    {
                        String[] parameter1 = split[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        drawpen(int.Parse(p1), int.Parse(p2));
                        if (parameter1.Length == 2)
                            drawpen(int.Parse(p1), int.Parse(p2));
                        else
                            throw new ArgumentException("This takes only two parameter");
                    }

                    else if (string.Compare(split[0].ToLower(), "clear") == 0)
                    {
                        revfresh();
                    }

                    else if (string.Compare(split[0].ToLower(), "clear") == 0)
                    {
                        reset();
                    }

                    else if (string.Compare(split[0].ToLower(), "rectangle") == 0)
                    {
                        String[] parameter1 = split[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        rectangle_draw(xAxis, yAxis, int.Parse(p1), int.Parse(p2));
                        if (parameter1.Length == 2)
                            rectangle_draw(xAxis, yAxis, int.Parse(p1), int.Parse(p2));
                        else
                            throw new ArgumentException("This takes only two parameter");

                    }

                    else if (string.Compare(split[0].ToLower(), "triangle") == 0)
                    {
                        String[] parameter1 = split[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(',');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        triangle_draw(xAxis, yAxis, int.Parse(p1), int.Parse(p2));
                    }

                    else if (string.Compare(split[0].ToLower(), "circle") == 0)
                    {
                        String[] parameter2 = split[1].Split(')');
                        String p2 = parameter2[0];
                        circle_draw(xAxis, yAxis, int.Parse(p2));
                        if (p2 != null || p2 != "" || p2 != " ")//checking for circle parameter
                        {
                            circle_draw(xAxis, yAxis, int.Parse(p2));
                        }
                        else
                        {
                            throw new ArgumentException("This only takes one parameter");
                        }
                    }


                }
                
                catch(ArgumentException y) 
                {
                    textBox2.Text = y.Message + "Error in line" + (k+1)+"\n";//to show which error on which line
                    
                }
                catch(Exception)
                {
                    textBox2.Text = "paramter error  on line" + (k+1)+"\n";//to show paramter error on line
                    panel1.Refresh();
                    break;
                    
                }
            }
            execute = true;



        }
        /// <summary>
        /// method for clearing method
        /// </summary>
        private void revfresh()//clearing panel
        {
            panel1.Refresh();
            
        }
        /// <summary>
        /// method for reseting the initial position to normal
        /// </summary>
        private void reset()//setting the position to 00
        {
            xAxis = 0;
            yAxis = 0;
        }
        /// <summary>
        /// drawing rectangle method 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public void rectangle_draw(int a, int b, int c, int d)
        {
            Rectangle r= new Rectangle();
            r.values(a, b, c, d);
            Graphics g = panel1.CreateGraphics();
            r.shaped(g);
        }
        /// <summary>
        /// drawing circle method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void circle_draw(int a, int b, int c)
        {
            Circle cd = new Circle();
            cd.values(a, b, c);
            Graphics g = panel1.CreateGraphics();
            cd.shaped(g);
        }

        public void triangle_draw(int x, int y, int z, int w)
        {
            Triangle tri = new Triangle();
            tri.values(x, y, z, w);
            Graphics g = panel1.CreateGraphics();
            tri.shaped(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
        /// <summary>
        /// button for clearing all the files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            revfresh();
            textBox2.Text = "";
            textBox1.Text = "";
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// button for saving which contains code for saving file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ok = textBox1.Text;//checking textfield is empty or not
            if (ok.Length != 0)
            {



                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File (.txt)| *.txt";
                saveFileDialog.Title = "Save File...";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter fWriter = new StreamWriter(saveFileDialog.FileName);
                    fWriter.Write(textBox1.Text);
                    fWriter.Close();
                }
                MessageBox.Show("Command save");
            }
            else
            {
                MessageBox.Show("Cannot save empty field");
            }
        }
        /// <summary>
        /// button for loading files which contains all the code for loading file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text File (.txt)|*.txt";
            loadFileDialog.Title = "Open File...";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(loadFileDialog.FileName);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
        /// <summary>
        /// for closing program
        /// </summary>
        /// <param name="sender">parameter name for sending </param>
        /// <param name="e">event parameter name for object click</param>
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            





        }
        /// <summary>
        /// button to show what is the programabout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Createdby:Abhash Niroula \n Asc component 1 ");
        }
    }
    }
        
    

    