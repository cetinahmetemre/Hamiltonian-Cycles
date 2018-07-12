namespace hamiltoniancycles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.edgesbutton = new MetroFramework.Controls.MetroTile();
            this.vertexcountText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(503, 24);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(107, 91);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Vertex";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.vertexButton_Click);
            // 
            // edgesbutton
            // 
            this.edgesbutton.ActiveControl = null;
            this.edgesbutton.Location = new System.Drawing.Point(681, 24);
            this.edgesbutton.Name = "edgesbutton";
            this.edgesbutton.Size = new System.Drawing.Size(107, 91);
            this.edgesbutton.TabIndex = 1;
            this.edgesbutton.Text = "Edges";
            this.edgesbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edgesbutton.TileImage = ((System.Drawing.Image)(resources.GetObject("edgesbutton.TileImage")));
            this.edgesbutton.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edgesbutton.UseSelectable = true;
            this.edgesbutton.UseTileImage = true;
            this.edgesbutton.Click += new System.EventHandler(this.edgesbutton_Click);
            // 
            // vertexcountText
            // 
            this.vertexcountText.Location = new System.Drawing.Point(257, 55);
            this.vertexcountText.Name = "vertexcountText";
            this.vertexcountText.Size = new System.Drawing.Size(100, 20);
            this.vertexcountText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please write vertex count : ";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(379, 53);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Find Hamiltonian Cycles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(841, 518);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(91, 63);
            this.resetbutton.TabIndex = 8;
            this.resetbutton.Text = "RESET";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 635);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vertexcountText);
            this.Controls.Add(this.edgesbutton);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile edgesbutton;
        private System.Windows.Forms.TextBox vertexcountText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetbutton;
    }
}

