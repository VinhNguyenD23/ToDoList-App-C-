
namespace TodoApp
{
    partial class RemoveForm
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
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Data_View = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.Note_Txt = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Time_End_CB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Time_Begin_CB = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Priority_CB = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Title_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Cancelled_Btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Priority_CB)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 21);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            this.kryptonGroupBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonPanel1);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(1000, 311);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox2.TabIndex = 4;
            this.kryptonGroupBox2.Values.Heading = "Bảng dữ liệu";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.Controls.Add(this.Data_View);
            this.kryptonPanel1.Location = new System.Drawing.Point(4, 4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            this.kryptonPanel1.Size = new System.Drawing.Size(994, 280);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Data_View
            // 
            this.Data_View.AllowUserToAddRows = false;
            this.Data_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_View.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.Data_View.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.Data_View.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.Data_View.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.Data_View.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.Data_View.Location = new System.Drawing.Point(4, 4);
            this.Data_View.Name = "Data_View";
            this.Data_View.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Data_View.RowHeadersVisible = false;
            this.Data_View.Size = new System.Drawing.Size(985, 273);
            this.Data_View.TabIndex = 0;
            this.Data_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_View_CellClick);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 338);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.Note_Txt);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Time_End_CB);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Time_Begin_CB);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Priority_CB);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Title_txt);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.Cancelled_Btn);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1000, 150);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.TabIndex = 5;
            this.kryptonGroupBox1.Values.Heading = "Xem dữ liệu";
            // 
            // Note_Txt
            // 
            this.Note_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note_Txt.Enabled = false;
            this.Note_Txt.Location = new System.Drawing.Point(638, 8);
            this.Note_Txt.Name = "Note_Txt";
            this.Note_Txt.Size = new System.Drawing.Size(352, 84);
            this.Note_Txt.TabIndex = 25;
            this.Note_Txt.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(580, 8);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel5.TabIndex = 24;
            this.kryptonLabel5.Values.Text = "Ghi chú";
            // 
            // Time_End_CB
            // 
            this.Time_End_CB.Enabled = false;
            this.Time_End_CB.Location = new System.Drawing.Point(410, 69);
            this.Time_End_CB.Name = "Time_End_CB";
            this.Time_End_CB.Size = new System.Drawing.Size(164, 23);
            this.Time_End_CB.TabIndex = 23;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(283, 72);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(129, 20);
            this.kryptonLabel1.TabIndex = 22;
            this.kryptonLabel1.Values.Text = "Thời gian Hoàn thành";
            // 
            // Time_Begin_CB
            // 
            this.Time_Begin_CB.CalendarTodayDate = new System.DateTime(2023, 10, 8, 0, 0, 0, 0);
            this.Time_Begin_CB.Enabled = false;
            this.Time_Begin_CB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Time_Begin_CB.Location = new System.Drawing.Point(113, 71);
            this.Time_Begin_CB.Name = "Time_Begin_CB";
            this.Time_Begin_CB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Time_Begin_CB.Size = new System.Drawing.Size(164, 21);
            this.Time_Begin_CB.TabIndex = 21;
            // 
            // Priority_CB
            // 
            this.Priority_CB.AllowDrop = true;
            this.Priority_CB.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Priority_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority_CB.DropDownWidth = 164;
            this.Priority_CB.Enabled = false;
            this.Priority_CB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Priority_CB.Location = new System.Drawing.Point(410, 7);
            this.Priority_CB.Name = "Priority_CB";
            this.Priority_CB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Priority_CB.Size = new System.Drawing.Size(164, 21);
            this.Priority_CB.TabIndex = 20;
            // 
            // Title_txt
            // 
            this.Title_txt.Enabled = false;
            this.Title_txt.Location = new System.Drawing.Point(113, 5);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(164, 23);
            this.Title_txt.TabIndex = 19;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(4, 72);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Thời gian lên lịch";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(283, 8);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Mức ưu tiên";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 5);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Tiêu đề";
            // 
            // Cancelled_Btn
            // 
            this.Cancelled_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelled_Btn.Location = new System.Drawing.Point(900, 98);
            this.Cancelled_Btn.Name = "Cancelled_Btn";
            this.Cancelled_Btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Cancelled_Btn.Size = new System.Drawing.Size(90, 25);
            this.Cancelled_Btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Cancelled_Btn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cancelled_Btn.TabIndex = 4;
            this.Cancelled_Btn.Values.Text = "Xóa Task";
            this.Cancelled_Btn.Click += new System.EventHandler(this.Cancelled_Btn_Click);
            // 
            // RemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 509);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemoveForm";
            this.Text = "RemoveForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Priority_CB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView Data_View;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox Note_Txt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Time_End_CB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Time_Begin_CB;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Priority_CB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Title_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Cancelled_Btn;
    }
}