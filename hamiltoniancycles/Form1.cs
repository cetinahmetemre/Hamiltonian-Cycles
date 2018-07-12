using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hamiltoniancycles
{
    public partial class Form1 : Form
    {
        Label[] items;
        int[,] vertexmatris;
        int additem = 0, itemcount = 0, edgestack = 0, x1, y1, V = 0, edgescount=0;
        string firstvertexname = "";
        int[] path;
        Pen[] p;
        string[] edgesname;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vertexButton_Click(object sender, EventArgs e)
        {
            additem = 1;
        }

        private void edgesbutton_Click(object sender, EventArgs e)
        {
            additem = 2;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (additem == 0);

            if (additem == 1)
                addVertex(e.X,e.Y);

            if (additem == 2) ;
            
        }



        private void addEdges(int x , int y , int x1 , int y1 , string firstvertexname , string secondvertexname)
        {
            g = CreateGraphics();
            p[edgescount] = new Pen(Color.Black, 5);
            g.DrawLine(p[edgescount],x,y,x1,y1);
            edgesname[edgescount] = firstvertexname + secondvertexname;
            additem = 0;
            edgestack = 0;
            g.Dispose();
            edgescount++;
            vertexmatris[Convert.ToInt16(firstvertexname), Convert.ToInt16(secondvertexname)] = 1;
            vertexmatris[Convert.ToInt16(secondvertexname), Convert.ToInt16(firstvertexname)] = 1;
        }


        public void addVertex(int x , int y)
        {
            if (itemcount < V)
            {
                Image i = Image.FromFile(@"vertex.png");
                items[itemcount] = new Label();
                items[itemcount].Size = new System.Drawing.Size(53, 67);
                items[itemcount].Location = new System.Drawing.Point(x, y);
                items[itemcount].BackColor = System.Drawing.Color.Transparent;
                items[itemcount].Name = itemcount+"";
                items[itemcount].Image = i;
                items[itemcount].Text = "" + itemcount;
                items[itemcount].Font = new Font("Arial", 40, FontStyle.Bold);
                items[itemcount].Click += new EventHandler(this.label_click);
                this.Controls.Add(items[itemcount]);
                additem = 0;
                itemcount++;
            }
            else
                MessageBox.Show("You have reached the maximum number");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (vertexcountText.Text == "")
                MessageBox.Show("Please write vertex count");
            else
            {
                items = new Label[Convert.ToInt16(vertexcountText.Text)*5];
                p = new Pen[Convert.ToInt16(vertexcountText.Text) * 5];
                edgesname = new string[Convert.ToInt16(vertexcountText.Text) * 5];
                
                vertexmatris = new int[Convert.ToInt32(vertexcountText.Text), Convert.ToInt32(vertexcountText.Text)];
                V = Convert.ToInt32(vertexcountText.Text);

                for(int i = 0 ; i<Convert.ToInt32(vertexcountText.Text) ; i++)
                {
                    for (int j = 0; j < Convert.ToInt32(vertexcountText.Text); j++)
                    {
                        vertexmatris[i, j] = 0;
                    }
                }
            }
        }


        private void label_click(object sender , EventArgs e)
        {
            Label label = sender as Label;

            if(additem == 2)
            {
                if (edgestack == 0)
                {
                    x1 = label.Location.X;
                    y1 = label.Location.Y;
                    edgestack++;
                    firstvertexname = label.Name;
                }
                else
                    addEdges(x1, y1, label.Location.X, label.Location.Y, firstvertexname, label.Name);               

                
               
           }
        }


            private bool isSafe(int v, int[,] graph, int[] path, int pos)
            {
                if (graph[path[pos - 1],v] == 0)
                    return false;
 
                for (int i = 0; i < pos; i++)
                    if (path[i] == v)
                        return false;
 
                return true;
            }

            private bool hamCycleUtil(int[,] graph, int[] path, int pos)
            {
               
                if (pos == V)
                {
                    
                    if (graph[path[pos - 1],path[0]] == 1)
                        return true;
                    else
                        return false;
                }
 
              
                for (int v = 1; v < V; v++)
                {
                 
                    if (isSafe(v, graph, path, pos))
                    {
                        path[pos] = v;
 
                       
                        if (hamCycleUtil(graph, path, pos + 1) == true)
                            return true;
 
                      
                        path[pos] = -1;
                    }
                }
 
              
                return false;
            }
 
       
        private int hamCycle(int[,] graph)
        {
            path = new int[V];
            for (int i = 0; i < V; i++)
                path[i] = -1;
 
           
            path[0] = 0;
            if (hamCycleUtil(graph, path, 1) == false)
            {
                label1.Text="Solution does not exist";
                return 0;
            }
 
            printSolution(path);
            return 1;
        }
 
      
        private void printSolution(int[] path)
        {
            label1.Text="Solution Exists: Following" +
                               " is one Hamiltonian Cycle : ";
            for (int i = 0; i < V; i++)
            {
                label1.Text += " " + path[i] + " ";

                for(int j = 0 ; j < edgescount ; j++)
                {

                    if (i < V - 1 && (edgesname[j] == path[i].ToString() + path[i + 1].ToString() || edgesname[j] == path[i+1].ToString() + path[i].ToString()))
                    {
                        Console.WriteLine(edgesname[j]);
                        //addEdges(items[path[i]].Location.X, items[path[i]].Location.Y, items[path[i + 1]].Location.X, items[path[i+1]].Location.Y,path[i].ToString(),path[i+1].ToString());
                        g = CreateGraphics();
                        Pen a = new Pen(Color.Red, 5);
                        g.DrawLine(a, items[path[i]].Location.X, items[path[i]].Location.Y, items[path[i + 1]].Location.X, items[path[i + 1]].Location.Y);
                       
                    }
                }
            }
 
         
          label1.Text += " " + path[0] + " ";
          Pen b = new Pen(Color.Red, 5);
          g.DrawLine(b, items[path[path.Length-1]].Location.X, items[path[path.Length-1]].Location.Y, items[path[0]].Location.X, items[path[0]].Location.Y);
          g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( itemcount == V && itemcount != 0)
                hamCycle(vertexmatris);
            else
                MessageBox.Show("Please add more vertex");
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i<itemcount ; i++)
            {
                items[i].Visible = false;
            }

            try
            {
                this.Invalidate();
            }

            catch(Exception exp)
            {

            }
            itemcount = 0;
            additem = 0;
            firstvertexname = "";
            label1.Text = "";
            edgestack=0;
            edgescount = 0;
            vertexcountText.Text = "";
            V = 0;
        }

       
    }
}
