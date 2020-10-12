namespace TaskTwoNamespace
{
    partial class PlayGame
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
            this.components = new System.ComponentModel.Container();
            this.lbl_EnemiesRemaining = new System.Windows.Forms.Label();
            this.lbl_ActionStatus = new System.Windows.Forms.Label();
            this.lbl_HeroStats = new System.Windows.Forms.Label();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.lbl_MapView = new System.Windows.Forms.Label();
            this.btn_AttackUp = new System.Windows.Forms.Button();
            this.btn_AttackLeft = new System.Windows.Forms.Button();
            this.btn_AttackDown = new System.Windows.Forms.Button();
            this.btn_AttackRight = new System.Windows.Forms.Button();
            this.btn_SaveGame = new System.Windows.Forms.Button();
            this.lbl_AttackBtn = new System.Windows.Forms.Label();
            this.lbl_MoveBtn = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_EnemiesRemaining
            // 
            this.lbl_EnemiesRemaining.AutoSize = true;
            this.lbl_EnemiesRemaining.Location = new System.Drawing.Point(20, 21);
            this.lbl_EnemiesRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EnemiesRemaining.Name = "lbl_EnemiesRemaining";
            this.lbl_EnemiesRemaining.Size = new System.Drawing.Size(0, 13);
            this.lbl_EnemiesRemaining.TabIndex = 13;
            // 
            // lbl_ActionStatus
            // 
            this.lbl_ActionStatus.AutoSize = true;
            this.lbl_ActionStatus.Location = new System.Drawing.Point(670, 21);
            this.lbl_ActionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ActionStatus.Name = "lbl_ActionStatus";
            this.lbl_ActionStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_ActionStatus.TabIndex = 15;
            // 
            // lbl_HeroStats
            // 
            this.lbl_HeroStats.AutoSize = true;
            this.lbl_HeroStats.Location = new System.Drawing.Point(183, 10);
            this.lbl_HeroStats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HeroStats.Name = "lbl_HeroStats";
            this.lbl_HeroStats.Size = new System.Drawing.Size(0, 13);
            this.lbl_HeroStats.TabIndex = 16;
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(272, 437);
            this.btn_Right.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(84, 81);
            this.btn_Right.TabIndex = 8;
            this.btn_Right.Text = "Right >";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btnRight_Click_1);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(154, 362);
            this.btn_Up.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(84, 81);
            this.btn_Up.TabIndex = 9;
            this.btn_Up.Text = "Up /\\";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btnUp_Click_1);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(154, 517);
            this.btn_Down.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(84, 81);
            this.btn_Down.TabIndex = 10;
            this.btn_Down.Text = "Down \\/";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btnDown_Click_1);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(35, 437);
            this.btn_Left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(84, 81);
            this.btn_Left.TabIndex = 11;
            this.btn_Left.Text = "< Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // lbl_MapView
            // 
            this.lbl_MapView.AutoSize = true;
            this.lbl_MapView.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MapView.Location = new System.Drawing.Point(412, 110);
            this.lbl_MapView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MapView.Name = "lbl_MapView";
            this.lbl_MapView.Size = new System.Drawing.Size(0, 18);
            this.lbl_MapView.TabIndex = 17;
            // 
            // btn_AttackUp
            // 
            this.btn_AttackUp.Location = new System.Drawing.Point(820, 418);
            this.btn_AttackUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AttackUp.Name = "btn_AttackUp";
            this.btn_AttackUp.Size = new System.Drawing.Size(82, 81);
            this.btn_AttackUp.TabIndex = 18;
            this.btn_AttackUp.Text = "Up /\\";
            this.btn_AttackUp.UseVisualStyleBackColor = true;
            this.btn_AttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btn_AttackLeft
            // 
            this.btn_AttackLeft.Location = new System.Drawing.Point(702, 517);
            this.btn_AttackLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AttackLeft.Name = "btn_AttackLeft";
            this.btn_AttackLeft.Size = new System.Drawing.Size(82, 81);
            this.btn_AttackLeft.TabIndex = 18;
            this.btn_AttackLeft.Text = "< Left";
            this.btn_AttackLeft.UseVisualStyleBackColor = true;
            this.btn_AttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btn_AttackDown
            // 
            this.btn_AttackDown.Location = new System.Drawing.Point(820, 517);
            this.btn_AttackDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AttackDown.Name = "btn_AttackDown";
            this.btn_AttackDown.Size = new System.Drawing.Size(82, 81);
            this.btn_AttackDown.TabIndex = 18;
            this.btn_AttackDown.Text = "Down \\/";
            this.btn_AttackDown.UseVisualStyleBackColor = true;
            this.btn_AttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btn_AttackRight
            // 
            this.btn_AttackRight.Location = new System.Drawing.Point(934, 517);
            this.btn_AttackRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AttackRight.Name = "btn_AttackRight";
            this.btn_AttackRight.Size = new System.Drawing.Size(82, 81);
            this.btn_AttackRight.TabIndex = 18;
            this.btn_AttackRight.Text = "Right >";
            this.btn_AttackRight.UseVisualStyleBackColor = true;
            this.btn_AttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btn_SaveGame
            // 
            this.btn_SaveGame.Location = new System.Drawing.Point(404, 516);
            this.btn_SaveGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveGame.Name = "btn_SaveGame";
            this.btn_SaveGame.Size = new System.Drawing.Size(233, 82);
            this.btn_SaveGame.TabIndex = 19;
            this.btn_SaveGame.Text = "Save Game";
            this.btn_SaveGame.UseVisualStyleBackColor = true;
            this.btn_SaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // lbl_AttackBtn
            // 
            this.lbl_AttackBtn.AutoSize = true;
            this.lbl_AttackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AttackBtn.Location = new System.Drawing.Point(788, 386);
            this.lbl_AttackBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AttackBtn.Name = "lbl_AttackBtn";
            this.lbl_AttackBtn.Size = new System.Drawing.Size(153, 26);
            this.lbl_AttackBtn.TabIndex = 20;
            this.lbl_AttackBtn.Text = "Attack Buttons";
            // 
            // lbl_MoveBtn
            // 
            this.lbl_MoveBtn.AutoSize = true;
            this.lbl_MoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoveBtn.Location = new System.Drawing.Point(123, 461);
            this.lbl_MoveBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MoveBtn.Name = "lbl_MoveBtn";
            this.lbl_MoveBtn.Size = new System.Drawing.Size(145, 26);
            this.lbl_MoveBtn.TabIndex = 20;
            this.lbl_MoveBtn.Text = "Move Buttons";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 609);
            this.Controls.Add(this.lbl_MoveBtn);
            this.Controls.Add(this.lbl_AttackBtn);
            this.Controls.Add(this.btn_SaveGame);
            this.Controls.Add(this.btn_AttackRight);
            this.Controls.Add(this.btn_AttackDown);
            this.Controls.Add(this.btn_AttackLeft);
            this.Controls.Add(this.btn_AttackUp);
            this.Controls.Add(this.lbl_MapView);
            this.Controls.Add(this.lbl_EnemiesRemaining);
            this.Controls.Add(this.lbl_ActionStatus);
            this.Controls.Add(this.lbl_HeroStats);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Left);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayGame";
            this.Text = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EnemiesRemaining;
        private System.Windows.Forms.Label lbl_ActionStatus;
        private System.Windows.Forms.Label lbl_HeroStats;
        private System.Windows.Forms.Button btn_Right;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Label lbl_MapView;
        private System.Windows.Forms.Button btn_AttackUp;
        private System.Windows.Forms.Button btn_AttackLeft;
        private System.Windows.Forms.Button btn_AttackDown;
        private System.Windows.Forms.Button btn_AttackRight;
        private System.Windows.Forms.Button btn_SaveGame;
        private System.Windows.Forms.Label lbl_AttackBtn;
        private System.Windows.Forms.Label lbl_MoveBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}