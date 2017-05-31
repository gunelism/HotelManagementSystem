namespace hotel2
{
    partial class Reserve
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
            this.roomreservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test1DataSet1 = new hotel2.test1DataSet1();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRoomİd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.room_reservationTableAdapter = new hotel2.test1DataSet1TableAdapters.room_reservationTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hotel2DataSet5 = new hotel2.hotel2DataSet5();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new hotel2.hotel2DataSet5TableAdapters.reservationTableAdapter();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.btnSelectRoom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCheckin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateCheckout = new System.Windows.Forms.DateTimePicker();
            this.txtGuestN = new System.Windows.Forms.TextBox();
            this.txtPaymentİd = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomreservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel2DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomreservationBindingSource
            // 
            this.roomreservationBindingSource.DataMember = "room_reservation";
            this.roomreservationBindingSource.DataSource = this.test1DataSet1;
            // 
            // test1DataSet1
            // 
            this.test1DataSet1.DataSetName = "test1DataSet1";
            this.test1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtRoomİd
            // 
            this.txtRoomİd.Location = new System.Drawing.Point(210, 74);
            this.txtRoomİd.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomİd.Name = "txtRoomİd";
            this.txtRoomİd.Size = new System.Drawing.Size(148, 22);
            this.txtRoomİd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Room İd";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(393, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(493, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Edit";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(794, 272);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(794, 319);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 10;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // room_reservationTableAdapter
            // 
            this.room_reservationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.useridDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn1,
            this.durationDataGridViewTextBoxColumn1,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.guestcountDataGridViewTextBoxColumn,
            this.paymentidDataGridViewTextBoxColumn,
            this.totalcountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.reservationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(741, 176);
            this.dataGridView2.TabIndex = 11;
            // 
            // hotel2DataSet5
            // 
            this.hotel2DataSet5.DataSetName = "hotel2DataSet5";
            this.hotel2DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "reservation";
            this.reservationBindingSource.DataSource = this.hotel2DataSet5;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(393, 43);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(116, 23);
            this.btnSelectUser.TabIndex = 12;
            this.btnSelectUser.Text = "Select User";
            this.btnSelectUser.UseVisualStyleBackColor = true;
            this.btnSelectUser.Click += new System.EventHandler(this.btnSelectUser_Click);
            // 
            // btnSelectRoom
            // 
            this.btnSelectRoom.Location = new System.Drawing.Point(393, 74);
            this.btnSelectRoom.Name = "btnSelectRoom";
            this.btnSelectRoom.Size = new System.Drawing.Size(116, 23);
            this.btnSelectRoom.TabIndex = 13;
            this.btnSelectRoom.Text = "Select Room";
            this.btnSelectRoom.UseVisualStyleBackColor = true;
            this.btnSelectRoom.Click += new System.EventHandler(this.btnSelectRoom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Check İn";
            // 
            // dateCheckin
            // 
            this.dateCheckin.Location = new System.Drawing.Point(210, 133);
            this.dateCheckin.Name = "dateCheckin";
            this.dateCheckin.Size = new System.Drawing.Size(148, 22);
            this.dateCheckin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Duration";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(210, 104);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(148, 22);
            this.txtDuration.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Check Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Guset Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Payment İd";
            // 
            // dateCheckout
            // 
            this.dateCheckout.Location = new System.Drawing.Point(210, 162);
            this.dateCheckout.Name = "dateCheckout";
            this.dateCheckout.Size = new System.Drawing.Size(148, 22);
            this.dateCheckout.TabIndex = 22;
            // 
            // txtGuestN
            // 
            this.txtGuestN.Location = new System.Drawing.Point(210, 191);
            this.txtGuestN.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestN.Name = "txtGuestN";
            this.txtGuestN.Size = new System.Drawing.Size(148, 22);
            this.txtGuestN.TabIndex = 23;
            // 
            // txtPaymentİd
            // 
            this.txtPaymentİd.Location = new System.Drawing.Point(210, 222);
            this.txtPaymentİd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaymentİd.Name = "txtPaymentİd";
            this.txtPaymentİd.Size = new System.Drawing.Size(148, 22);
            this.txtPaymentİd.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.Width = 65;
            // 
            // roomidDataGridViewTextBoxColumn1
            // 
            this.roomidDataGridViewTextBoxColumn1.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn1.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn1.Name = "roomidDataGridViewTextBoxColumn1";
            this.roomidDataGridViewTextBoxColumn1.Width = 68;
            // 
            // durationDataGridViewTextBoxColumn1
            // 
            this.durationDataGridViewTextBoxColumn1.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn1.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn1.Name = "durationDataGridViewTextBoxColumn1";
            this.durationDataGridViewTextBoxColumn1.Width = 70;
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "checkin";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            this.checkinDataGridViewTextBoxColumn.Width = 80;
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "checkout";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            this.checkoutDataGridViewTextBoxColumn.Width = 80;
            // 
            // guestcountDataGridViewTextBoxColumn
            // 
            this.guestcountDataGridViewTextBoxColumn.DataPropertyName = "guest_count";
            this.guestcountDataGridViewTextBoxColumn.HeaderText = "guest_count";
            this.guestcountDataGridViewTextBoxColumn.Name = "guestcountDataGridViewTextBoxColumn";
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.Width = 95;
            // 
            // totalcountDataGridViewTextBoxColumn
            // 
            this.totalcountDataGridViewTextBoxColumn.DataPropertyName = "total_count";
            this.totalcountDataGridViewTextBoxColumn.HeaderText = "total_count";
            this.totalcountDataGridViewTextBoxColumn.Name = "totalcountDataGridViewTextBoxColumn";
            this.totalcountDataGridViewTextBoxColumn.Width = 90;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 460);
            this.Controls.Add(this.txtPaymentİd);
            this.Controls.Add(this.txtGuestN);
            this.Controls.Add(this.dateCheckout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateCheckin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectRoom);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomİd);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomreservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel2DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRoomİd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntDelete;
        private test1DataSet1 test1DataSet1;
        private System.Windows.Forms.BindingSource roomreservationBindingSource;
        private test1DataSet1TableAdapters.room_reservationTableAdapter room_reservationTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private hotel2DataSet5 hotel2DataSet5;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private hotel2DataSet5TableAdapters.reservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Button btnSelectRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateCheckout;
        private System.Windows.Forms.TextBox txtGuestN;
        private System.Windows.Forms.TextBox txtPaymentİd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcountDataGridViewTextBoxColumn;
    }
}