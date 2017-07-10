namespace Hangman
{
    partial class main_window
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
            this.animals_radio_button = new System.Windows.Forms.RadioButton();
            this.play_button = new System.Windows.Forms.Button();
            this.countries_radio_button = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // animals_radio_button
            // 
            this.animals_radio_button.AutoSize = true;
            this.animals_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.animals_radio_button.Location = new System.Drawing.Point(84, 63);
            this.animals_radio_button.Name = "animals_radio_button";
            this.animals_radio_button.Size = new System.Drawing.Size(145, 36);
            this.animals_radio_button.TabIndex = 0;
            this.animals_radio_button.TabStop = true;
            this.animals_radio_button.Text = "Animals ";
            this.animals_radio_button.UseVisualStyleBackColor = true;
            // 
            // play_button
            // 
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play_button.Location = new System.Drawing.Point(12, 369);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(474, 105);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "Play";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // countries_radio_button
            // 
            this.countries_radio_button.AutoSize = true;
            this.countries_radio_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.countries_radio_button.Location = new System.Drawing.Point(84, 130);
            this.countries_radio_button.Name = "countries_radio_button";
            this.countries_radio_button.Size = new System.Drawing.Size(158, 36);
            this.countries_radio_button.TabIndex = 2;
            this.countries_radio_button.TabStop = true;
            this.countries_radio_button.Text = "Countries";
            this.countries_radio_button.UseVisualStyleBackColor = true;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 486);
            this.Controls.Add(this.countries_radio_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.animals_radio_button);
            this.MaximumSize = new System.Drawing.Size(516, 533);
            this.MinimumSize = new System.Drawing.Size(516, 533);
            this.Name = "main_window";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton animals_radio_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.RadioButton countries_radio_button;
    }
}

