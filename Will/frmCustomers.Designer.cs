namespace Will
{
    partial class frmCustomers
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CUSTORMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.willDataSet = new Will.willDataSet();
            this.rptCustomers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CUSTORMERTableAdapter = new Will.willDataSetTableAdapters.CUSTORMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CUSTORMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.willDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CUSTORMERBindingSource
            // 
            this.CUSTORMERBindingSource.DataMember = "CUSTORMER";
            this.CUSTORMERBindingSource.DataSource = this.willDataSet;
            // 
            // willDataSet
            // 
            this.willDataSet.DataSetName = "willDataSet";
            this.willDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptCustomers
            // 
            reportDataSource2.Name = "CUSTORMER_DATA";
            reportDataSource2.Value = this.CUSTORMERBindingSource;
            this.rptCustomers.LocalReport.DataSources.Add(reportDataSource2);
            this.rptCustomers.LocalReport.ReportEmbeddedResource = "Will.Custormer_rpt.rdlc";
            this.rptCustomers.Location = new System.Drawing.Point(1, 2);
            this.rptCustomers.Name = "rptCustomers";
            this.rptCustomers.Size = new System.Drawing.Size(631, 355);
            this.rptCustomers.TabIndex = 0;
            this.rptCustomers.Load += new System.EventHandler(this.rptCustomers_Load);
            // 
            // CUSTORMERTableAdapter
            // 
            this.CUSTORMERTableAdapter.ClearBeforeFill = true;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.Controls.Add(this.rptCustomers);
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CUSTORMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.willDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCustomers;
        private System.Windows.Forms.BindingSource CUSTORMERBindingSource;
        private willDataSet willDataSet;
        private willDataSetTableAdapters.CUSTORMERTableAdapter CUSTORMERTableAdapter;
    }
}

