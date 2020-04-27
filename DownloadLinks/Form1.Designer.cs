namespace DownloadLinks
{
    partial class finestra
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.destinazione_text = new MetroFramework.Controls.MetroTextBox();
            this.destinazione_label = new MetroFramework.Controls.MetroLabel();
            this.download = new MetroFramework.Controls.MetroButton();
            this.errore = new System.Windows.Forms.RichTextBox();
            this.no_radio = new MetroFramework.Controls.MetroRadioButton();
            this.si_radio = new MetroFramework.Controls.MetroRadioButton();
            this.zeri_label = new MetroFramework.Controls.MetroLabel();
            this.compresi_label = new MetroFramework.Controls.MetroLabel();
            this.a_text = new MetroFramework.Controls.MetroTextBox();
            this.a_label = new MetroFramework.Controls.MetroLabel();
            this.da_text = new MetroFramework.Controls.MetroTextBox();
            this.da_label = new MetroFramework.Controls.MetroLabel();
            this.estensione_text = new MetroFramework.Controls.MetroTextBox();
            this.estensione_label = new MetroFramework.Controls.MetroLabel();
            this.radice_text = new MetroFramework.Controls.MetroTextBox();
            this.radice_label = new MetroFramework.Controls.MetroLabel();
            this.url_text = new MetroFramework.Controls.MetroTextBox();
            this.url_label = new MetroFramework.Controls.MetroLabel();
            this.progressione = new MetroFramework.Controls.MetroProgressBar();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.destinazione_text);
            this.metroPanel1.Controls.Add(this.destinazione_label);
            this.metroPanel1.Controls.Add(this.download);
            this.metroPanel1.Controls.Add(this.errore);
            this.metroPanel1.Controls.Add(this.no_radio);
            this.metroPanel1.Controls.Add(this.si_radio);
            this.metroPanel1.Controls.Add(this.zeri_label);
            this.metroPanel1.Controls.Add(this.compresi_label);
            this.metroPanel1.Controls.Add(this.a_text);
            this.metroPanel1.Controls.Add(this.a_label);
            this.metroPanel1.Controls.Add(this.da_text);
            this.metroPanel1.Controls.Add(this.da_label);
            this.metroPanel1.Controls.Add(this.estensione_text);
            this.metroPanel1.Controls.Add(this.estensione_label);
            this.metroPanel1.Controls.Add(this.radice_text);
            this.metroPanel1.Controls.Add(this.radice_label);
            this.metroPanel1.Controls.Add(this.url_text);
            this.metroPanel1.Controls.Add(this.url_label);
            this.metroPanel1.Controls.Add(this.progressione);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(721, 337);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // destinazione_text
            // 
            this.destinazione_text.Location = new System.Drawing.Point(90, 133);
            this.destinazione_text.Name = "destinazione_text";
            this.destinazione_text.Size = new System.Drawing.Size(300, 23);
            this.destinazione_text.TabIndex = 21;
            // 
            // destinazione_label
            // 
            this.destinazione_label.AutoSize = true;
            this.destinazione_label.Location = new System.Drawing.Point(3, 133);
            this.destinazione_label.Name = "destinazione_label";
            this.destinazione_label.Size = new System.Drawing.Size(81, 19);
            this.destinazione_label.TabIndex = 20;
            this.destinazione_label.Text = "destinazione";
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(547, 294);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(161, 34);
            this.download.TabIndex = 19;
            this.download.Text = "Inizia Download";
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // errore
            // 
            this.errore.Enabled = false;
            this.errore.Location = new System.Drawing.Point(3, 211);
            this.errore.Name = "errore";
            this.errore.ReadOnly = true;
            this.errore.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.errore.Size = new System.Drawing.Size(538, 117);
            this.errore.TabIndex = 18;
            this.errore.Text = "";
            // 
            // no_radio
            // 
            this.no_radio.AutoSize = true;
            this.no_radio.Location = new System.Drawing.Point(657, 83);
            this.no_radio.Name = "no_radio";
            this.no_radio.Size = new System.Drawing.Size(37, 15);
            this.no_radio.TabIndex = 17;
            this.no_radio.TabStop = true;
            this.no_radio.Text = "no";
            this.no_radio.UseVisualStyleBackColor = true;
            // 
            // si_radio
            // 
            this.si_radio.AutoSize = true;
            this.si_radio.Location = new System.Drawing.Point(620, 83);
            this.si_radio.Name = "si_radio";
            this.si_radio.Size = new System.Drawing.Size(31, 15);
            this.si_radio.TabIndex = 16;
            this.si_radio.TabStop = true;
            this.si_radio.Text = "si";
            this.si_radio.UseVisualStyleBackColor = true;
            // 
            // zeri_label
            // 
            this.zeri_label.AutoSize = true;
            this.zeri_label.Location = new System.Drawing.Point(470, 79);
            this.zeri_label.Name = "zeri_label";
            this.zeri_label.Size = new System.Drawing.Size(141, 19);
            this.zeri_label.TabIndex = 15;
            this.zeri_label.Text = "riempimento con zeri?";
            // 
            // compresi_label
            // 
            this.compresi_label.AutoSize = true;
            this.compresi_label.Location = new System.Drawing.Point(275, 79);
            this.compresi_label.Name = "compresi_label";
            this.compresi_label.Size = new System.Drawing.Size(82, 19);
            this.compresi_label.TabIndex = 14;
            this.compresi_label.Text = "( Compresi )";
            // 
            // a_text
            // 
            this.a_text.Location = new System.Drawing.Point(169, 75);
            this.a_text.Name = "a_text";
            this.a_text.Size = new System.Drawing.Size(100, 23);
            this.a_text.TabIndex = 13;
            this.a_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Location = new System.Drawing.Point(147, 79);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(16, 19);
            this.a_label.TabIndex = 11;
            this.a_label.Text = "a";
            // 
            // da_text
            // 
            this.da_text.Location = new System.Drawing.Point(41, 75);
            this.da_text.Name = "da_text";
            this.da_text.Size = new System.Drawing.Size(100, 23);
            this.da_text.TabIndex = 10;
            this.da_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // da_label
            // 
            this.da_label.AutoSize = true;
            this.da_label.Location = new System.Drawing.Point(3, 79);
            this.da_label.Name = "da_label";
            this.da_label.Size = new System.Drawing.Size(24, 19);
            this.da_label.TabIndex = 9;
            this.da_label.Text = "da";
            // 
            // estensione_text
            // 
            this.estensione_text.Location = new System.Drawing.Point(600, 20);
            this.estensione_text.Name = "estensione_text";
            this.estensione_text.Size = new System.Drawing.Size(94, 23);
            this.estensione_text.TabIndex = 8;
            // 
            // estensione_label
            // 
            this.estensione_label.AutoSize = true;
            this.estensione_label.Location = new System.Drawing.Point(525, 24);
            this.estensione_label.Name = "estensione_label";
            this.estensione_label.Size = new System.Drawing.Size(69, 19);
            this.estensione_label.TabIndex = 7;
            this.estensione_label.Text = "estensione";
            // 
            // radice_text
            // 
            this.radice_text.Location = new System.Drawing.Point(398, 20);
            this.radice_text.Name = "radice_text";
            this.radice_text.Size = new System.Drawing.Size(121, 23);
            this.radice_text.TabIndex = 6;
            // 
            // radice_label
            // 
            this.radice_label.AutoSize = true;
            this.radice_label.Location = new System.Drawing.Point(347, 24);
            this.radice_label.Name = "radice_label";
            this.radice_label.Size = new System.Drawing.Size(45, 19);
            this.radice_label.TabIndex = 5;
            this.radice_label.Text = "radice";
            // 
            // url_text
            // 
            this.url_text.Location = new System.Drawing.Point(41, 20);
            this.url_text.Name = "url_text";
            this.url_text.Size = new System.Drawing.Size(300, 23);
            this.url_text.TabIndex = 4;
            // 
            // url_label
            // 
            this.url_label.AutoSize = true;
            this.url_label.Location = new System.Drawing.Point(3, 24);
            this.url_label.Name = "url_label";
            this.url_label.Size = new System.Drawing.Size(24, 19);
            this.url_label.TabIndex = 3;
            this.url_label.Text = "url";
            // 
            // progressione
            // 
            this.progressione.Location = new System.Drawing.Point(3, 182);
            this.progressione.Name = "progressione";
            this.progressione.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressione.Size = new System.Drawing.Size(705, 23);
            this.progressione.TabIndex = 2;
            // 
            // finestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 419);
            this.Controls.Add(this.metroPanel1);
            this.Name = "finestra";
            this.Resizable = false;
            this.Text = "DownloadLinks";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel url_label;
        private MetroFramework.Controls.MetroProgressBar progressione;
        private MetroFramework.Controls.MetroTextBox url_text;
        private MetroFramework.Controls.MetroLabel radice_label;
        private MetroFramework.Controls.MetroLabel a_label;
        private MetroFramework.Controls.MetroTextBox da_text;
        private MetroFramework.Controls.MetroLabel da_label;
        private MetroFramework.Controls.MetroTextBox estensione_text;
        private MetroFramework.Controls.MetroLabel estensione_label;
        private MetroFramework.Controls.MetroTextBox radice_text;
        private MetroFramework.Controls.MetroButton download;
        private System.Windows.Forms.RichTextBox errore;
        private MetroFramework.Controls.MetroRadioButton no_radio;
        private MetroFramework.Controls.MetroRadioButton si_radio;
        private MetroFramework.Controls.MetroLabel zeri_label;
        private MetroFramework.Controls.MetroLabel compresi_label;
        private MetroFramework.Controls.MetroTextBox a_text;
        private MetroFramework.Controls.MetroTextBox destinazione_text;
        private MetroFramework.Controls.MetroLabel destinazione_label;
    }
}

