namespace GADE_1b_redo
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
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.lbl_playerInfo = new System.Windows.Forms.Label();
            this.lBox_pInfo = new System.Windows.Forms.ListBox();
            this.lBox_extraData = new System.Windows.Forms.ListBox();
            this.lbl_gameView = new System.Windows.Forms.Label();
            this.txtbox_maxWidth = new System.Windows.Forms.TextBox();
            this.txtbox_minHeight = new System.Windows.Forms.TextBox();
            this.txtbox_minWidth = new System.Windows.Forms.TextBox();
            this.txtbox_maxHeight = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_hMax = new System.Windows.Forms.Label();
            this.lbl_minHeight = new System.Windows.Forms.Label();
            this.lbl_maxWidth = new System.Windows.Forms.Label();
            this.lbl_minWidth = new System.Windows.Forms.Label();
            this.lbl_game = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Up
            // 
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Up.Location = new System.Drawing.Point(551, 263);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(75, 57);
            this.btn_Up.TabIndex = 0;
            this.btn_Up.Text = "^";
            this.btn_Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Up.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_down.Location = new System.Drawing.Point(551, 381);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 57);
            this.btn_down.TabIndex = 1;
            this.btn_down.Text = "V";
            this.btn_down.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_left.Location = new System.Drawing.Point(470, 319);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 57);
            this.btn_left.TabIndex = 3;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_right.Location = new System.Drawing.Point(632, 319);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(75, 57);
            this.btn_right.TabIndex = 4;
            this.btn_right.Text = ">";
            this.btn_right.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // lbl_playerInfo
            // 
            this.lbl_playerInfo.AutoSize = true;
            this.lbl_playerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerInfo.Location = new System.Drawing.Point(408, 39);
            this.lbl_playerInfo.Name = "lbl_playerInfo";
            this.lbl_playerInfo.Size = new System.Drawing.Size(261, 31);
            this.lbl_playerInfo.TabIndex = 5;
            this.lbl_playerInfo.Text = "Player Information:";
            // 
            // lBox_pInfo
            // 
            this.lBox_pInfo.FormattingEnabled = true;
            this.lBox_pInfo.Location = new System.Drawing.Point(508, 73);
            this.lBox_pInfo.Name = "lBox_pInfo";
            this.lBox_pInfo.Size = new System.Drawing.Size(210, 108);
            this.lBox_pInfo.TabIndex = 7;
            // 
            // lBox_extraData
            // 
            this.lBox_extraData.FormattingEnabled = true;
            this.lBox_extraData.Location = new System.Drawing.Point(26, 400);
            this.lBox_extraData.Name = "lBox_extraData";
            this.lBox_extraData.Size = new System.Drawing.Size(365, 43);
            this.lBox_extraData.TabIndex = 9;
            // 
            // lbl_gameView
            // 
            this.lbl_gameView.AutoSize = true;
            this.lbl_gameView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameView.Location = new System.Drawing.Point(20, 5);
            this.lbl_gameView.Name = "lbl_gameView";
            this.lbl_gameView.Size = new System.Drawing.Size(171, 31);
            this.lbl_gameView.TabIndex = 10;
            this.lbl_gameView.Text = "Game View:";
            // 
            // txtbox_maxWidth
            // 
            this.txtbox_maxWidth.Location = new System.Drawing.Point(432, 197);
            this.txtbox_maxWidth.Name = "txtbox_maxWidth";
            this.txtbox_maxWidth.Size = new System.Drawing.Size(100, 20);
            this.txtbox_maxWidth.TabIndex = 11;
            // 
            // txtbox_minHeight
            // 
            this.txtbox_minHeight.Location = new System.Drawing.Point(607, 232);
            this.txtbox_minHeight.Name = "txtbox_minHeight";
            this.txtbox_minHeight.Size = new System.Drawing.Size(100, 20);
            this.txtbox_minHeight.TabIndex = 12;
            // 
            // txtbox_minWidth
            // 
            this.txtbox_minWidth.Location = new System.Drawing.Point(432, 232);
            this.txtbox_minWidth.Name = "txtbox_minWidth";
            this.txtbox_minWidth.Size = new System.Drawing.Size(100, 20);
            this.txtbox_minWidth.TabIndex = 13;
            // 
            // txtbox_maxHeight
            // 
            this.txtbox_maxHeight.Location = new System.Drawing.Point(607, 197);
            this.txtbox_maxHeight.Name = "txtbox_maxHeight";
            this.txtbox_maxHeight.Size = new System.Drawing.Size(100, 20);
            this.txtbox_maxHeight.TabIndex = 14;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(717, 228);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 15;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_hMax
            // 
            this.lbl_hMax.AutoSize = true;
            this.lbl_hMax.Location = new System.Drawing.Point(543, 200);
            this.lbl_hMax.Name = "lbl_hMax";
            this.lbl_hMax.Size = new System.Drawing.Size(58, 13);
            this.lbl_hMax.TabIndex = 16;
            this.lbl_hMax.Text = "MaxHeight";
            // 
            // lbl_minHeight
            // 
            this.lbl_minHeight.AutoSize = true;
            this.lbl_minHeight.Location = new System.Drawing.Point(543, 235);
            this.lbl_minHeight.Name = "lbl_minHeight";
            this.lbl_minHeight.Size = new System.Drawing.Size(55, 13);
            this.lbl_minHeight.TabIndex = 17;
            this.lbl_minHeight.Text = "MinHeight";
            // 
            // lbl_maxWidth
            // 
            this.lbl_maxWidth.AutoSize = true;
            this.lbl_maxWidth.Location = new System.Drawing.Point(368, 200);
            this.lbl_maxWidth.Name = "lbl_maxWidth";
            this.lbl_maxWidth.Size = new System.Drawing.Size(55, 13);
            this.lbl_maxWidth.TabIndex = 18;
            this.lbl_maxWidth.Text = "MaxWidth";
            // 
            // lbl_minWidth
            // 
            this.lbl_minWidth.AutoSize = true;
            this.lbl_minWidth.Location = new System.Drawing.Point(368, 233);
            this.lbl_minWidth.Name = "lbl_minWidth";
            this.lbl_minWidth.Size = new System.Drawing.Size(52, 13);
            this.lbl_minWidth.TabIndex = 19;
            this.lbl_minWidth.Text = "MinWidth";
            // 
            // lbl_game
            // 
            this.lbl_game.AutoSize = true;
            this.lbl_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game.Location = new System.Drawing.Point(20, 73);
            this.lbl_game.Name = "lbl_game";
            this.lbl_game.Size = new System.Drawing.Size(171, 31);
            this.lbl_game.TabIndex = 20;
            this.lbl_game.Text = "Game View:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_game);
            this.Controls.Add(this.lbl_minWidth);
            this.Controls.Add(this.lbl_maxWidth);
            this.Controls.Add(this.lbl_minHeight);
            this.Controls.Add(this.lbl_hMax);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txtbox_maxHeight);
            this.Controls.Add(this.txtbox_minWidth);
            this.Controls.Add(this.txtbox_minHeight);
            this.Controls.Add(this.txtbox_maxWidth);
            this.Controls.Add(this.lbl_gameView);
            this.Controls.Add(this.lBox_extraData);
            this.Controls.Add(this.lBox_pInfo);
            this.Controls.Add(this.lbl_playerInfo);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_Up);
            this.Name = "Form1";
            this.Text = "Rogue-Like";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Label lbl_playerInfo;
        private System.Windows.Forms.ListBox lBox_pInfo;
        private System.Windows.Forms.ListBox lBox_extraData;
        private System.Windows.Forms.Label lbl_gameView;
        private System.Windows.Forms.TextBox txtbox_maxWidth;
        private System.Windows.Forms.TextBox txtbox_minHeight;
        private System.Windows.Forms.TextBox txtbox_minWidth;
        private System.Windows.Forms.TextBox txtbox_maxHeight;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_hMax;
        private System.Windows.Forms.Label lbl_minHeight;
        private System.Windows.Forms.Label lbl_maxWidth;
        private System.Windows.Forms.Label lbl_minWidth;
        private System.Windows.Forms.Label lbl_game;
    }
}

