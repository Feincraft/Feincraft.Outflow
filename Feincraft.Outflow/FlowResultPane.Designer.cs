namespace Feincraft.Outflow
{
    partial class FlowResultPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowResultPane));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.btnLarger = new System.Windows.Forms.Button();
            this.btnSmaller = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.pnlLoading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(0, 195);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(490, 307);
            this.txtResult.TabIndex = 1;
            // 
            // pnlTools
            // 
            this.pnlTools.Controls.Add(this.btnLarger);
            this.pnlTools.Controls.Add(this.btnSmaller);
            this.pnlTools.Controls.Add(this.btnRefresh);
            this.pnlTools.Controls.Add(this.panel1);
            this.pnlTools.Controls.Add(this.panel2);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(490, 54);
            this.pnlTools.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(430, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 53);
            this.panel1.TabIndex = 4;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.txtEndPoint);
            this.pnlSettings.Controls.Add(this.panel4);
            this.pnlSettings.Controls.Add(this.lblEndpoint);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSettings.Location = new System.Drawing.Point(0, 54);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(490, 141);
            this.pnlSettings.TabIndex = 4;
            this.pnlSettings.Visible = false;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Feincraft.Outflow.Properties.Settings.Default, "FlowAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEndPoint.Location = new System.Drawing.Point(95, 39);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(381, 26);
            this.txtEndPoint.TabIndex = 2;
            this.txtEndPoint.Text = global::Feincraft.Outflow.Properties.Settings.Default.FlowAddress;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlLine1);
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(490, 44);
            this.panel4.TabIndex = 6;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLine1.Location = new System.Drawing.Point(0, 0);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(490, 1);
            this.pnlLine1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(97, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Location = new System.Drawing.Point(14, 42);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(73, 20);
            this.lblEndpoint.TabIndex = 1;
            this.lblEndpoint.Text = "Endpoint";
            // 
            // imgLoading
            // 
            this.imgLoading.BackColor = System.Drawing.Color.White;
            this.imgLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLoading.Image = global::Feincraft.Outflow.Properties.Resources.loading_waiting100;
            this.imgLoading.Location = new System.Drawing.Point(168, 103);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(154, 201);
            this.imgLoading.TabIndex = 6;
            this.imgLoading.TabStop = false;
            // 
            // btnLarger
            // 
            this.btnLarger.Image = ((System.Drawing.Image)(resources.GetObject("btnLarger.Image")));
            this.btnLarger.Location = new System.Drawing.Point(107, 3);
            this.btnLarger.Name = "btnLarger";
            this.btnLarger.Size = new System.Drawing.Size(46, 46);
            this.btnLarger.TabIndex = 7;
            this.btnLarger.UseVisualStyleBackColor = true;
            this.btnLarger.Click += new System.EventHandler(this.btnLarger_Click);
            // 
            // btnSmaller
            // 
            this.btnSmaller.Image = ((System.Drawing.Image)(resources.GetObject("btnSmaller.Image")));
            this.btnSmaller.Location = new System.Drawing.Point(55, 3);
            this.btnSmaller.Name = "btnSmaller";
            this.btnSmaller.Size = new System.Drawing.Size(46, 46);
            this.btnSmaller.TabIndex = 6;
            this.btnSmaller.UseVisualStyleBackColor = true;
            this.btnSmaller.Click += new System.EventHandler(this.btnSmaller_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 46);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 46);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.White;
            this.pnlLoading.Controls.Add(this.tableLayoutPanel1);
            this.pnlLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoading.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoading.Location = new System.Drawing.Point(0, 195);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(490, 307);
            this.pnlLoading.TabIndex = 7;
            this.pnlLoading.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imgLoading, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(490, 307);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 1);
            this.panel2.TabIndex = 8;
            // 
            // FlowResultPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlTools);
            this.Name = "FlowResultPane";
            this.Size = new System.Drawing.Size(490, 502);
            this.pnlTools.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.pnlLoading.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLarger;
        private System.Windows.Forms.Button btnSmaller;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}
