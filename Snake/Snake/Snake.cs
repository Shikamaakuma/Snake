using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class snake_FR : Form
    {
        int gameStart;
        SnakeTheAnimal Player = new SnakeTheAnimal();
        Graphics gameGraphics;
        Rectangle[] graphicsBody = new Rectangle[0];
        SolidBrush snakeColor = new SolidBrush(Color.Green);
        String[] anouncerText = {"","Go","1","2","3"};
        int[][] field;
        Timer snakeMoves;
        bool newFood;
        int[] foodAt;

        public snake_FR()
        {
            InitializeComponent();
        }
        
        //to start the game
        private void Start_BT_Click(object sender, EventArgs e)
        {
            start_BT.Visible = false;
            newColisionMatrix();
            Snake_Game();
        }

        private void Snake_Game()
        {
            this.snakeColor = new SolidBrush(Color.Green);
            this.gameGraphics = playground_PB.CreateGraphics();
            this.snakeMoves = new Timer();
            this.snakeMoves.Interval = 500;
            this.snakeMoves.Tick += new EventHandler(OnTimedEvent);
            this.gameStart = 4;
            this.newFood = true;
            this.gameGraphics = playground_PB.CreateGraphics();
            this.snakeMoves.Start();
            this.snakeMoves.Enabled=true;
        }

        private void OnTimedEvent(Object myObject, EventArgs myEventArgs)
        {
            this.gameGraphics.Clear(Color.Snow);

            switch (gameStart)
            {
                case -1:
                    this.Player.move();
                    this.Player.lastKey(0);
                    drawFrame();
                    break;

                case 0:
                    anouncer_LB.Text = "";
                    anouncer_LB.Visible = false;
                    this.gameStart--;
                    drawFrame();
                    break;

                case 1:
                case 2:
                case 3:
                case 4:
                    anouncer_LB.Text = this.anouncerText[gameStart];
                    this.gameStart--;
                    break;
            }
        }
        //draws the rectangle for the snake gets the informations from body and creates the collision matrix
        private void drawFrame()
        {
            newColisionMatrix();
            if (this.newFood == true)
            {
                spornNewFood();
            }

            LinkedList<Limb>body = this.Player.getBody();
            if (this.graphicsBody.Length != body.Count)
                this.graphicsBody = new Rectangle[body.Count];

            int[] currentLimb;
            int i = 0;
            drawColisionMatrix(new int[] { this.foodAt[0] * 20, this.foodAt[1] * 20 }, 2);
            this.gameGraphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(foodAt[0]*20, foodAt[1]*20, 20, 20));
            foreach (Limb lm in body)
            {
                currentLimb = body.ElementAt(i).getPosition();
                drawColisionMatrix(currentLimb,1);
                this.graphicsBody[i] = new Rectangle(currentLimb[0], currentLimb[1], playground_PB.Width/40, playground_PB.Height/40);
                i++;
            }

            foreach(Rectangle rec in this.graphicsBody)
            {
                this.gameGraphics.FillRectangle(this.snakeColor, rec);
            }

            this.newFood = colisionCheck(body.First().getPosition());
        }

        //saves the last keypress to change the direction of snake;
        private void snake_FR_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.Player.lastKey(+1);
                    break;

                case Keys.Right:
                    this.Player.lastKey(-1);
                    break;
                default:

                    break;
            }
        }

        //checks wheter colision happened does nothing if not and if yes decides wheter its game over or eaten
        //returns true if the snake ate soemthing
        private bool colisionCheck (int[] head)
        {
           switch( field[head[0] / 20][head[1] / 20])
            {
                case 1:
                    return false;

                case 2:
                    snakeMoves.Stop();
                    return false;

                case 3:
                    this.Player.eat(head);
                    return true;

                default:
                    Console.WriteLine("something weird happened");
                    return false;

            }
        }

        //fills the colisionMatrix
        private void drawColisionMatrix(int[] newLimb, int value)
        {
            field[newLimb[0] / 20] [newLimb[1] / 20] += value;
        }

        //resets the colisionMatrix
        private void newColisionMatrix()
        {
            field = new int[playground_PB.Width / 20][];
            for (int i = 0; i < playground_PB.Width / 20; i++)
            {
                field[i] = new int[playground_PB.Height / 20];
                for(int j = 0; j < playground_PB.Height / 20; j++)
                {
                    field[i][j] = 0;
                }
            }
        }

        public void spornNewFood()
        {
            Random randy = new Random();

            int foodX = randy.Next(0, playground_PB.Width / 20);
            int foodY = randy.Next(0, playground_PB.Height / 20);

            this.foodAt = new int [] {foodX,foodY };
        }
    }
}