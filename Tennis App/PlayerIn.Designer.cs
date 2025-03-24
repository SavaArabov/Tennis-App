namespace Tennis_App
{
    partial class PlayerIn
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            listViewLosses = new ListView();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            listViewDraw = new ListView();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 20F);
            labelPlayerName.Location = new Point(271, 30);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(167, 37);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            labelPlayerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 13F);
            labelVictories.Location = new Point(61, 100);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(79, 25);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            labelVictories.Click += label1_Click;
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 13F);
            labelLosses.Location = new Point(319, 100);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(64, 25);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI", 13F);
            labelDraw.Location = new Point(565, 100);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(53, 25);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.PeachPuff;
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(40, 142);
            listViewVictories.Margin = new Padding(3, 2, 3, 2);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(161, 123);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.PeachPuff;
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(271, 145);
            listViewLosses.Margin = new Padding(3, 2, 3, 2);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(174, 123);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // competitorLosses
            // 
            competitorLosses.Text = "Competitor";
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.PeachPuff;
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(508, 145);
            listViewDraw.Margin = new Padding(3, 2, 3, 2);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(162, 123);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            // 
            // PlayerIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(700, 338);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PlayerIn";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}