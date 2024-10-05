namespace Catalog
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            filterComboBox = new ComboBox();
            sortComboBox = new ComboBox();
            searchTextBox = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            previousButton = new Button();
            nextButton = new Button();
            AddButton = new Button();
            ExitButton = new Button();
            manufacturerLabel = new Label();
            sortLabel = new Label();
            searchLabel = new Label();
            SuspendLayout();
            // 
            // filterComboBox
            // 
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Location = new Point(12, 41);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(168, 23);
            filterComboBox.TabIndex = 0;
            filterComboBox.SelectedIndexChanged += Update_SelectedIndexChanged;
            // 
            // sortComboBox
            // 
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Location = new Point(186, 41);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(168, 23);
            sortComboBox.TabIndex = 1;
            sortComboBox.SelectedIndexChanged += Update_SelectedIndexChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(360, 41);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(205, 23);
            searchTextBox.TabIndex = 2;
            searchTextBox.TextChanged += Update_SelectedIndexChanged;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(12, 70);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(669, 470);
            flowLayoutPanel.TabIndex = 3;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(12, 546);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(75, 23);
            previousButton.TabIndex = 4;
            previousButton.Text = "<";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += PreviousButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(597, 546);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 5;
            nextButton.Text = ">";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += NextButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(571, 12);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(110, 23);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить товар";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(571, 41);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(110, 23);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Выход";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new Point(12, 16);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new Size(92, 15);
            manufacturerLabel.TabIndex = 8;
            manufacturerLabel.Text = "Производитель";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(186, 15);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(73, 15);
            sortLabel.TabIndex = 9;
            sortLabel.Text = "Сортировка";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(360, 16);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(42, 15);
            searchLabel.TabIndex = 10;
            searchLabel.Text = "Поиск";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 576);
            Controls.Add(searchLabel);
            Controls.Add(sortLabel);
            Controls.Add(manufacturerLabel);
            Controls.Add(ExitButton);
            Controls.Add(AddButton);
            Controls.Add(nextButton);
            Controls.Add(previousButton);
            Controls.Add(flowLayoutPanel);
            Controls.Add(searchTextBox);
            Controls.Add(sortComboBox);
            Controls.Add(filterComboBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каталог";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox filterComboBox;
        private ComboBox sortComboBox;
        private TextBox searchTextBox;
        private FlowLayoutPanel flowLayoutPanel;
        private Button previousButton;
        private Button nextButton;
        private Button AddButton;
        private Button ExitButton;
        private Label manufacturerLabel;
        private Label sortLabel;
        private Label searchLabel;
    }
}
