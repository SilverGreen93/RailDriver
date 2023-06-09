﻿namespace TrainSim_RailDriverdll_Sample
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGetLocoName = new System.Windows.Forms.Button();
            this.LblLocoName = new System.Windows.Forms.Label();
            this.BtnGetControllerList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblCurrent = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.TxtControlID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "SetRailDriverConnected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnGetLocoName
            // 
            this.BtnGetLocoName.Location = new System.Drawing.Point(16, 52);
            this.BtnGetLocoName.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetLocoName.Name = "BtnGetLocoName";
            this.BtnGetLocoName.Size = new System.Drawing.Size(201, 32);
            this.BtnGetLocoName.TabIndex = 45;
            this.BtnGetLocoName.Text = "Get Loco Name";
            this.BtnGetLocoName.UseVisualStyleBackColor = true;
            this.BtnGetLocoName.Click += new System.EventHandler(this.BtnGetLocoName_Click);
            // 
            // LblLocoName
            // 
            this.LblLocoName.Location = new System.Drawing.Point(225, 53);
            this.LblLocoName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLocoName.Name = "LblLocoName";
            this.LblLocoName.Size = new System.Drawing.Size(401, 44);
            this.LblLocoName.TabIndex = 46;
            this.LblLocoName.Text = "Loco name";
            // 
            // BtnGetControllerList
            // 
            this.BtnGetControllerList.Location = new System.Drawing.Point(16, 91);
            this.BtnGetControllerList.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGetControllerList.Name = "BtnGetControllerList";
            this.BtnGetControllerList.Size = new System.Drawing.Size(201, 28);
            this.BtnGetControllerList.TabIndex = 47;
            this.BtnGetControllerList.Text = "Get Controller List";
            this.BtnGetControllerList.UseVisualStyleBackColor = true;
            this.BtnGetControllerList.Click += new System.EventHandler(this.BtnGetControllerList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Gets the controller IDs and their min, max and current value";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(16, 123);
            this.LblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(20, 16);
            this.LblID.TabIndex = 51;
            this.LblID.Text = "ID";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(64, 123);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(75, 16);
            this.LblDescription.TabIndex = 52;
            this.LblDescription.Text = "Description";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Location = new System.Drawing.Point(327, 123);
            this.LblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(28, 16);
            this.LblMin.TabIndex = 53;
            this.LblMin.Text = "Min";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Location = new System.Drawing.Point(439, 123);
            this.LblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(32, 16);
            this.LblMax.TabIndex = 54;
            this.LblMax.Text = "Max";
            // 
            // LblCurrent
            // 
            this.LblCurrent.AutoSize = true;
            this.LblCurrent.Location = new System.Drawing.Point(545, 123);
            this.LblCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCurrent.Name = "LblCurrent";
            this.LblCurrent.Size = new System.Drawing.Size(49, 16);
            this.LblCurrent.TabIndex = 55;
            this.LblCurrent.Text = "Current";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(808, 49);
            this.TxtValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(61, 22);
            this.TxtValue.TabIndex = 58;
            this.TxtValue.Text = "1";
            // 
            // TxtControlID
            // 
            this.TxtControlID.Location = new System.Drawing.Point(740, 49);
            this.TxtControlID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtControlID.Name = "TxtControlID";
            this.TxtControlID.Size = new System.Drawing.Size(61, 22);
            this.TxtControlID.TabIndex = 57;
            this.TxtControlID.Text = "11";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(641, 46);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 31);
            this.button3.TabIndex = 56;
            this.button3.Text = "SetVal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(804, 31);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 289;
            this.label12.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(736, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 288;
            this.label11.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(877, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 290;
            this.label2.Text = "Sets the value and refresh list";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(635, 91);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(168, 28);
            this.BtnRefresh.TabIndex = 291;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1111, 881);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.TxtControlID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LblCurrent);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGetControllerList);
            this.Controls.Add(this.LblLocoName);
            this.Controls.Add(this.BtnGetLocoName);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Train Sim 2015 Raildriver.dll Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGetLocoName;
        private System.Windows.Forms.Label LblLocoName;
        private System.Windows.Forms.Button BtnGetControllerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Label LblCurrent;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.TextBox TxtControlID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

