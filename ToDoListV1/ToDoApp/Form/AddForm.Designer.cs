
namespace TodoApp
{
    partial class AddForm
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
            this.Time_Begin_CB = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Priority_CB = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Title_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Note_txt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Add_Btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Time_End_CB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Priority_CB)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_Begin_CB
            // 
            this.Time_Begin_CB.CalendarTodayDate = new System.DateTime(2023, 10, 8, 0, 0, 0, 0);
            this.Time_Begin_CB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Time_Begin_CB.Location = new System.Drawing.Point(147, 63);
            this.Time_Begin_CB.Name = "Time_Begin_CB";
            this.Time_Begin_CB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Time_Begin_CB.Size = new System.Drawing.Size(164, 21);
            this.Time_Begin_CB.TabIndex = 21;
            this.Time_Begin_CB.ValueChanged += new System.EventHandler(this.Time_Begin_CB_ValueChanged);
            // 
            // Priority_CB
            // 
            this.Priority_CB.AllowDrop = true;
            this.Priority_CB.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Priority_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Priority_CB.DropDownWidth = 164;
            this.Priority_CB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Priority_CB.Location = new System.Drawing.Point(147, 38);
            this.Priority_CB.Name = "Priority_CB";
            this.Priority_CB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Priority_CB.Size = new System.Drawing.Size(164, 21);
            this.Priority_CB.TabIndex = 20;
            this.Priority_CB.SelectedIndexChanged += new System.EventHandler(this.Priority_CB_SelectedIndexChanged);
            // 
            // Title_txt
            // 
            this.Title_txt.Location = new System.Drawing.Point(147, 11);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(164, 23);
            this.Title_txt.TabIndex = 19;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(12, 64);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel4.TabIndex = 17;
            this.kryptonLabel4.Values.Text = "Thời gian lên lịch";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(12, 38);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel3.TabIndex = 16;
            this.kryptonLabel3.Values.Text = "Mức ưu tiên";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 20);
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Tiêu đề";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(12, 90);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(129, 20);
            this.kryptonLabel5.TabIndex = 22;
            this.kryptonLabel5.Values.Text = "Thời gian Hoàn thành";
            // 
            // Note_txt
            // 
            this.Note_txt.Location = new System.Drawing.Point(147, 113);
            this.Note_txt.Name = "Note_txt";
            this.Note_txt.Size = new System.Drawing.Size(164, 23);
            this.Note_txt.TabIndex = 25;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(12, 116);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel6.TabIndex = 24;
            this.kryptonLabel6.Values.Text = "Ghi chú";
            // 
            // Add_Btn
            // 
            this.Add_Btn.Enabled = false;
            this.Add_Btn.Location = new System.Drawing.Point(147, 142);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Add_Btn.Size = new System.Drawing.Size(164, 32);
            this.Add_Btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Btn.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Add_Btn.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.Add_Btn.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.Add_Btn.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Add_Btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Add_Btn.TabIndex = 26;
            this.Add_Btn.Values.Text = "Thêm";
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Time_End_CB
            // 
            this.Time_End_CB.Location = new System.Drawing.Point(147, 87);
            this.Time_End_CB.Name = "Time_End_CB";
            this.Time_End_CB.Size = new System.Drawing.Size(164, 23);
            this.Time_End_CB.TabIndex = 27;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 186);
            this.Controls.Add(this.Time_End_CB);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Note_txt);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.Time_Begin_CB);
            this.Controls.Add(this.Priority_CB);
            this.Controls.Add(this.Title_txt);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.Priority_CB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker Time_Begin_CB;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Priority_CB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Title_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Note_txt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Add_Btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Time_End_CB;
    }
}