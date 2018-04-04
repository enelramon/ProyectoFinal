namespace Proyecto_Final.Reportes
{
    partial class TransportesReportForm
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
            this.TransportescrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TransportescrystalReportViewer
            // 
            this.TransportescrystalReportViewer.ActiveViewIndex = -1;
            this.TransportescrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransportescrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TransportescrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransportescrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TransportescrystalReportViewer.Name = "TransportescrystalReportViewer";
            this.TransportescrystalReportViewer.Size = new System.Drawing.Size(672, 396);
            this.TransportescrystalReportViewer.TabIndex = 0;
            this.TransportescrystalReportViewer.Load += new System.EventHandler(this.TransportescrystalReportViewer_Load);
            // 
            // TransportesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 396);
            this.Controls.Add(this.TransportescrystalReportViewer);
            this.Name = "TransportesReportForm";
            this.Text = "Reporte de transportes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TransportescrystalReportViewer;
    }
}