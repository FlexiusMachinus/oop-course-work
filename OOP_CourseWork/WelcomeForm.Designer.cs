
namespace OOP_CourseWork
{
    partial class WelcomeForm
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
            this._pressButtonLabel = new System.Windows.Forms.Label();
            this._pictureBox = new System.Windows.Forms.PictureBox();
            this._exitTmer = new System.Windows.Forms.Timer(this.components);
            this._fadeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _pressButtonLabel
            // 
            this._pressButtonLabel.BackColor = System.Drawing.Color.White;
            this._pressButtonLabel.Font = new System.Drawing.Font("Roboto", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._pressButtonLabel.ForeColor = System.Drawing.Color.Gray;
            this._pressButtonLabel.Location = new System.Drawing.Point(0, 272);
            this._pressButtonLabel.Name = "_pressButtonLabel";
            this._pressButtonLabel.Size = new System.Drawing.Size(1080, 68);
            this._pressButtonLabel.TabIndex = 1;
            this._pressButtonLabel.Text = "Нажмите любую клавишу...";
            this._pressButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._pressButtonLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMouseClick);
            // 
            // _pictureBox
            // 
            this._pictureBox.Image = global::OOP_CourseWork.Properties.Resources.Заставка;
            this._pictureBox.Location = new System.Drawing.Point(0, 0);
            this._pictureBox.Name = "_pictureBox";
            this._pictureBox.Size = new System.Drawing.Size(1080, 340);
            this._pictureBox.TabIndex = 0;
            this._pictureBox.TabStop = false;
            this._pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMouseClick);
            // 
            // _exitTmer
            // 
            this._exitTmer.Enabled = true;
            this._exitTmer.Interval = 1000;
            this._exitTmer.Tick += new System.EventHandler(this.ExitTimerTick);
            // 
            // _fadeTimer
            // 
            this._fadeTimer.Interval = 10;
            this._fadeTimer.Tick += new System.EventHandler(this.FadeTimerTick);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 340);
            this.Controls.Add(this._pressButtonLabel);
            this.Controls.Add(this._pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветственное окно";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMouseClick);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _pictureBox;
        private System.Windows.Forms.Label _pressButtonLabel;
        private System.Windows.Forms.Timer _exitTmer;
        private System.Windows.Forms.Timer _fadeTimer;
    }
}