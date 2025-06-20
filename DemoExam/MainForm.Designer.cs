namespace DemoExam;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        flowLayoutPanel_ForCards = new FlowLayoutPanel();
        label_CompanyName = new Label();
        pictureBox_Logo = new PictureBox();
        UpperPanel = new Panel();
        ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
        UpperPanel.SuspendLayout();
        SuspendLayout();
        // 
        // flowLayoutPanel_ForCards
        // 
        flowLayoutPanel_ForCards.AutoScroll = true;
        flowLayoutPanel_ForCards.BackColor = Color.White;
        flowLayoutPanel_ForCards.Dock = DockStyle.Fill;
        flowLayoutPanel_ForCards.Location = new Point(0, 90);
        flowLayoutPanel_ForCards.Name = "flowLayoutPanel_ForCards";
        flowLayoutPanel_ForCards.Size = new Size(904, 371);
        flowLayoutPanel_ForCards.TabIndex = 0;
        // 
        // label_CompanyName
        // 
        label_CompanyName.AutoSize = true;
        label_CompanyName.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label_CompanyName.Location = new Point(97, 28);
        label_CompanyName.Name = "label_CompanyName";
        label_CompanyName.Size = new Size(182, 35);
        label_CompanyName.TabIndex = 1;
        label_CompanyName.Text = "ООО \"Название компании\"";
        // 
        // pictureBox_Logo
        // 
        pictureBox_Logo.BackgroundImage = (Image)resources.GetObject("pictureBox_Logo.BackgroundImage");
        pictureBox_Logo.BackgroundImageLayout = ImageLayout.Zoom;
        pictureBox_Logo.Dock = DockStyle.Left;
        pictureBox_Logo.Location = new Point(0, 0);
        pictureBox_Logo.Name = "pictureBox_Logo";
        pictureBox_Logo.Size = new Size(91, 86);
        pictureBox_Logo.TabIndex = 2;
        pictureBox_Logo.TabStop = false;
        // 
        // UpperPanel
        // 
        UpperPanel.BackColor = Color.FromArgb(187, 217, 178);
        UpperPanel.BorderStyle = BorderStyle.Fixed3D;
        UpperPanel.Controls.Add(label_CompanyName);
        UpperPanel.Controls.Add(pictureBox_Logo);
        UpperPanel.Dock = DockStyle.Top;
        UpperPanel.Location = new Point(0, 0);
        UpperPanel.Name = "UpperPanel";
        UpperPanel.Size = new Size(904, 90);
        UpperPanel.TabIndex = 3;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(904, 461);
        Controls.Add(flowLayoutPanel_ForCards);
        Controls.Add(UpperPanel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Главная страница";
        ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
        UpperPanel.ResumeLayout(false);
        UpperPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel_ForCards;
    private Label label_CompanyName;
    private PictureBox pictureBox_Logo;
    private Panel UpperPanel;
}
