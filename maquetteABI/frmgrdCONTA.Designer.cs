namespace maquetteABI
{
    partial class frmgrdCONTA
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
            this.grdContact = new System.Windows.Forms.DataGridView();
            this.txtRechercherContact = new System.Windows.Forms.TextBox();
            this.lblRechercheContact = new System.Windows.Forms.Label();
            this.btnRechercherContact = new System.Windows.Forms.Button();
            this.btnAjouterContact = new System.Windows.Forms.Button();
            this.btnFermergrdContact = new System.Windows.Forms.Button();
            this.btnSupprimerContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContact
            // 
            this.grdContact.BackgroundColor = System.Drawing.Color.LightBlue;
            this.grdContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContact.Location = new System.Drawing.Point(12, 60);
            this.grdContact.Name = "grdContact";
            this.grdContact.Size = new System.Drawing.Size(434, 161);
            this.grdContact.TabIndex = 0;
            this.grdContact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContact_CellClick);
            this.grdContact.DoubleClick += new System.EventHandler(this.grdContact_DoubleClick);
            // 
            // txtRechercherContact
            // 
            this.txtRechercherContact.Location = new System.Drawing.Point(81, 24);
            this.txtRechercherContact.Name = "txtRechercherContact";
            this.txtRechercherContact.Size = new System.Drawing.Size(176, 20);
            this.txtRechercherContact.TabIndex = 8;
            // 
            // lblRechercheContact
            // 
            this.lblRechercheContact.AutoSize = true;
            this.lblRechercheContact.Location = new System.Drawing.Point(12, 31);
            this.lblRechercheContact.Name = "lblRechercheContact";
            this.lblRechercheContact.Size = new System.Drawing.Size(44, 13);
            this.lblRechercheContact.TabIndex = 7;
            this.lblRechercheContact.Text = "Contact";
            // 
            // btnRechercherContact
            // 
            this.btnRechercherContact.Location = new System.Drawing.Point(285, 21);
            this.btnRechercherContact.Name = "btnRechercherContact";
            this.btnRechercherContact.Size = new System.Drawing.Size(161, 23);
            this.btnRechercherContact.TabIndex = 6;
            this.btnRechercherContact.Text = "Rechercher";
            this.btnRechercherContact.UseVisualStyleBackColor = true;
            this.btnRechercherContact.Click += new System.EventHandler(this.btnRechercherContact_Click);
            // 
            // btnAjouterContact
            // 
            this.btnAjouterContact.Location = new System.Drawing.Point(12, 236);
            this.btnAjouterContact.Name = "btnAjouterContact";
            this.btnAjouterContact.Size = new System.Drawing.Size(122, 23);
            this.btnAjouterContact.TabIndex = 9;
            this.btnAjouterContact.Text = "Ajouter";
            this.btnAjouterContact.UseVisualStyleBackColor = true;
            this.btnAjouterContact.Click += new System.EventHandler(this.btnAjouterContact_Click);
            // 
            // btnFermergrdContact
            // 
            this.btnFermergrdContact.Location = new System.Drawing.Point(323, 236);
            this.btnFermergrdContact.Name = "btnFermergrdContact";
            this.btnFermergrdContact.Size = new System.Drawing.Size(123, 23);
            this.btnFermergrdContact.TabIndex = 11;
            this.btnFermergrdContact.Text = "Fermer";
            this.btnFermergrdContact.UseVisualStyleBackColor = true;
            this.btnFermergrdContact.Click += new System.EventHandler(this.btnFermergrdContact_Click);
            // 
            // btnSupprimerContact
            // 
            this.btnSupprimerContact.Location = new System.Drawing.Point(172, 236);
            this.btnSupprimerContact.Name = "btnSupprimerContact";
            this.btnSupprimerContact.Size = new System.Drawing.Size(118, 23);
            this.btnSupprimerContact.TabIndex = 12;
            this.btnSupprimerContact.Text = "Supprimer ";
            this.btnSupprimerContact.UseVisualStyleBackColor = true;
            this.btnSupprimerContact.Click += new System.EventHandler(this.btnSupprimerContact_Click);
            // 
            // frmgrdCONTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 271);
            this.Controls.Add(this.btnSupprimerContact);
            this.Controls.Add(this.btnFermergrdContact);
            this.Controls.Add(this.btnAjouterContact);
            this.Controls.Add(this.txtRechercherContact);
            this.Controls.Add(this.lblRechercheContact);
            this.Controls.Add(this.btnRechercherContact);
            this.Controls.Add(this.grdContact);
            this.Name = "frmgrdCONTA";
            this.Text = "frmgrdCONTA";
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContact;
        private System.Windows.Forms.TextBox txtRechercherContact;
        private System.Windows.Forms.Label lblRechercheContact;
        private System.Windows.Forms.Button btnRechercherContact;
        private System.Windows.Forms.Button btnAjouterContact;
        private System.Windows.Forms.Button btnFermergrdContact;
        private System.Windows.Forms.Button btnSupprimerContact;
    }
}