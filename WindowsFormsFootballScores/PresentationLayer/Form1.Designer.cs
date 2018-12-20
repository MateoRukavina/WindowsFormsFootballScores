namespace PresentationLayer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.League = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentMatchday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfMatchdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfTeams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfGames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Caption,
            this.League,
            this.Year,
            this.CurrentMatchday,
            this.NumberOfMatchdays,
            this.NumberOfTeams,
            this.NumberOfGames,
            this.LastUpdated});
            this.dataGridView1.Location = new System.Drawing.Point(23, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1088, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Caption
            // 
            this.Caption.DataPropertyName = "Caption";
            this.Caption.HeaderText = "Caption";
            this.Caption.Name = "Caption";
            // 
            // League
            // 
            this.League.DataPropertyName = "League";
            this.League.HeaderText = "League";
            this.League.Name = "League";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // CurrentMatchday
            // 
            this.CurrentMatchday.DataPropertyName = "CurrentMatchday";
            this.CurrentMatchday.HeaderText = "CurrentMatchday";
            this.CurrentMatchday.Name = "CurrentMatchday";
            // 
            // NumberOfMatchdays
            // 
            this.NumberOfMatchdays.DataPropertyName = "NumberOfMatchdays";
            this.NumberOfMatchdays.HeaderText = "NumberOfMatchdays";
            this.NumberOfMatchdays.Name = "NumberOfMatchdays";
            // 
            // NumberOfTeams
            // 
            this.NumberOfTeams.DataPropertyName = "NumberOfTeams";
            this.NumberOfTeams.HeaderText = "NumberOfTeams";
            this.NumberOfTeams.Name = "NumberOfTeams";
            // 
            // NumberOfGames
            // 
            this.NumberOfGames.DataPropertyName = "NumberOfGames";
            this.NumberOfGames.HeaderText = "NumberOfGames";
            this.NumberOfGames.Name = "NumberOfGames";
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "LastUpdated";
            this.LastUpdated.HeaderText = "LastUpdated";
            this.LastUpdated.Name = "LastUpdated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(437, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Football Leagues";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 654);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caption;
        private System.Windows.Forms.DataGridViewTextBoxColumn League;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentMatchday;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfMatchdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfGames;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
    }
}

