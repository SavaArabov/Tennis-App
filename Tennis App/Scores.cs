using System.Drawing.Text;

namespace Tennis_App
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            labelClickOnName = new Label();
            listViewLatestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            labelLatestGames = new Label();
            buttonAddNewGame = new Button();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 20F);
            labelTennisScore.ImageAlign = ContentAlignment.TopCenter;
            labelTennisScore.Location = new Point(324, 9);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.RightToLeft = RightToLeft.No;
            labelTennisScore.Size = new Size(162, 37);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score";
            labelTennisScore.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 13F);
            labelRanking.Location = new Point(127, 54);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(76, 25);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.BackColor = Color.PeachPuff;
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.Location = new Point(127, 99);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(607, 121);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            listViewRanking.DoubleClick += ViewProfileButtonClick;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "Player Name";
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            scoreColumn.TextAlign = HorizontalAlignment.Right;
            // 
            // labelClickOnName
            // 
            labelClickOnName.AutoSize = true;
            labelClickOnName.Location = new Point(127, 223);
            labelClickOnName.Name = "labelClickOnName";
            labelClickOnName.Size = new Size(381, 15);
            labelClickOnName.TabIndex = 3;
            labelClickOnName.Text = "*click on a player's name to see more information about their matches.";
            // 
            // listViewLatestGames
            // 
            listViewLatestGames.BackColor = Color.PeachPuff;
            listViewLatestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLatestGames.Location = new Point(127, 313);
            listViewLatestGames.Name = "listViewLatestGames";
            listViewLatestGames.Size = new Size(615, 121);
            listViewLatestGames.TabIndex = 4;
            listViewLatestGames.UseCompatibleStateImageBehavior = false;
            listViewLatestGames.View = View.Details;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "Total Score";
            // 
            // labelLatestGames
            // 
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 13F);
            labelLatestGames.Location = new Point(127, 267);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(117, 25);
            labelLatestGames.TabIndex = 5;
            labelLatestGames.Text = "Latest Games";
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.BackColor = Color.Aquamarine;
            buttonAddNewGame.ForeColor = Color.Black;
            buttonAddNewGame.Location = new Point(609, 267);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(133, 29);
            buttonAddNewGame.TabIndex = 6;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = false;
            buttonAddNewGame.Click += AddNewGame;
            // 
            // Scores
            // 
            BackColor = Color.Khaki;
            ClientSize = new Size(820, 489);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelLatestGames);
            Controls.Add(listViewLatestGames);
            Controls.Add(labelClickOnName);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "Scores";
            RightToLeftLayout = true;
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        private static Dictionary<string, int> playersWithPoints = new();
        private static Dictionary<(string, int), List<(string, int)>> games = new();

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();

            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {
            listViewRanking.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                ListViewItem item = new ListViewItem(player.Key);

                item.SubItems.Add(player.Value.ToString());

                listViewRanking.Items.Add(item);
            }
        }

        private void FillLatestGamesListView()
        {
            listViewLatestGames.Items.Clear();

            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem item = new ListViewItem(firstPlayer.Item1);
            item.SubItems.Add(secondPlayer.Item1);
            item.SubItems.Add(winner);
            item.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            listViewLatestGames.Items.Add(item);
        }

        private string GetWinner((string, int) firstP, (string, int) secondPlayer)
        {
            return firstP.Item2 > secondPlayer.Item2 ? firstP.Item1 : secondPlayer.Item1;
        }

        private void AddNewGame(object sender, EventArgs e)
        {
            using (NewGame newGameForm = new NewGame())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (!games.ContainsKey(firstPlayer))
            {
                games[firstPlayer] = new List<(string, int)>();
            }
            games[firstPlayer].Add(secondPlayer);
        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints[player.Item1] = player.Item2;
            }
        }
    


private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];

            ListViewItem.ListViewSubItem playerNameCell = selectedRow.SubItems[0];

            string playerName = playerNameCell.Text;

            using (PlayerIn playerInfoForm = new PlayerIn(playerName, GetPlayerGames(playerName)))
            {
                playerInfoForm.ShowDialog();
            }



        }
        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName) => games.Where(x => x.Key.Item1 == playerName
        || x.Value.Any(y => y.Item1 == playerName)).ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName).ToList());


        

        
    }
}
