﻿namespace MyAlbumEditor
{
    partial class EditorForm
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
            this.grpAlbum = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbAlbums = new System.Windows.Forms.ComboBox();
            this.btnAlbumProps = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pageDates = new System.Windows.Forms.TabPage();
            this.albCalendar = new MyAlbumEditor.albumCalendar();
            this.pagePhotos = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnPhotoProps = new System.Windows.Forms.Button();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.tcPhotos = new System.Windows.Forms.TabControl();
            this.pageImages = new System.Windows.Forms.TabPage();
            this.albumImages = new MyAlbumEditor.Albumimage();
            this.grpAlbum.SuspendLayout();
            this.pageDates.SuspendLayout();
            this.pagePhotos.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.pageImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlbum
            // 
            this.grpAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAlbum.Controls.Add(this.btnBrowse);
            this.grpAlbum.Controls.Add(this.cmbAlbums);
            this.grpAlbum.Controls.Add(this.btnAlbumProps);
            this.grpAlbum.Location = new System.Drawing.Point(9, 11);
            this.grpAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.grpAlbum.Name = "grpAlbum";
            this.grpAlbum.Padding = new System.Windows.Forms.Padding(2);
            this.grpAlbum.Size = new System.Drawing.Size(334, 64);
            this.grpAlbum.TabIndex = 0;
            this.grpAlbum.TabStop = false;
            this.grpAlbum.Text = "&Album";
            this.grpAlbum.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(120, 17);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(127, 30);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbAlbums
            // 
            this.cmbAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbums.DropDownWidth = 400;
            this.cmbAlbums.FormattingEnabled = true;
            this.cmbAlbums.Location = new System.Drawing.Point(4, 23);
            this.cmbAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlbums.Name = "cmbAlbums";
            this.cmbAlbums.Size = new System.Drawing.Size(112, 21);
            this.cmbAlbums.TabIndex = 2;
            this.cmbAlbums.SelectionChangeCommitted += new System.EventHandler(this.cmbAlbums_SelectionChangeCommitted);
            // 
            // btnAlbumProps
            // 
            this.btnAlbumProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlbumProps.Location = new System.Drawing.Point(251, 16);
            this.btnAlbumProps.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlbumProps.Name = "btnAlbumProps";
            this.btnAlbumProps.Size = new System.Drawing.Size(82, 31);
            this.btnAlbumProps.TabIndex = 1;
            this.btnAlbumProps.Text = "Propertie&s";
            this.btnAlbumProps.UseVisualStyleBackColor = true;
            this.btnAlbumProps.Click += new System.EventHandler(this.btnAlbumProps_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(143, 236);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pageDates
            // 
            this.pageDates.Controls.Add(this.albCalendar);
            this.pageDates.Location = new System.Drawing.Point(4, 25);
            this.pageDates.Name = "pageDates";
            this.pageDates.Padding = new System.Windows.Forms.Padding(3);
            this.pageDates.Size = new System.Drawing.Size(321, 121);
            this.pageDates.TabIndex = 1;
            this.pageDates.Text = "Dates";
            this.pageDates.UseVisualStyleBackColor = true;
            // 
            // albCalendar
            // 
            this.albCalendar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.albCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albCalendar.Location = new System.Drawing.Point(3, 3);
            this.albCalendar.Manager = null;
            this.albCalendar.Name = "albCalendar";
            this.albCalendar.Size = new System.Drawing.Size(315, 115);
            this.albCalendar.TabIndex = 0;
            // 
            // pagePhotos
            // 
            this.pagePhotos.Controls.Add(this.btnRemove);
            this.pagePhotos.Controls.Add(this.btnMoveDown);
            this.pagePhotos.Controls.Add(this.btnMoveUp);
            this.pagePhotos.Controls.Add(this.btnPhotoProps);
            this.pagePhotos.Controls.Add(this.lstPhotos);
            this.pagePhotos.Location = new System.Drawing.Point(4, 25);
            this.pagePhotos.Name = "pagePhotos";
            this.pagePhotos.Padding = new System.Windows.Forms.Padding(3);
            this.pagePhotos.Size = new System.Drawing.Size(321, 121);
            this.pagePhotos.TabIndex = 0;
            this.pagePhotos.Text = "Photos";
            this.pagePhotos.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(248, 62);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 30);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Location = new System.Drawing.Point(248, 29);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(70, 28);
            this.btnMoveDown.TabIndex = 14;
            this.btnMoveDown.Text = "Move&Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Location = new System.Drawing.Point(248, 0);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(70, 24);
            this.btnMoveUp.TabIndex = 13;
            this.btnMoveUp.Text = "Move&Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnPhotoProps
            // 
            this.btnPhotoProps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhotoProps.Location = new System.Drawing.Point(248, 97);
            this.btnPhotoProps.Margin = new System.Windows.Forms.Padding(2);
            this.btnPhotoProps.Name = "btnPhotoProps";
            this.btnPhotoProps.Size = new System.Drawing.Size(70, 24);
            this.btnPhotoProps.TabIndex = 12;
            this.btnPhotoProps.Text = "properti&es";
            this.btnPhotoProps.UseVisualStyleBackColor = true;
            this.btnPhotoProps.Click += new System.EventHandler(this.btnPhotoProps_Click);
            // 
            // lstPhotos
            // 
            this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPhotos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.HorizontalScrollbar = true;
            this.lstPhotos.Location = new System.Drawing.Point(2, 5);
            this.lstPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(242, 121);
            this.lstPhotos.TabIndex = 11;
            this.lstPhotos.Click += new System.EventHandler(this.lstPhotos_DoubleClick);
            this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPhotos_DrawItem);
            this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPhotos_MeasureItem);
            this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
            // 
            // tcPhotos
            // 
            this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPhotos.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcPhotos.Controls.Add(this.pagePhotos);
            this.tcPhotos.Controls.Add(this.pageDates);
            this.tcPhotos.Controls.Add(this.pageImages);
            this.tcPhotos.Location = new System.Drawing.Point(13, 81);
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(329, 150);
            this.tcPhotos.TabIndex = 3;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
            // 
            // pageImages
            // 
            this.pageImages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageImages.Controls.Add(this.albumImages);
            this.pageImages.Location = new System.Drawing.Point(4, 25);
            this.pageImages.Name = "pageImages";
            this.pageImages.Padding = new System.Windows.Forms.Padding(3);
            this.pageImages.Size = new System.Drawing.Size(321, 121);
            this.pageImages.TabIndex = 2;
            this.pageImages.Text = "Images";
            this.pageImages.UseVisualStyleBackColor = true;
            // 
            // albumImages
            // 
            this.albumImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.albumImages.Location = new System.Drawing.Point(3, 3);
            this.albumImages.Manager = null;
            this.albumImages.Name = "albumImages";
            this.albumImages.Padding = new System.Windows.Forms.Padding(5);
            this.albumImages.Size = new System.Drawing.Size(311, 111);
            this.albumImages.TabIndex = 0;
            // 
            // EditorForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.tcPhotos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpAlbum);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditorForm";
            this.Text = "MyAbumEditor";
            this.grpAlbum.ResumeLayout(false);
            this.pageDates.ResumeLayout(false);
            this.pagePhotos.ResumeLayout(false);
            this.tcPhotos.ResumeLayout(false);
            this.pageImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlbum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAlbumProps;
        private System.Windows.Forms.ComboBox cmbAlbums;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TabPage pageDates;
        private albumCalendar albCalendar;
        private System.Windows.Forms.TabPage pagePhotos;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnPhotoProps;
        private System.Windows.Forms.ListBox lstPhotos;
        private System.Windows.Forms.TabControl tcPhotos;
        private System.Windows.Forms.TabPage pageImages;
        private Albumimage albumImages;
    }
}

