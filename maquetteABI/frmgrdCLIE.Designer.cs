namespace maquetteABI
{
    partial class frmgrdCLIE
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
            this.grdClient = new System.Windows.Forms.DataGridView();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnRechercherClient = new System.Windows.Forms.Button();
            this.lblRechercheClient = new System.Windows.Forms.Label();
            this.txtRechercherClient = new System.Windows.Forms.TextBox();
            this.btnFermergrdClient = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClient
            // 
            this.grdClient.AllowUserToAddRows = false;
            this.grdClient.AllowUserToDeleteRows = false;
            this.grdClient.BackgroundColor = System.Drawing.Color.Teal;
            this.grdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClient.Location = new System.Drawing.Point(12, 63);
            this.grdClient.Name = "grdClient";
            this.grdClient.ReadOnly = true;
            this.grdClient.Size = new System.Drawing.Size(544, 214);
            this.grdClient.TabIndex = 0;
            this.grdClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClient_CellClick_1);
            this.grdClient.DoubleClick += new System.EventHandler(this.grdClient_DoubleClick_1);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(12, 294);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(161, 23);
            this.btnAjouterClient.TabIndex = 1;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnRechercherClient
            // 
            this.btnRechercherClient.Location = new System.Drawing.Point(395, 21);
            this.btnRechercherClient.Name = "btnRechercherClient";
            this.btnRechercherClient.Size = new System.Drawing.Size(161, 23);
            this.btnRechercherClient.TabIndex = 3;
            this.btnRechercherClient.Text = "Rechercher";
            this.btnRechercherClient.UseVisualStyleBackColor = true;
            this.btnRechercherClient.Click += new System.EventHandler(this.btnRechercherClient_Click);
            // 
            // lblRechercheClient
            // 
            this.lblRechercheClient.AutoSize = true;
            this.lblRechercheClient.Location = new System.Drawing.Point(23, 31);
            this.lblRechercheClient.Name = "lblRechercheClient";
            this.lblRechercheClient.Size = new System.Drawing.Size(33, 13);
            this.lblRechercheClient.TabIndex = 4;
            this.lblRechercheClient.Text = "Client";
            // 
            // txtRechercherClient
            // 
            this.txtRechercherClient.Location = new System.Drawing.Point(73, 24);
            this.txtRechercherClient.Name = "txtRechercherClient";
            this.txtRechercherClient.Size = new System.Drawing.Size(286, 20);
            this.txtRechercherClient.TabIndex = 5;
            // 
            // btnFermergrdClient
            // 
            this.btnFermergrdClient.Location = new System.Drawing.Point(395, 294);
            this.btnFermergrdClient.Name = "btnFermergrdClient";
            this.btnFermergrdClient.Size = new System.Drawing.Size(161, 23);
            this.btnFermergrdClient.TabIndex = 6;
            this.btnFermergrdClient.Text = "Fermer";
            this.btnFermergrdClient.UseVisualStyleBackColor = true;
            this.btnFermergrdClient.Click += new System.EventHandler(this.btnFermergrdClient_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(193, 294);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(180, 23);
            this.btnSupprimer.TabIndex = 53;
            this.btnSupprimer.Text = "Supprimer ";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmgrdCLIE
            // 
            this.AcceptButton = this.btnRechercherClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 329);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnFermergrdClient);
            this.Controls.Add(this.txtRechercherClient);
            this.Controls.Add(this.lblRechercheClient);
            this.Controls.Add(this.btnRechercherClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.grdClient);
            this.Name = "frmgrdCLIE";
            ((System.ComponentModel.ISupportInitialize)(this.grdClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnRechercherClient;
        private System.Windows.Forms.Label lblRechercheClient;
        private System.Windows.Forms.TextBox txtRechercherClient;
        private System.Windows.Forms.Button btnFermergrdClient;
        private System.Windows.Forms.Button btnSupprimer;
    }
}