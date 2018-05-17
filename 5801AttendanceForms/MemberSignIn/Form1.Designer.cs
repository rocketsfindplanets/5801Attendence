namespace MemberSignIn
{
    partial class Form1
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
            System.Windows.Forms.Label meeting_DateLabel;
            System.Windows.Forms.Label divisionLabel;
            System.Windows.Forms.Label time_InLabel;
            System.Windows.Forms.Label time_OutLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._5801DataSet = new MemberSignIn._5801DataSet();
            this.division_ScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.division_ScheduleTableAdapter = new MemberSignIn._5801DataSetTableAdapters.Division_ScheduleTableAdapter();
            this.tableAdapterManager = new MemberSignIn._5801DataSetTableAdapters.TableAdapterManager();
            this.division_ScheduleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.division_ScheduleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.meeting_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.divisionTextBox = new System.Windows.Forms.TextBox();
            this.time_InDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_OutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            meeting_DateLabel = new System.Windows.Forms.Label();
            divisionLabel = new System.Windows.Forms.Label();
            time_InLabel = new System.Windows.Forms.Label();
            time_OutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._5801DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.division_ScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.division_ScheduleBindingNavigator)).BeginInit();
            this.division_ScheduleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // meeting_DateLabel
            // 
            meeting_DateLabel.AutoSize = true;
            meeting_DateLabel.Location = new System.Drawing.Point(25, 147);
            meeting_DateLabel.Name = "meeting_DateLabel";
            meeting_DateLabel.Size = new System.Drawing.Size(74, 13);
            meeting_DateLabel.TabIndex = 1;
            meeting_DateLabel.Text = "Meeting Date:";
            // 
            // divisionLabel
            // 
            divisionLabel.AutoSize = true;
            divisionLabel.Location = new System.Drawing.Point(25, 172);
            divisionLabel.Name = "divisionLabel";
            divisionLabel.Size = new System.Drawing.Size(47, 13);
            divisionLabel.TabIndex = 3;
            divisionLabel.Text = "Division:";
            // 
            // time_InLabel
            // 
            time_InLabel.AutoSize = true;
            time_InLabel.Location = new System.Drawing.Point(25, 199);
            time_InLabel.Name = "time_InLabel";
            time_InLabel.Size = new System.Drawing.Size(45, 13);
            time_InLabel.TabIndex = 5;
            time_InLabel.Text = "Time In:";
            // 
            // time_OutLabel
            // 
            time_OutLabel.AutoSize = true;
            time_OutLabel.Location = new System.Drawing.Point(25, 225);
            time_OutLabel.Name = "time_OutLabel";
            time_OutLabel.Size = new System.Drawing.Size(53, 13);
            time_OutLabel.TabIndex = 7;
            time_OutLabel.Text = "Time Out:";
            // 
            // _5801DataSet
            // 
            this._5801DataSet.DataSetName = "_5801DataSet";
            this._5801DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // division_ScheduleBindingSource
            // 
            this.division_ScheduleBindingSource.DataMember = "Division Schedule";
            this.division_ScheduleBindingSource.DataSource = this._5801DataSet;
            // 
            // division_ScheduleTableAdapter
            // 
            this.division_ScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Division_ScheduleTableAdapter = this.division_ScheduleTableAdapter;
            this.tableAdapterManager.Member_Time_inTableAdapter = null;
            this.tableAdapterManager.Member_Time_outTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MemberSignIn._5801DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // division_ScheduleBindingNavigator
            // 
            this.division_ScheduleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.division_ScheduleBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.division_ScheduleBindingNavigator.BindingSource = this.division_ScheduleBindingSource;
            this.division_ScheduleBindingNavigator.CountItem = null;
            this.division_ScheduleBindingNavigator.DeleteItem = null;
            this.division_ScheduleBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.division_ScheduleBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.division_ScheduleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.division_ScheduleBindingNavigatorSaveItem});
            this.division_ScheduleBindingNavigator.Location = new System.Drawing.Point(26, 109);
            this.division_ScheduleBindingNavigator.MoveFirstItem = null;
            this.division_ScheduleBindingNavigator.MoveLastItem = null;
            this.division_ScheduleBindingNavigator.MoveNextItem = null;
            this.division_ScheduleBindingNavigator.MovePreviousItem = null;
            this.division_ScheduleBindingNavigator.Name = "division_ScheduleBindingNavigator";
            this.division_ScheduleBindingNavigator.PositionItem = null;
            this.division_ScheduleBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.division_ScheduleBindingNavigator.Size = new System.Drawing.Size(173, 25);
            this.division_ScheduleBindingNavigator.TabIndex = 0;
            this.division_ScheduleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(117, 22);
            this.bindingNavigatorAddNewItem.Text = "ADD NEW MEETING";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // division_ScheduleBindingNavigatorSaveItem
            // 
            this.division_ScheduleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.division_ScheduleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("division_ScheduleBindingNavigatorSaveItem.Image")));
            this.division_ScheduleBindingNavigatorSaveItem.Name = "division_ScheduleBindingNavigatorSaveItem";
            this.division_ScheduleBindingNavigatorSaveItem.Size = new System.Drawing.Size(53, 22);
            this.division_ScheduleBindingNavigatorSaveItem.Text = "SUBMIT";
            this.division_ScheduleBindingNavigatorSaveItem.Click += new System.EventHandler(this.division_ScheduleBindingNavigatorSaveItem_Click);
            // 
            // meeting_DateDateTimePicker
            // 
            this.meeting_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.division_ScheduleBindingSource, "Meeting Date", true));
            this.meeting_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meeting_DateDateTimePicker.Location = new System.Drawing.Point(105, 143);
            this.meeting_DateDateTimePicker.Name = "meeting_DateDateTimePicker";
            this.meeting_DateDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.meeting_DateDateTimePicker.TabIndex = 2;
            this.meeting_DateDateTimePicker.Value = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Captain",
            "Business",
            "Scouting",
            "Build",
            "Programming",
            "All team",
            "Spirit",
            "VEX"});
            this.divisionTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.divisionTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.divisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.division_ScheduleBindingSource, "Division", true));
            this.divisionTextBox.Location = new System.Drawing.Point(105, 169);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(129, 20);
            this.divisionTextBox.TabIndex = 4;
            // 
            // time_InDateTimePicker
            // 
            this.time_InDateTimePicker.CustomFormat = "h:mm tt";
            this.time_InDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.division_ScheduleBindingSource, "Time In", true));
            this.time_InDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_InDateTimePicker.Location = new System.Drawing.Point(105, 195);
            this.time_InDateTimePicker.Name = "time_InDateTimePicker";
            this.time_InDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.time_InDateTimePicker.TabIndex = 6;
            this.time_InDateTimePicker.Value = new System.DateTime(2017, 11, 10, 0, 0, 0, 0);
            // 
            // time_OutDateTimePicker
            // 
            this.time_OutDateTimePicker.CustomFormat = "h:mm tt";
            this.time_OutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.division_ScheduleBindingSource, "Time Out", true));
            this.time_OutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_OutDateTimePicker.Location = new System.Drawing.Point(105, 221);
            this.time_OutDateTimePicker.Name = "time_OutDateTimePicker";
            this.time_OutDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.time_OutDateTimePicker.TabIndex = 8;
            this.time_OutDateTimePicker.Value = new System.DateTime(2017, 11, 10, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MemberSignIn.Properties.Resources.CTCInspire;
            this.pictureBox1.Location = new System.Drawing.Point(21, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remember to click ADD NEW MEETING before entering info, then click SUBMIT!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(meeting_DateLabel);
            this.Controls.Add(this.meeting_DateDateTimePicker);
            this.Controls.Add(divisionLabel);
            this.Controls.Add(this.divisionTextBox);
            this.Controls.Add(time_InLabel);
            this.Controls.Add(this.time_InDateTimePicker);
            this.Controls.Add(time_OutLabel);
            this.Controls.Add(this.time_OutDateTimePicker);
            this.Controls.Add(this.division_ScheduleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Division Meetings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._5801DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.division_ScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.division_ScheduleBindingNavigator)).EndInit();
            this.division_ScheduleBindingNavigator.ResumeLayout(false);
            this.division_ScheduleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _5801DataSet _5801DataSet;
        private System.Windows.Forms.BindingSource division_ScheduleBindingSource;
        private _5801DataSetTableAdapters.Division_ScheduleTableAdapter division_ScheduleTableAdapter;
        private _5801DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator division_ScheduleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton division_ScheduleBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker meeting_DateDateTimePicker;
        private System.Windows.Forms.TextBox divisionTextBox;
        private System.Windows.Forms.DateTimePicker time_InDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_OutDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

