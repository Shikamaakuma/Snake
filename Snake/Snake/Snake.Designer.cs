namespace Snake
{
    partial class snake_FR
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
            this.start_BT = new System.Windows.Forms.Button();
            this.anouncer_LB = new System.Windows.Forms.Label();
            this.playground_PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playground_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // start_BT
            // 
            this.start_BT.Location = new System.Drawing.Point(365, 420);
            this.start_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_BT.Name = "start_BT";
            this.start_BT.Size = new System.Drawing.Size(240, 60);
            this.start_BT.TabIndex = 0;
            this.start_BT.Text = "Start";
            this.start_BT.UseVisualStyleBackColor = true;
            this.start_BT.Click += new System.EventHandler(this.Start_BT_Click);
            // 
            // anouncer_LB
            // 
            this.anouncer_LB.AutoEllipsis = true;
            this.anouncer_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anouncer_LB.Location = new System.Drawing.Point(0, 120);
            this.anouncer_LB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anouncer_LB.Name = "anouncer_LB";
            this.anouncer_LB.Size = new System.Drawing.Size(960, 91);
            this.anouncer_LB.TabIndex = 1;
            this.anouncer_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playground_PB
            // 
            this.playground_PB.BackColor = System.Drawing.Color.Snow;
            this.playground_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground_PB.InitialImage = global::Snake.Properties.Resources.white_800x800;
            this.playground_PB.Location = new System.Drawing.Point(0, 0);
            this.playground_PB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playground_PB.MaximumSize = new System.Drawing.Size(960, 960);
            this.playground_PB.MinimumSize = new System.Drawing.Size(960, 960);
            this.playground_PB.Name = "playground_PB";
            this.playground_PB.Size = new System.Drawing.Size(960, 960);
            this.playground_PB.TabIndex = 2;
            this.playground_PB.TabStop = false;
            // 
            // snake_FR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(958, 953);
            this.Controls.Add(this.anouncer_LB);
            this.Controls.Add(this.start_BT);
            this.Controls.Add(this.playground_PB);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(980, 1009);
            this.MinimumSize = new System.Drawing.Size(980, 1009);
            this.Name = "snake_FR";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.snake_FR_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.playground_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_BT;
        private System.Windows.Forms.Label anouncer_LB;
        private System.Windows.Forms.PictureBox playground_PB;
    }
}

