
namespace E_shift_Management_System
{
    partial class Operation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operation));
            this.dgvOperation = new System.Windows.Forms.DataGridView();
            this.jobID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._E_shift_Management_SystemDataSet1 = new E_shift_Management_System._E_shift_Management_SystemDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCusID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtEnd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtStartlocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dtpOrderdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpShipdate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.operationsTableAdapter = new E_shift_Management_System._E_shift_Management_SystemDataSet1TableAdapters.OperationsTableAdapter();
            this.btnSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnReport = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnrefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_shift_Management_SystemDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperation
            // 
            this.dgvOperation.AllowUserToAddRows = false;
            this.dgvOperation.AllowUserToDeleteRows = false;
            this.dgvOperation.AutoGenerateColumns = false;
            this.dgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobID,
            this.uniqueID,
            this.orderDate,
            this.shipdate,
            this.startLocation,
            this.requestedLocation});
            this.dgvOperation.DataSource = this.operationsBindingSource;
            this.dgvOperation.Location = new System.Drawing.Point(12, 128);
            this.dgvOperation.Name = "dgvOperation";
            this.dgvOperation.RowHeadersWidth = 51;
            this.dgvOperation.RowTemplate.Height = 24;
            this.dgvOperation.Size = new System.Drawing.Size(960, 276);
            this.dgvOperation.TabIndex = 0;
            this.dgvOperation.SelectionChanged += new System.EventHandler(this.dgvOperation_SelectionChanged);
            // 
            // jobID
            // 
            this.jobID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jobID.DataPropertyName = "jobID";
            this.jobID.HeaderText = "jobID";
            this.jobID.MinimumWidth = 6;
            this.jobID.Name = "jobID";
            this.jobID.Width = 69;
            // 
            // uniqueID
            // 
            this.uniqueID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uniqueID.DataPropertyName = "uniqueID";
            this.uniqueID.HeaderText = "uniqueID";
            this.uniqueID.MinimumWidth = 6;
            this.uniqueID.Name = "uniqueID";
            this.uniqueID.Width = 93;
            // 
            // orderDate
            // 
            this.orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderDate.DataPropertyName = "orderDate";
            this.orderDate.HeaderText = "orderDate";
            this.orderDate.MinimumWidth = 6;
            this.orderDate.Name = "orderDate";
            this.orderDate.Width = 101;
            // 
            // shipdate
            // 
            this.shipdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shipdate.DataPropertyName = "shipdate";
            this.shipdate.HeaderText = "shipdate";
            this.shipdate.MinimumWidth = 6;
            this.shipdate.Name = "shipdate";
            this.shipdate.Width = 91;
            // 
            // startLocation
            // 
            this.startLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startLocation.DataPropertyName = "startLocation";
            this.startLocation.HeaderText = "startLocation";
            this.startLocation.MinimumWidth = 6;
            this.startLocation.Name = "startLocation";
            // 
            // requestedLocation
            // 
            this.requestedLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.requestedLocation.DataPropertyName = "requestedLocation";
            this.requestedLocation.HeaderText = "requestedLocation";
            this.requestedLocation.MinimumWidth = 6;
            this.requestedLocation.Name = "requestedLocation";
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this._E_shift_Management_SystemDataSet1;
            // 
            // _E_shift_Management_SystemDataSet1
            // 
            this._E_shift_Management_SystemDataSet1.DataSetName = "_E_shift_Management_SystemDataSet1";
            this._E_shift_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(54, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(510, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(510, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ship Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(53, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Location :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(510, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Location";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(187, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(284, 33);
            this.txtId.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtId.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtId.StateCommon.Border.Rounding = 10;
            this.txtId.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.TabIndex = 7;
            // 
            // txtCusID
            // 
            this.txtCusID.Location = new System.Drawing.Point(187, 89);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(284, 33);
            this.txtCusID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCusID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtCusID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCusID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCusID.StateCommon.Border.Rounding = 10;
            this.txtCusID.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.TabIndex = 8;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(640, 147);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(288, 37);
            this.txtEnd.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEnd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtEnd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEnd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtEnd.StateCommon.Border.Rounding = 15;
            this.txtEnd.StateCommon.Border.Width = 1;
            this.txtEnd.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.TabIndex = 10;
            // 
            // txtStartlocation
            // 
            this.txtStartlocation.Location = new System.Drawing.Point(183, 147);
            this.txtStartlocation.Name = "txtStartlocation";
            this.txtStartlocation.Size = new System.Drawing.Size(288, 37);
            this.txtStartlocation.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtStartlocation.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtStartlocation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtStartlocation.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtStartlocation.StateCommon.Border.Rounding = 15;
            this.txtStartlocation.StateCommon.Border.Width = 1;
            this.txtStartlocation.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartlocation.TabIndex = 11;
            // 
            // dtpOrderdate
            // 
            this.dtpOrderdate.Location = new System.Drawing.Point(644, 29);
            this.dtpOrderdate.Name = "dtpOrderdate";
            this.dtpOrderdate.Size = new System.Drawing.Size(284, 35);
            this.dtpOrderdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpOrderdate.StateCommon.Border.Rounding = 15;
            this.dtpOrderdate.StateCommon.Border.Width = 1;
            this.dtpOrderdate.TabIndex = 12;
            // 
            // dtpShipdate
            // 
            this.dtpShipdate.Location = new System.Drawing.Point(644, 89);
            this.dtpShipdate.Name = "dtpShipdate";
            this.dtpShipdate.Size = new System.Drawing.Size(284, 35);
            this.dtpShipdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpShipdate.StateCommon.Border.Rounding = 15;
            this.dtpShipdate.StateCommon.Border.Width = 1;
            this.dtpShipdate.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(672, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 44);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.Rounding = 15;
            this.btnDelete.StateCommon.Border.Width = 1;
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Values.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(514, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 44);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.Rounding = 15;
            this.btnUpdate.StateCommon.Border.Width = 1;
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Values.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(351, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 44);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 15;
            this.btnSave.StateCommon.Border.Width = 1;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 17;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCusID);
            this.panel1.Controls.Add(this.dtpOrderdate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpShipdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.txtStartlocation);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 296);
            this.panel1.TabIndex = 20;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(187, 219);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 44);
            this.btnNew.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNew.StateCommon.Back.Color2 = System.Drawing.Color.Fuchsia;
            this.btnNew.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.btnNew.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNew.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnNew.StateCommon.Border.Rounding = 15;
            this.btnNew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNew.TabIndex = 20;
            this.btnNew.Values.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 36);
            this.btnSearch.StateCommon.Back.Color1 = System.Drawing.Color.RoyalBlue;
            this.btnSearch.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnSearch.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSearch.StateCommon.Border.Rounding = 10;
            this.btnSearch.StateCommon.Border.Width = 1;
            this.btnSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Values.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(137, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 36);
            this.txtSearch.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(851, 69);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(123, 36);
            this.btnReport.StateCommon.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btnReport.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnReport.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnReport.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReport.StateCommon.Border.Rounding = 10;
            this.btnReport.StateCommon.Border.Width = 1;
            this.btnReport.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReport.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.TabIndex = 24;
            this.btnReport.Values.Text = "Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(12, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 17);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total records";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(722, 69);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(123, 36);
            this.btnrefresh.StateCommon.Back.Color1 = System.Drawing.Color.Blue;
            this.btnrefresh.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnrefresh.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnrefresh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnrefresh.StateCommon.Border.Rounding = 10;
            this.btnrefresh.StateCommon.Border.Width = 1;
            this.btnrefresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnrefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.TabIndex = 26;
            this.btnrefresh.Values.Text = "Refresh";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOrderDetails.Image = ((System.Drawing.Image)(resources.GetObject("lblOrderDetails.Image")));
            this.lblOrderDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrderDetails.Location = new System.Drawing.Point(756, 24);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(216, 25);
            this.lblOrderDetails.TabIndex = 27;
            this.lblOrderDetails.Text = "Futher Order Details     ";
            this.lblOrderDetails.Click += new System.EventHandler(this.lblOrderDetails_Click);
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(984, 718);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Operation";
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.Operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_shift_Management_SystemDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtId;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCusID;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEnd;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtStartlocation;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpOrderdate;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpShipdate;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private _E_shift_Management_SystemDataSet1 _E_shift_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private _E_shift_Management_SystemDataSet1TableAdapters.OperationsTableAdapter operationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnNew;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSearch;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnReport;
        private System.Windows.Forms.Label lblTotal;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnrefresh;
        private System.Windows.Forms.Label lblOrderDetails;
    }
}