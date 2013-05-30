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
            this.textBoxSurnameAgent = new System.Windows.Forms.TextBox();
            this.textBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.textBoxNameTelecast = new System.Windows.Forms.TextBox();
            this.labelLenght = new System.Windows.Forms.Label();
            this.comboBoxNameAgentA = new System.Windows.Forms.ComboBox();
            this.labelNameAgentA = new System.Windows.Forms.Label();
            this.comboBoxNameCustomerA = new System.Windows.Forms.ComboBox();
            this.labelNameCustomerA = new System.Windows.Forms.Label();
            this.comboBoxNameTelecastA = new System.Windows.Forms.ComboBox();
            this.buttonDeleteAdvertisement = new System.Windows.Forms.Button();
            this.buttonNewAdvertisement = new System.Windows.Forms.Button();
            this.buttonCancelEditAdvertisement = new System.Windows.Forms.Button();
            this.buttonSaveEditAdvertisement = new System.Windows.Forms.Button();
            this.buttonEditAdvertisement = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.labelNameTelecastA = new System.Windows.Forms.Label();
            this.comboBoxCodeAdvertisement = new System.Windows.Forms.ComboBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelCodeAdvertisement = new System.Windows.Forms.Label();
            this.tabSwitch.SuspendLayout();
            this.customers.SuspendLayout();
            this.telecasts.SuspendLayout();
            this.agents.SuspendLayout();
            this.advertisement.SuspendLayout();
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
            this.labelContact.Location = new System.Drawing.Point(386, 22);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(92, 13);
            this.labelContact.TabIndex = 27;
            this.labelContact.Text = "контактное лицо";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(389, 39);
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
            this.labelTelephone.Location = new System.Drawing.Point(274, 22);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(50, 13);
            this.labelTelephone.TabIndex = 20;
            this.labelTelephone.Text = "телефон";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(277, 39);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(106, 20);
            this.textBoxTelephone.TabIndex = 19;
            // 
            // labelRequisites
            // 
            this.labelRequisites.AutoSize = true;
            this.labelRequisites.Location = new System.Drawing.Point(146, 22);
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
            this.textBoxRequisites.Size = new System.Drawing.Size(122, 20);
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
            this.textBoxСostMinute.Location = new System.Drawing.Point(261, 39);
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
            this.advertisement.Controls.Add(this.textBoxSurnameAgent);
            this.advertisement.Controls.Add(this.textBoxNameCustomer);
            this.advertisement.Controls.Add(this.textBoxNameTelecast);
            this.advertisement.Controls.Add(this.labelLenght);
            this.advertisement.Controls.Add(this.comboBoxNameAgentA);
            this.advertisement.Controls.Add(this.labelNameAgentA);
            this.advertisement.Controls.Add(this.comboBoxNameCustomerA);
            this.advertisement.Controls.Add(this.labelNameCustomerA);
            this.advertisement.Controls.Add(this.comboBoxNameTelecastA);
            this.advertisement.Controls.Add(this.buttonDeleteAdvertisement);
            this.advertisement.Controls.Add(this.buttonNewAdvertisement);
            this.advertisement.Controls.Add(this.buttonCancelEditAdvertisement);
            this.advertisement.Controls.Add(this.buttonSaveEditAdvertisement);
            this.advertisement.Controls.Add(this.buttonEditAdvertisement);
            this.advertisement.Controls.Add(this.labelData);
            this.advertisement.Controls.Add(this.textBoxLenght);
            this.advertisement.Controls.Add(this.labelNameTelecastA);
            this.advertisement.Controls.Add(this.comboBoxCodeAdvertisement);
            this.advertisement.Controls.Add(this.textBoxData);
            this.advertisement.Controls.Add(this.labelCodeAdvertisement);
            this.advertisement.Location = new System.Drawing.Point(4, 22);
            this.advertisement.Name = "advertisement";
            this.advertisement.Size = new System.Drawing.Size(511, 227);
            this.advertisement.TabIndex = 3;
            this.advertisement.Text = "реклама";
            this.advertisement.UseVisualStyleBackColor = true;
            // 
            // textBoxSurnameAgent
            // 
            this.textBoxSurnameAgent.Location = new System.Drawing.Point(353, 39);
            this.textBoxSurnameAgent.Name = "textBoxSurnameAgent";
            this.textBoxSurnameAgent.Size = new System.Drawing.Size(121, 20);
            this.textBoxSurnameAgent.TabIndex = 58;
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.Location = new System.Drawing.Point(226, 39);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(121, 20);
            this.textBoxNameCustomer.TabIndex = 57;
            // 
            // textBoxNameTelecast
            // 
            this.textBoxNameTelecast.Location = new System.Drawing.Point(99, 39);
            this.textBoxNameTelecast.Name = "textBoxNameTelecast";
            this.textBoxNameTelecast.Size = new System.Drawing.Size(121, 20);
            this.textBoxNameTelecast.TabIndex = 56;
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(350, 62);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(130, 13);
            this.labelLenght.TabIndex = 55;
            this.labelLenght.Text = "длительность в минутах";
            // 
            // comboBoxNameAgentA
            // 
            this.comboBoxNameAgentA.FormattingEnabled = true;
            this.comboBoxNameAgentA.Location = new System.Drawing.Point(353, 38);
            this.comboBoxNameAgentA.Name = "comboBoxNameAgentA";
            this.comboBoxNameAgentA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameAgentA.TabIndex = 54;
            // 
            // labelNameAgentA
            // 
            this.labelNameAgentA.AutoSize = true;
            this.labelNameAgentA.Location = new System.Drawing.Point(350, 22);
            this.labelNameAgentA.Name = "labelNameAgentA";
            this.labelNameAgentA.Size = new System.Drawing.Size(96, 13);
            this.labelNameAgentA.TabIndex = 53;
            this.labelNameAgentA.Text = "рекламный агент";
            // 
            // comboBoxNameCustomerA
            // 
            this.comboBoxNameCustomerA.FormattingEnabled = true;
            this.comboBoxNameCustomerA.Location = new System.Drawing.Point(226, 38);
            this.comboBoxNameCustomerA.Name = "comboBoxNameCustomerA";
            this.comboBoxNameCustomerA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameCustomerA.TabIndex = 52;
            // 
            // labelNameCustomerA
            // 
            this.labelNameCustomerA.AutoSize = true;
            this.labelNameCustomerA.Location = new System.Drawing.Point(223, 22);
            this.labelNameCustomerA.Name = "labelNameCustomerA";
            this.labelNameCustomerA.Size = new System.Drawing.Size(91, 13);
            this.labelNameCustomerA.TabIndex = 51;
            this.labelNameCustomerA.Text = "фирма-заказчик";
            // 
            // comboBoxNameTelecastA
            // 
            this.comboBoxNameTelecastA.FormattingEnabled = true;
            this.comboBoxNameTelecastA.Location = new System.Drawing.Point(99, 38);
            this.comboBoxNameTelecastA.Name = "comboBoxNameTelecastA";
            this.comboBoxNameTelecastA.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNameTelecastA.TabIndex = 50;
            // 
            // buttonDeleteAdvertisement
            // 
            this.buttonDeleteAdvertisement.Location = new System.Drawing.Point(226, 171);
            this.buttonDeleteAdvertisement.Name = "buttonDeleteAdvertisement";
            this.buttonDeleteAdvertisement.Size = new System.Drawing.Size(106, 22);
            this.buttonDeleteAdvertisement.TabIndex = 49;
            this.buttonDeleteAdvertisement.Text = "удалить";
            this.buttonDeleteAdvertisement.UseVisualStyleBackColor = true;
            this.buttonDeleteAdvertisement.Click += new System.EventHandler(this.buttonDeleteAdvertisement_Click);
            // 
            // buttonNewAdvertisement
            // 
            this.buttonNewAdvertisement.Location = new System.Drawing.Point(226, 143);
            this.buttonNewAdvertisement.Name = "buttonNewAdvertisement";
            this.buttonNewAdvertisement.Size = new System.Drawing.Size(106, 22);
            this.buttonNewAdvertisement.TabIndex = 48;
            this.buttonNewAdvertisement.Text = "добавить";
            this.buttonNewAdvertisement.UseVisualStyleBackColor = true;
            this.buttonNewAdvertisement.Click += new System.EventHandler(this.buttonNewAdvertisement_Click);
            // 
            // buttonCancelEditAdvertisement
            // 
            this.buttonCancelEditAdvertisement.Enabled = false;
            this.buttonCancelEditAdvertisement.Location = new System.Drawing.Point(345, 143);
            this.buttonCancelEditAdvertisement.Name = "buttonCancelEditAdvertisement";
            this.buttonCancelEditAdvertisement.Size = new System.Drawing.Size(99, 22);
            this.buttonCancelEditAdvertisement.TabIndex = 47;
            this.buttonCancelEditAdvertisement.Text = "отмена";
            this.buttonCancelEditAdvertisement.UseVisualStyleBackColor = true;
            this.buttonCancelEditAdvertisement.Click += new System.EventHandler(this.buttonCancelEditAdvertisement_Click);
            // 
            // buttonSaveEditAdvertisement
            // 
            this.buttonSaveEditAdvertisement.Enabled = false;
            this.buttonSaveEditAdvertisement.Location = new System.Drawing.Point(345, 116);
            this.buttonSaveEditAdvertisement.Name = "buttonSaveEditAdvertisement";
            this.buttonSaveEditAdvertisement.Size = new System.Drawing.Size(99, 21);
            this.buttonSaveEditAdvertisement.TabIndex = 46;
            this.buttonSaveEditAdvertisement.Text = "сохранить";
            this.buttonSaveEditAdvertisement.UseVisualStyleBackColor = true;
            this.buttonSaveEditAdvertisement.Click += new System.EventHandler(this.buttonSaveEditAdvertisement_Click);
            // 
            // buttonEditAdvertisement
            // 
            this.buttonEditAdvertisement.Location = new System.Drawing.Point(226, 116);
            this.buttonEditAdvertisement.Name = "buttonEditAdvertisement";
            this.buttonEditAdvertisement.Size = new System.Drawing.Size(106, 21);
            this.buttonEditAdvertisement.TabIndex = 45;
            this.buttonEditAdvertisement.Text = "редактировать";
            this.buttonEditAdvertisement.UseVisualStyleBackColor = true;
            this.buttonEditAdvertisement.Click += new System.EventHandler(this.buttonEditAdvertisement_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(223, 62);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 44;
            this.labelData.Text = "дата";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(353, 78);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(121, 20);
            this.textBoxLenght.TabIndex = 43;
            // 
            // labelNameTelecastA
            // 
            this.labelNameTelecastA.AutoSize = true;
            this.labelNameTelecastA.Location = new System.Drawing.Point(96, 22);
            this.labelNameTelecastA.Name = "labelNameTelecastA";
            this.labelNameTelecastA.Size = new System.Drawing.Size(105, 13);
            this.labelNameTelecastA.TabIndex = 42;
            this.labelNameTelecastA.Text = "название передачи";
            // 
            // comboBoxCodeAdvertisement
            // 
            this.comboBoxCodeAdvertisement.FormattingEnabled = true;
            this.comboBoxCodeAdvertisement.Location = new System.Drawing.Point(23, 38);
            this.comboBoxCodeAdvertisement.Name = "comboBoxCodeAdvertisement";
            this.comboBoxCodeAdvertisement.Size = new System.Drawing.Size(70, 21);
            this.comboBoxCodeAdvertisement.TabIndex = 41;
            this.comboBoxCodeAdvertisement.TextChanged += new System.EventHandler(this.comboBoxCodeAdvertisement_TextChanged);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(226, 78);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(121, 20);
            this.textBoxData.TabIndex = 40;
            // 
            // labelCodeAdvertisement
            // 
            this.labelCodeAdvertisement.AutoSize = true;
            this.labelCodeAdvertisement.Location = new System.Drawing.Point(19, 22);
            this.labelCodeAdvertisement.Name = "labelCodeAdvertisement";
            this.labelCodeAdvertisement.Size = new System.Drawing.Size(74, 13);
            this.labelCodeAdvertisement.TabIndex = 39;
            this.labelCodeAdvertisement.Text = "код рекламы";
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
            this.advertisement.ResumeLayout(false);
            this.advertisement.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxNameTelecastA;
        private System.Windows.Forms.Button buttonDeleteAdvertisement;
        private System.Windows.Forms.Button buttonNewAdvertisement;
        private System.Windows.Forms.Button buttonCancelEditAdvertisement;
        private System.Windows.Forms.Button buttonSaveEditAdvertisement;
        private System.Windows.Forms.Button buttonEditAdvertisement;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.Label labelNameTelecastA;
        private System.Windows.Forms.ComboBox comboBoxCodeAdvertisement;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelCodeAdvertisement;
        private System.Windows.Forms.ComboBox comboBoxNameAgentA;
        private System.Windows.Forms.Label labelNameAgentA;
        private System.Windows.Forms.ComboBox comboBoxNameCustomerA;
        private System.Windows.Forms.Label labelNameCustomerA;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.TextBox textBoxSurnameAgent;
        private System.Windows.Forms.TextBox textBoxNameCustomer;
        private System.Windows.Forms.TextBox textBoxNameTelecast;

    }
}

