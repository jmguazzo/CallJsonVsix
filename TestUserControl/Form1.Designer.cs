namespace TestUserControl
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlCallJson1 = new CallJson.ControlCallJson();
            this.SuspendLayout();
            // 
            // controlCallJson1
            // 
            this.controlCallJson1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlCallJson1.Location = new System.Drawing.Point(0, 0);
            this.controlCallJson1.Name = "controlCallJson1";
            this.controlCallJson1.Size = new System.Drawing.Size(508, 402);
            this.controlCallJson1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 402);
            this.Controls.Add(this.controlCallJson1);
            this.Name = "Form1";
            this.Text = "Test usercontrol";
            this.ResumeLayout(false);

        }

        #endregion

        private CallJson.ControlCallJson controlCallJson1;
    }
}

