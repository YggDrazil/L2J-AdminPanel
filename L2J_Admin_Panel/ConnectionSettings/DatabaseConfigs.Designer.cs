namespace L2J_Admin_Panel.SettingsForms
{
    partial class DatabaseConfigs
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
            this.login_server_host_name_textbox = new System.Windows.Forms.TextBox();
            this.login_server_dbname_textbox = new System.Windows.Forms.TextBox();
            this.login_server_username_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.login_server_password_textbox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.game_server_dbname_textbox = new System.Windows.Forms.TextBox();
            this.game_server_password_textbox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.game_server_username_textbox = new System.Windows.Forms.TextBox();
            this.game_server_host_name_textbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_server_host_name_textbox
            // 
            this.login_server_host_name_textbox.Location = new System.Drawing.Point(153, 68);
            this.login_server_host_name_textbox.Name = "login_server_host_name_textbox";
            this.login_server_host_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.login_server_host_name_textbox.TabIndex = 0;
            // 
            // login_server_dbname_textbox
            // 
            this.login_server_dbname_textbox.Location = new System.Drawing.Point(153, 146);
            this.login_server_dbname_textbox.Name = "login_server_dbname_textbox";
            this.login_server_dbname_textbox.Size = new System.Drawing.Size(100, 20);
            this.login_server_dbname_textbox.TabIndex = 1;
            // 
            // login_server_username_textbox
            // 
            this.login_server_username_textbox.Location = new System.Drawing.Point(153, 94);
            this.login_server_username_textbox.Name = "login_server_username_textbox";
            this.login_server_username_textbox.Size = new System.Drawing.Size(100, 20);
            this.login_server_username_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host Name / IP";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login Server DB Name";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(25, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(455, 220);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(64, 23);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(525, 220);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(58, 23);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // login_server_password_textbox
            // 
            this.login_server_password_textbox.Location = new System.Drawing.Point(153, 120);
            this.login_server_password_textbox.Name = "login_server_password_textbox";
            this.login_server_password_textbox.PasswordChar = '*';
            this.login_server_password_textbox.Size = new System.Drawing.Size(100, 20);
            this.login_server_password_textbox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Test Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Test Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(294, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Game Server DB Name";
            // 
            // game_server_dbname_textbox
            // 
            this.game_server_dbname_textbox.Location = new System.Drawing.Point(422, 149);
            this.game_server_dbname_textbox.Name = "game_server_dbname_textbox";
            this.game_server_dbname_textbox.Size = new System.Drawing.Size(100, 20);
            this.game_server_dbname_textbox.TabIndex = 25;
            // 
            // game_server_password_textbox
            // 
            this.game_server_password_textbox.Location = new System.Drawing.Point(422, 120);
            this.game_server_password_textbox.Name = "game_server_password_textbox";
            this.game_server_password_textbox.PasswordChar = '*';
            this.game_server_password_textbox.Size = new System.Drawing.Size(100, 20);
            this.game_server_password_textbox.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(294, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Username";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(294, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(294, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Host Name / IP";
            // 
            // game_server_username_textbox
            // 
            this.game_server_username_textbox.Location = new System.Drawing.Point(422, 94);
            this.game_server_username_textbox.Name = "game_server_username_textbox";
            this.game_server_username_textbox.Size = new System.Drawing.Size(100, 20);
            this.game_server_username_textbox.TabIndex = 17;
            // 
            // game_server_host_name_textbox
            // 
            this.game_server_host_name_textbox.Location = new System.Drawing.Point(422, 68);
            this.game_server_host_name_textbox.Name = "game_server_host_name_textbox";
            this.game_server_host_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.game_server_host_name_textbox.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.Location = new System.Drawing.Point(294, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(249, 29);
            this.label12.TabIndex = 29;
            this.label12.Text = "Game Server Settings";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.Location = new System.Drawing.Point(24, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 29);
            this.label11.TabIndex = 30;
            this.label11.Text = "Login Server Settings";
            // 
            // DatabaseConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 247);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.game_server_dbname_textbox);
            this.Controls.Add(this.game_server_password_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.game_server_username_textbox);
            this.Controls.Add(this.game_server_host_name_textbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_server_password_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_server_username_textbox);
            this.Controls.Add(this.login_server_dbname_textbox);
            this.Controls.Add(this.login_server_host_name_textbox);
            this.Name = "DatabaseConfigs";
            this.Text = "DatabaseConfigs";
            this.Load += new System.EventHandler(this.DatabaseConfigs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_server_host_name_textbox;
        private System.Windows.Forms.TextBox login_server_dbname_textbox;
        private System.Windows.Forms.TextBox login_server_username_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.MaskedTextBox login_server_password_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox game_server_dbname_textbox;
        private System.Windows.Forms.MaskedTextBox game_server_password_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox game_server_username_textbox;
        private System.Windows.Forms.TextBox game_server_host_name_textbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}