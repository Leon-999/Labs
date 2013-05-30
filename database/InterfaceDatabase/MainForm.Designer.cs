namespace InterfaceDatabase
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabSwitch = new System.Windows.Forms.TabControl();
            this.customers = new System.Windows.Forms.TabPage();
            this.labelContact = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.buttonCancelEditCustomer = new System.Windows.Forms.Button();
            this.buttonSaveCustomer = new System.Windows.Forms.Button();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelRequisites = new System.Windows.Forms.Label();
            this.comboBoxNameFirm = new System.Windows.Forms.ComboBox();
            this.textBoxRequisites = new System.Windows.Forms.TextBox();
            this.labelNameFirm = new System.Windows.Forms.Label();
            this.telecasts = new System.Windows.Forms.TabPage();
            this.buttonDeleteTelecast = new System.Windows.Forms.Button();
            this.buttonNewTelecast = new System.Windows.Forms.Button();
            this.buttonCancelEditTelecast = new System.Windows.Forms.Button();
            this.buttonSaveEditTelecast = new System.Windows.Forms.Button();
            this.buttonEditTelecast = new System.Windows.Forms.Button();
            this.labelСostMinute = new System.Windows.Forms.Label();
            this.textBoxСostMinute = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.comboBoxNameTelecast = new System.Windows.Forms.ComboBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelNameTelecast = new System.Windows.Forms.Label();
            this.agents = new System.Windows.Forms.TabPage();
            this.buttonDeleteAgent = new System.Windows.Forms.Button();
            this.buttonNewAgent = new System.Windows.Forms.Button();
            this.buttonCancelEditAgent = new System.Windows.Forms.Button();
            this.buttonSaveAgent = new System.Windows.Forms.Button();
            this.buttonEditAgent = new System.Windows.Forms.Button();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelNameAgent = new System.Windows.Forms.Label();
            this.comboBoxSurnameAgent = new System.Windows.Forms.ComboBox();
            this.textBoxNameAgent = new System.Windows.Forms.TextBox();
            this.labelSurnameAgent = new System.Windows.Forms.Label();
            this.advertisement = new System.Windows.Forms.TabPage();
            this.tabSwitch.SuspendLayout();
            this.customers.SuspendLayout();
            this.telecasts.SuspendLayout();
            this.agents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSwitch
            // 
            this.tabSwitch.Controls.Add(this.customers);
            this.tabSwitch.Controls.Add(this.telecasts);
            this.tabSwitch.Controls.Add(this.agents);
            this.tabSwitch.Controls.Add(this.advertisement);
            this.tabSwitch.Location = new System.Drawing.Point(12, 12);
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.SelectedIndex = 0;
            this.tabSwitch.Size = new System.Drawing.Size(519, 253);
            this.tabSwitch.TabIndex = 0;
            this.tabSwitch.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabSwitch_Selecting);
            // 
            // customers
            // 
            this.customers.Controls.Add(this.labelContact);
            this.customers.Controls.Add(this.textBoxContact);
            this.customers.Controls.Add(this.buttonDeleteCustomer);
            this.customers.Controls.Add(this.buttonNewCustomer);
            this.customers.Controls.Add(this.buttonCancelEditCustomer);
            this.customers.Controls.Add(this.buttonSaveCustomer);
            this.customers.Controls.Add(this.buttonEditCustomer);
            this.customers.Controls.Add(this.labelTelephone);
            this.customers.Controls.Add(this.textBoxTelephone);
            this.customers.Controls.Add(this.labelRequisites);
            this.customers.Controls.Add(this.comboBoxNameFirm);
            this.customers.Controls.Add(this.textBoxRequisites);
            this.customers.Controls.Add(this.labelNameFirm);
            this.customers.Location = new System.Drawing.Point(4, 22);
            this.customers.Name = "customers";
            this.customers.Padding = new System.Windows.Forms.Padding(3);
            this.customers.Size = new System.Drawing.Size(511, 227);
            this.customers.TabIndex = 0;
            this.customers.Text = "заказчики";
            this.customers.UseVisualStyleBackColor = true;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(370, 23);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(92, 13);
            this.labelContact.TabIndex = 27;
            this.labelContact.Text = "контактное лицо";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(373, 38);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(106, 20);
            this.textBoxContact.TabIndex = 26;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(149, 131);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(106, 22);
            this.buttonDeleteCustomer.TabIndex = 25;
            this.buttonDeleteCustomer.Text = "удалить";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Location = new System.Drawing.Point(149, 103);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(106, 22);
            this.buttonNewCustomer.TabIndex = 24;
            this.buttonNewCustomer.Text = "добавить";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
            // 
            // buttonCancelEditCustomer
            // 
            this.buttonCancelEditCustomer.Enabled = false;
            this.buttonCancelEditCustomer.Location = new System.Drawing.Point(268, 103);
            this.buttonCancelEditCustomer.Name = "buttonCancelEditCustomer";
            this.buttonCancelEditCustomer.Size = new System.Drawing.Size(99, 22);
            this.buttonCancelEditCustomer.TabIndex = 23;
            this.buttonCancelEditCustomer.Text = "отмена";
            this.buttonCancelEditCustomer.UseVisualStyleBackColor = true;
            this.buttonCancelEditCustomer.Click += new System.EventHandler(this.buttonCancelEditCustomer_Click);
            // 
            // buttonSaveCustomer
            // 
            this.buttonSaveCustomer.Enabled = false;
            this.buttonSaveCustomer.Location = new System.Drawing.Point(268, 76);
            this.buttonSaveCustomer.Name = "buttonSaveCustomer";
            this.buttonSaveCustomer.Size = new System.Drawing.Size(99, 21);
            this.buttonSaveCustomer.TabIndex = 22;
            this.buttonSaveCustomer.Text = "сохранить";
            this.buttonSaveCustomer.UseVisualStyleBackColor = true;
            this.buttonSaveCustomer.Click += new System.EventHandler(this.buttonSaveCustomer_Click);
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.Location = new System.Drawing.Point(149, 76);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(106, 21);
            this.buttonEditCustomer.TabIndex = 21;
            this.buttonEditCustomer.Text = "редактировать";
            this.buttonEditCustomer.UseVisualStyleBackColor = true;
            this.buttonEditCustomer.Click += new System.EventHandler(this.buttonEditCustomer_Click);
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Location = new System.Drawing.Point(258, 23);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(50, 13);
            this.labelTelephone.TabIndex = 20;
            this.labelTelephone.Text = "телефон";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(261, 38);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(106, 20);
            this.textBoxTelephone.TabIndex = 19;
            // 
            // labelRequisites
            // 
            this.labelRequisites.AutoSize = true;
            this.labelRequisites.Location = new System.Drawing.Point(130, 23);
            this.labelRequisites.Name = "labelRequisites";
            this.labelRequisites.Size = new System.Drawing.Size(125, 13);
            this.labelRequisites.TabIndex = 18;
            this.labelRequisites.Text = "банковские реквизиты";
            // 
            // comboBoxNameFirm
            // 
            this.comboBoxNameFirm.FormattingEnabled = true;
            this.comboBoxNameFirm.Location = new System.Drawing.Point(22, 38);
            this.comboBoxNameFirm.Name = "comboBoxNameFirm";
            this.comboBoxNameFirm.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameFirm.TabIndex = 17;
            this.comboBoxNameFirm.TextChanged += new System.EventHandler(this.comboBoxNameFirm_TextChanged);
            // 
            // textBoxRequisites
            // 
            this.textBoxRequisites.Location = new System.Drawing.Point(149, 39);
            this.textBoxRequisites.Name = "textBoxRequisites";
            this.textBoxRequisites.Size = new System.Drawing.Size(106, 20);
            this.textBoxRequisites.TabIndex = 16;
            // 
            // labelNameFirm
            // 
            this.labelNameFirm.AutoSize = true;
            this.labelNameFirm.Location = new System.Drawing.Point(19, 22);
            this.labelNameFirm.Name = "labelNameFirm";
            this.labelNameFirm.Size = new System.Drawing.Size(94, 13);
            this.labelNameFirm.TabIndex = 15;
            this.labelNameFirm.Text = "название фирмы";
            // 
            // telecasts
            // 
            this.telecasts.Controls.Add(this.buttonDeleteTelecast);
            this.telecasts.Controls.Add(this.buttonNewTelecast);
            this.telecasts.Controls.Add(this.buttonCancelEditTelecast);
            this.telecasts.Controls.Add(this.buttonSaveEditTelecast);
            this.telecasts.Controls.Add(this.buttonEditTelecast);
            this.telecasts.Controls.Add(this.labelСostMinute);
            this.telecasts.Controls.Add(this.textBoxСostMinute);
            this.telecasts.Controls.Add(this.labelRating);
            this.telecasts.Controls.Add(this.comboBoxNameTelecast);
            this.telecasts.Controls.Add(this.textBoxRating);
            this.telecasts.Controls.Add(this.labelNameTelecast);
            this.telecasts.Location = new System.Drawing.Point(4, 22);
            this.telecasts.Name = "telecasts";
            this.telecasts.Padding = new System.Windows.Forms.Padding(3);
            this.telecasts.Size = new System.Drawing.Size(511, 227);
            this.telecasts.TabIndex = 1;
            this.telecasts.Text = "передачи";
            this.telecasts.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTelecast
            // 
            this.buttonDeleteTelecast.Location = new System.Drawing.Point(149, 131);
            this.buttonDeleteTelecast.Name = "buttonDeleteTelecast";
            this.buttonDeleteTelecast.Size = new System.Drawing.Size(106, 22);
            this.buttonDeleteTelecast.TabIndex = 38;
            this.buttonDeleteTelecast.Text = "удалить";
            this.buttonDeleteTelecast.UseVisualStyleBackColor = true;
            this.buttonDeleteTelecast.Click += new System.EventHandler(this.buttonDeleteTelecast_Click);
            // 
            // buttonNewTelecast
            // 
            this.buttonNewTelecast.Location = new System.Drawing.Point(149, 103);
            this.buttonNewTelecast.Name = "buttonNewTelecast";
            this.buttonNewTelecast.Size = new System.Drawing.Size(106, 22);
            this.buttonNewTelecast.TabIndex = 37;
            this.buttonNewTelecast.Text = "добавить";
            this.buttonNewTelecast.UseVisualStyleBackColor = true;
            this.buttonNewTelecast.Click += new System.EventHandler(this.buttonNewTelecast_Click);
            // 
            // buttonCancelEditTelecast
            // 
            this.buttonCancelEditTelecast.Enabled = false;
            this.buttonCancelEditTelecast.Location = new System.Drawing.Point(268, 103);
            this.buttonCancelEditTelecast.Name = "buttonCancelEditTelecast";
            this.buttonCancelEditTelecast.Size = new System.Drawing.Size(99, 22);
            this.buttonCancelEditTelecast.TabIndex = 36;
            this.buttonCancelEditTelecast.Text = "отмена";
            this.buttonCancelEditTelecast.UseVisualStyleBackColor = true;
            this.buttonCancelEditTelecast.Click += new System.EventHandler(this.buttonCancelEditTelecast_Click);
            // 
            // buttonSaveEditTelecast
            // 
            this.buttonSaveEditTelecast.Enabled = false;
            this.buttonSaveEditTelecast.Location = new System.Drawing.Point(268, 76);
            this.buttonSaveEditTelecast.Name = "buttonSaveEditTelecast";
            this.buttonSaveEditTelecast.Size = new System.Drawing.Size(99, 21);
            this.buttonSaveEditTelecast.TabIndex = 35;
            this.buttonSaveEditTelecast.Text = "сохранить";
            this.buttonSaveEditTelecast.UseVisualStyleBackColor = true;
            this.buttonSaveEditTelecast.Click += new System.EventHandler(this.buttonSaveEditTelecast_Click);
            // 
            // buttonEditTelecast
            // 
            this.buttonEditTelecast.Location = new System.Drawing.Point(149, 76);
            this.buttonEditTelecast.Name = "buttonEditTelecast";
            this.buttonEditTelecast.Size = new System.Drawing.Size(106, 21);
            this.buttonEditTelecast.TabIndex = 34;
            this.buttonEditTelecast.Text = "редактировать";
            this.buttonEditTelecast.UseVisualStyleBackColor = true;
            this.buttonEditTelecast.Click += new System.EventHandler(this.buttonEditTelecast_Click);
            // 
            // labelСostMinute
            // 
            this.labelСostMinute.AutoSize = true;
            this.labelСostMinute.Location = new System.Drawing.Point(258, 23);
            this.labelСostMinute.Name = "labelСostMinute";
            this.labelСostMinute.Size = new System.Drawing.Size(102, 13);
            this.labelСostMinute.TabIndex = 33;
            this.labelСostMinute.Text = "стоимость минуты";
            // 
            // textBoxСostMinute
            // 
            this.textBoxСostMinute.Location = new System.Drawing.Point(261, 38);
            this.textBoxСostMinute.Name = "textBoxСostMinute";
            this.textBoxСostMinute.Size = new System.Drawing.Size(106, 20);
            this.textBoxСostMinute.TabIndex = 32;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(146, 23);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(47, 13);
            this.labelRating.TabIndex = 31;
            this.labelRating.Text = "рейтинг";
            // 
            // comboBoxNameTelecast
            // 
            this.comboBoxNameTelecast.FormattingEnabled = true;
            this.comboBoxNameTelecast.Location = new System.Drawing.Point(22, 38);
            this.comboBoxNameTelecast.Name = "comboBoxNameTelecast";
            this.comboBoxNameTelecast.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameTelecast.TabIndex = 30;
            this.comboBoxNameTelecast.TextChanged += new System.EventHandler(this.comboBoxNameTelecast_TextChanged);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(149, 39);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(106, 20);
            this.textBoxRating.TabIndex = 29;
            // 
            // labelNameTelecast
            // 
            this.labelNameTelecast.AutoSize = true;
            this.labelNameTelecast.Location = new System.Drawing.Point(19, 22);
            this.labelNameTelecast.Name = "labelNameTelecast";
            this.labelNameTelecast.Size = new System.Drawing.Size(105, 13);
            this.labelNameTelecast.TabIndex = 28;
            this.labelNameTelecast.Text = "название передачи";
            // 
            // agents
            // 
            this.agents.Controls.Add(this.buttonDeleteAgent);
            this.agents.Controls.Add(this.buttonNewAgent);
            this.agents.Controls.Add(this.buttonCancelEditAgent);
            this.agents.Controls.Add(this.buttonSaveAgent);
            this.agents.Controls.Add(this.buttonEditAgent);
            this.agents.Controls.Add(this.labelPatronymic);
            this.agents.Controls.Add(this.textBoxPatronymic);
            this.agents.Controls.Add(this.labelNameAgent);
            this.agents.Controls.Add(this.comboBoxSurnameAgent);
            this.agents.Controls.Add(this.textBoxNameAgent);
            this.agents.Controls.Add(this.labelSurnameAgent);
            this.agents.Location = new System.Drawing.Point(4, 22);
            this.agents.Name = "agents";
            this.agents.Size = new System.Drawing.Size(511, 227);
            this.agents.TabIndex = 2;
            this.agents.Text = "агенты";
            this.agents.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteAgent
            // 
            this.buttonDeleteAgent.Location = new System.Drawing.Point(149, 131);
            this.buttonDeleteAgent.Name = "buttonDeleteAgent";
            this.buttonDeleteAgent.Size = new System.Drawing.Size(106, 22);
            this.buttonDeleteAgent.TabIndex = 14;
            this.buttonDeleteAgent.Text = "удалить";
            this.buttonDeleteAgent.UseVisualStyleBackColor = true;
            this.buttonDeleteAgent.Click += new System.EventHandler(this.buttonDeleteAgent_Click);
            // 
            // buttonNewAgent
            // 
            this.buttonNewAgent.Location = new System.Drawing.Point(149, 103);
            this.buttonNewAgent.Name = "buttonNewAgent";
            this.buttonNewAgent.Size = new System.Drawing.Size(106, 22);
            this.buttonNewAgent.TabIndex = 13;
            this.buttonNewAgent.Text = "добавить";
            this.buttonNewAgent.UseVisualStyleBackColor = true;
            this.buttonNewAgent.Click += new System.EventHandler(this.buttonNewAgent_Click);
            // 
            // buttonCancelEditAgent
            // 
            this.buttonCancelEditAgent.Enabled = false;
            this.buttonCancelEditAgent.Location = new System.Drawing.Point(268, 103);
            this.buttonCancelEditAgent.Name = "buttonCancelEditAgent";
            this.buttonCancelEditAgent.Size = new System.Drawing.Size(99, 22);
            this.buttonCancelEditAgent.TabIndex = 12;
            this.buttonCancelEditAgent.Text = "отмена";
            this.buttonCancelEditAgent.UseVisualStyleBackColor = true;
            this.buttonCancelEditAgent.Click += new System.EventHandler(this.buttonCancelEditAgent_Click);
            // 
            // buttonSaveAgent
            // 
            this.buttonSaveAgent.Enabled = false;
            this.buttonSaveAgent.Location = new System.Drawing.Point(268, 76);
            this.buttonSaveAgent.Name = "buttonSaveAgent";
            this.buttonSaveAgent.Size = new System.Drawing.Size(99, 21);
            this.buttonSaveAgent.TabIndex = 11;
            this.buttonSaveAgent.Text = "сохранить";
            this.buttonSaveAgent.UseVisualStyleBackColor = true;
            this.buttonSaveAgent.Click += new System.EventHandler(this.buttonSaveAgent_Click);
            // 
            // buttonEditAgent
            // 
            this.buttonEditAgent.Location = new System.Drawing.Point(149, 76);
            this.buttonEditAgent.Name = "buttonEditAgent";
            this.buttonEditAgent.Size = new System.Drawing.Size(106, 21);
            this.buttonEditAgent.TabIndex = 10;
            this.buttonEditAgent.Text = "редактировать";
            this.buttonEditAgent.UseVisualStyleBackColor = true;
            this.buttonEditAgent.Click += new System.EventHandler(this.buttonEditAgent_Click);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(259, 22);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(52, 13);
            this.labelPatronymic.TabIndex = 9;
            this.labelPatronymic.Text = "отчество";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(261, 39);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(106, 20);
            this.textBoxPatronymic.TabIndex = 8;
            // 
            // labelNameAgent
            // 
            this.labelNameAgent.AutoSize = true;
            this.labelNameAgent.Location = new System.Drawing.Point(147, 22);
            this.labelNameAgent.Name = "labelNameAgent";
            this.labelNameAgent.Size = new System.Drawing.Size(27, 13);
            this.labelNameAgent.TabIndex = 7;
            this.labelNameAgent.Text = "имя";
            // 
            // comboBoxSurnameAgent
            // 
            this.comboBoxSurnameAgent.FormattingEnabled = true;
            this.comboBoxSurnameAgent.Location = new System.Drawing.Point(22, 38);
            this.comboBoxSurnameAgent.Name = "comboBoxSurnameAgent";
            this.comboBoxSurnameAgent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSurnameAgent.TabIndex = 6;
            this.comboBoxSurnameAgent.TextChanged += new System.EventHandler(this.comboBoxSurnameAgent_TextChanged);
            // 
            // textBoxNameAgent
            // 
            this.textBoxNameAgent.Location = new System.Drawing.Point(149, 39);
            this.textBoxNameAgent.Name = "textBoxNameAgent";
            this.textBoxNameAgent.Size = new System.Drawing.Size(106, 20);
            this.textBoxNameAgent.TabIndex = 5;
            // 
            // labelSurnameAgent
            // 
            this.labelSurnameAgent.AutoSize = true;
            this.labelSurnameAgent.Location = new System.Drawing.Point(19, 22);
            this.labelSurnameAgent.Name = "labelSurnameAgent";
            this.labelSurnameAgent.Size = new System.Drawing.Size(53, 13);
            this.labelSurnameAgent.TabIndex = 4;
            this.labelSurnameAgent.Text = "фамилия";
            // 
            // advertisement
            // 
            this.advertisement.Location = new System.Drawing.Point(4, 22);
            this.advertisement.Name = "advertisement";
            this.advertisement.Size = new System.Drawing.Size(511, 227);
            this.advertisement.TabIndex = 3;
            this.advertisement.Text = "реклама";
            this.advertisement.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 277);
            this.Controls.Add(this.tabSwitch);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabSwitch.ResumeLayout(false);
            this.customers.ResumeLayout(false);
            this.customers.PerformLayout();
            this.telecasts.ResumeLayout(false);
            this.telecasts.PerformLayout();
            this.agents.ResumeLayout(false);
            this.agents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSwitch;
        private System.Windows.Forms.TabPage customers;
        private System.Windows.Forms.TabPage telecasts;
        private System.Windows.Forms.TabPage agents;
        private System.Windows.Forms.TabPage advertisement;
        private System.Windows.Forms.Label labelNameAgent;
        private System.Windows.Forms.ComboBox comboBoxSurnameAgent;
        private System.Windows.Forms.TextBox textBoxNameAgent;
        private System.Windows.Forms.Label labelSurnameAgent;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Button buttonEditAgent;
        private System.Windows.Forms.Button buttonSaveAgent;
        private System.Windows.Forms.Button buttonCancelEditAgent;
        private System.Windows.Forms.Button buttonNewAgent;
        private System.Windows.Forms.Button buttonDeleteAgent;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.Button buttonCancelEditCustomer;
        private System.Windows.Forms.Button buttonSaveCustomer;
        private System.Windows.Forms.Button buttonEditCustomer;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelRequisites;
        private System.Windows.Forms.ComboBox comboBoxNameFirm;
        private System.Windows.Forms.TextBox textBoxRequisites;
        private System.Windows.Forms.Label labelNameFirm;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.Button buttonDeleteTelecast;
        private System.Windows.Forms.Button buttonNewTelecast;
        private System.Windows.Forms.Button buttonCancelEditTelecast;
        private System.Windows.Forms.Button buttonSaveEditTelecast;
        private System.Windows.Forms.Button buttonEditTelecast;
        private System.Windows.Forms.Label labelСostMinute;
        private System.Windows.Forms.TextBox textBoxСostMinute;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.ComboBox comboBoxNameTelecast;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelNameTelecast;

    }
}

