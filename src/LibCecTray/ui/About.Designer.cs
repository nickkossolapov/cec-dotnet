﻿namespace LibCECTray.ui
{
  partial class About
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
      this.label1 = new System.Windows.Forms.Label();
      this.lVersionInfo = new System.Windows.Forms.Label();
      this.lBuildInfo = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(366, 260);
      this.label1.TabIndex = 0;
      this.label1.Text = resources.GetString("label1.Text");
      // 
      // lVersionInfo
      // 
      this.lVersionInfo.AutoSize = true;
      this.lVersionInfo.Location = new System.Drawing.Point(12, 9);
      this.lVersionInfo.Name = "lVersionInfo";
      this.lVersionInfo.Size = new System.Drawing.Size(101, 13);
      this.lVersionInfo.TabIndex = 1;
      this.lVersionInfo.Text = "[libCEC version info]";
      // 
      // lBuildInfo
      // 
      this.lBuildInfo.AutoSize = true;
      this.lBuildInfo.Location = new System.Drawing.Point(12, 305);
      this.lBuildInfo.Name = "lBuildInfo";
      this.lBuildInfo.Size = new System.Drawing.Size(89, 13);
      this.lBuildInfo.TabIndex = 2;
      this.lBuildInfo.Text = "[libCEC build info]";
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(482, 327);
      this.Controls.Add(this.lBuildInfo);
      this.Controls.Add(this.lVersionInfo);
      this.Controls.Add(this.label1);
      this.Name = "About";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lVersionInfo;
    private System.Windows.Forms.Label lBuildInfo;
  }
}