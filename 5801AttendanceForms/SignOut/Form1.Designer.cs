namespace SignOut
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label meeting_DateLabel;
            System.Windows.Forms.Label time_OutLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._5801DataSet = new SignOut._5801DataSet();
            this.member_Time_outBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.member_Time_outTableAdapter = new SignOut._5801DataSetTableAdapters.Member_Time_outTableAdapter();
            this.tableAdapterManager = new SignOut._5801DataSetTableAdapters.TableAdapterManager();
            this.member_Time_outBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.member_Time_outBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.meeting_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_OutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            meeting_DateLabel = new System.Windows.Forms.Label();
            time_OutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._5801DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_Time_outBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_Time_outBindingNavigator)).BeginInit();
            this.member_Time_outBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(25, 195);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(25, 143);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 3;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(25, 169);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // meeting_DateLabel
            // 
            meeting_DateLabel.AutoSize = true;
            meeting_DateLabel.Location = new System.Drawing.Point(25, 222);
            meeting_DateLabel.Name = "meeting_DateLabel";
            meeting_DateLabel.Size = new System.Drawing.Size(74, 13);
            meeting_DateLabel.TabIndex = 7;
            meeting_DateLabel.Text = "Meeting Date:";
            // 
            // time_OutLabel
            // 
            time_OutLabel.AutoSize = true;
            time_OutLabel.Location = new System.Drawing.Point(25, 248);
            time_OutLabel.Name = "time_OutLabel";
            time_OutLabel.Size = new System.Drawing.Size(53, 13);
            time_OutLabel.TabIndex = 9;
            time_OutLabel.Text = "Time Out:";
            // 
            // _5801DataSet
            // 
            this._5801DataSet.DataSetName = "_5801DataSet";
            this._5801DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // member_Time_outBindingSource
            // 
            this.member_Time_outBindingSource.DataMember = "Member Time-out";
            this.member_Time_outBindingSource.DataSource = this._5801DataSet;
            // 
            // member_Time_outTableAdapter
            // 
            this.member_Time_outTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Division_ScheduleTableAdapter = null;
            this.tableAdapterManager.Member_Time_inTableAdapter = null;
            this.tableAdapterManager.Member_Time_outTableAdapter = this.member_Time_outTableAdapter;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SignOut._5801DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // member_Time_outBindingNavigator
            // 
            this.member_Time_outBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.member_Time_outBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.member_Time_outBindingNavigator.BindingSource = this.member_Time_outBindingSource;
            this.member_Time_outBindingNavigator.CountItem = null;
            this.member_Time_outBindingNavigator.DeleteItem = null;
            this.member_Time_outBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.member_Time_outBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.member_Time_outBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.member_Time_outBindingNavigatorSaveItem});
            this.member_Time_outBindingNavigator.Location = new System.Drawing.Point(26, 109);
            this.member_Time_outBindingNavigator.MoveFirstItem = null;
            this.member_Time_outBindingNavigator.MoveLastItem = null;
            this.member_Time_outBindingNavigator.MoveNextItem = null;
            this.member_Time_outBindingNavigator.MovePreviousItem = null;
            this.member_Time_outBindingNavigator.Name = "member_Time_outBindingNavigator";
            this.member_Time_outBindingNavigator.PositionItem = null;
            this.member_Time_outBindingNavigator.Size = new System.Drawing.Size(151, 25);
            this.member_Time_outBindingNavigator.TabIndex = 0;
            this.member_Time_outBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(95, 22);
            this.bindingNavigatorAddNewItem.Text = "NEW SIGN-OUT";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // member_Time_outBindingNavigatorSaveItem
            // 
            this.member_Time_outBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.member_Time_outBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("member_Time_outBindingNavigatorSaveItem.Image")));
            this.member_Time_outBindingNavigatorSaveItem.Name = "member_Time_outBindingNavigatorSaveItem";
            this.member_Time_outBindingNavigatorSaveItem.Size = new System.Drawing.Size(53, 22);
            this.member_Time_outBindingNavigatorSaveItem.Text = "SUBMIT";
            this.member_Time_outBindingNavigatorSaveItem.Click += new System.EventHandler(this.member_Time_outBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.member_Time_outBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(105, 192);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(32, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.first_NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.member_Time_outBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(105, 140);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.first_NameTextBox.TabIndex = 4;
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.last_NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.member_Time_outBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(105, 166);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(144, 20);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // meeting_DateDateTimePicker
            // 
            this.meeting_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.member_Time_outBindingSource, "Meeting Date", true));
            this.meeting_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.meeting_DateDateTimePicker.Location = new System.Drawing.Point(105, 218);
            this.meeting_DateDateTimePicker.Name = "meeting_DateDateTimePicker";
            this.meeting_DateDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.meeting_DateDateTimePicker.TabIndex = 8;
            // 
            // time_OutDateTimePicker
            // 
            this.time_OutDateTimePicker.CustomFormat = "h:mm tt";
            this.time_OutDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.member_Time_outBindingSource, "Time Out", true));
            this.time_OutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_OutDateTimePicker.Location = new System.Drawing.Point(105, 244);
            this.time_OutDateTimePicker.Name = "time_OutDateTimePicker";
            this.time_OutDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.time_OutDateTimePicker.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remember to click NEW SIGN-OUT before entering \r\ninfo, then click SUBMIT!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 15;
            this.button1.Text = "ID AUTO FILL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(meeting_DateLabel);
            this.Controls.Add(this.meeting_DateDateTimePicker);
            this.Controls.Add(time_OutLabel);
            this.Controls.Add(this.time_OutDateTimePicker);
            this.Controls.Add(this.member_Time_outBindingNavigator);
            this.Name = "Form1";
            this.Text = "Robotics Sign-out";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._5801DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_Time_outBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_Time_outBindingNavigator)).EndInit();
            this.member_Time_outBindingNavigator.ResumeLayout(false);
            this.member_Time_outBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _5801DataSet _5801DataSet;
        private System.Windows.Forms.BindingSource member_Time_outBindingSource;
        private _5801DataSetTableAdapters.Member_Time_outTableAdapter member_Time_outTableAdapter;
        private _5801DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator member_Time_outBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton member_Time_outBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.DateTimePicker meeting_DateDateTimePicker;
        private System.Windows.Forms.DateTimePicker time_OutDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

