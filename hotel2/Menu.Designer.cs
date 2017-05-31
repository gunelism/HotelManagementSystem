namespace hotel2
{
    partial class Menu
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
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.bntFood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(42, 88);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(107, 42);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(221, 88);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(107, 42);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "Reservation";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(42, 162);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(107, 42);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // bntFood
            // 
            this.bntFood.Location = new System.Drawing.Point(221, 162);
            this.bntFood.Name = "bntFood";
            this.bntFood.Size = new System.Drawing.Size(107, 42);
            this.bntFood.TabIndex = 3;
            this.bntFood.Text = "Food";
            this.bntFood.UseVisualStyleBackColor = true;
            this.bntFood.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 360);
            this.Controls.Add(this.bntFood);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button bntFood;
    }
}