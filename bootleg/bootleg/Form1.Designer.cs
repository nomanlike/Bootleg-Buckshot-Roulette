namespace bootleg
{
    partial class Bootleg_game
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
            this.Event_box = new System.Windows.Forms.TextBox();
            this.Him = new System.Windows.Forms.Button();
            this.Yourself = new System.Windows.Forms.Button();
            this.Lives_of_yours = new System.Windows.Forms.TextBox();
            this.Lives_of_his = new System.Windows.Forms.TextBox();
            this.Retry = new System.Windows.Forms.Button();
            this.end_turn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Event_box
            // 
            this.Event_box.Location = new System.Drawing.Point(221, 210);
            this.Event_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Event_box.Name = "Event_box";
            this.Event_box.ReadOnly = true;
            this.Event_box.Size = new System.Drawing.Size(269, 22);
            this.Event_box.TabIndex = 0;
            this.Event_box.Text = "Event shown";
            this.Event_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Him
            // 
            this.Him.Location = new System.Drawing.Point(380, 127);
            this.Him.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Him.Name = "Him";
            this.Him.Size = new System.Drawing.Size(109, 42);
            this.Him.TabIndex = 1;
            this.Him.Text = "Shoot Him";
            this.Him.UseVisualStyleBackColor = true;
            this.Him.Click += new System.EventHandler(this.button1_Click);
            // 
            // Yourself
            // 
            this.Yourself.Location = new System.Drawing.Point(221, 273);
            this.Yourself.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Yourself.Name = "Yourself";
            this.Yourself.Size = new System.Drawing.Size(109, 42);
            this.Yourself.TabIndex = 2;
            this.Yourself.Text = "Shoot yourself";
            this.Yourself.UseVisualStyleBackColor = true;
            this.Yourself.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lives_of_yours
            // 
            this.Lives_of_yours.Location = new System.Drawing.Point(221, 350);
            this.Lives_of_yours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lives_of_yours.Name = "Lives_of_yours";
            this.Lives_of_yours.ReadOnly = true;
            this.Lives_of_yours.Size = new System.Drawing.Size(100, 22);
            this.Lives_of_yours.TabIndex = 3;
            this.Lives_of_yours.TextChanged += new System.EventHandler(this.Lives_of_yours_TextChanged);
            // 
            // Lives_of_his
            // 
            this.Lives_of_his.Location = new System.Drawing.Point(389, 74);
            this.Lives_of_his.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lives_of_his.Name = "Lives_of_his";
            this.Lives_of_his.ReadOnly = true;
            this.Lives_of_his.Size = new System.Drawing.Size(100, 22);
            this.Lives_of_his.TabIndex = 4;
            this.Lives_of_his.TextChanged += new System.EventHandler(this.Lives_of_his_TextChanged);
            // 
            // Retry
            // 
            this.Retry.Location = new System.Drawing.Point(641, 273);
            this.Retry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(75, 42);
            this.Retry.TabIndex = 5;
            this.Retry.Text = "Retry";
            this.Retry.UseVisualStyleBackColor = true;
            this.Retry.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // end_turn
            // 
            this.end_turn.Location = new System.Drawing.Point(392, 273);
            this.end_turn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.end_turn.Name = "end_turn";
            this.end_turn.Size = new System.Drawing.Size(100, 42);
            this.end_turn.TabIndex = 6;
            this.end_turn.Text = "End your turn";
            this.end_turn.UseVisualStyleBackColor = true;
            this.end_turn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Bootleg_game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.end_turn);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.Lives_of_his);
            this.Controls.Add(this.Lives_of_yours);
            this.Controls.Add(this.Yourself);
            this.Controls.Add(this.Him);
            this.Controls.Add(this.Event_box);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bootleg_game";
            this.Text = "Bootleg Buckshot Roulette";
            this.Load += new System.EventHandler(this.Bootleg_game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Event_box;
        private System.Windows.Forms.Button Him;
        private System.Windows.Forms.Button Yourself;
        private System.Windows.Forms.TextBox Lives_of_yours;
        private System.Windows.Forms.TextBox Lives_of_his;
        private System.Windows.Forms.Button Retry;
        private System.Windows.Forms.Button end_turn;
    }
}

