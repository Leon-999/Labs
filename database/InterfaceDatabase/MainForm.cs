using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace InterfaceDatabase
{
    public partial class MainForm : Form
    {
        string connectionString;
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataReader reader;
        int codeAlterable;
        bool edit = false;
        bool add = false;

        public MainForm()
        {
            InitializeComponent();

            connectionString = "provider=Microsoft.Jet.OLEDB.4.0;" + "data source = database\\DB.mdb";
            connection = new OleDbConnection(connectionString);
            command = connection.CreateCommand();

            this.tabSwitch_Selecting();
        }

        private void tabSwitch_Selecting(object sender = null, TabControlCancelEventArgs e = null)
        {
            string nameNewPage;
            if (e != null)
                nameNewPage = e.TabPage.Name;
            else
                nameNewPage = this.customers.Name;

            if (nameNewPage == this.customers.Name)
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.writeInComboBoxNameFirm(this.comboBoxNameFirm);
            }
            else if (nameNewPage == this.telecasts.Name)
            {
                this.textBoxRating.ReadOnly = true;
                this.textBoxСostMinute.ReadOnly = true;
                this.writeInComboBoxNameTelecast(this.comboBoxNameTelecast);
            }
            else if (nameNewPage == this.agents.Name)
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.writeInComboBoxSurnameAgent(this.comboBoxSurnameAgent);
            }
            else if (nameNewPage == this.advertisement.Name)
            {
                this.comboBoxNameTelecastA.Visible = false;
                this.comboBoxNameCustomerA.Visible = false;
                this.comboBoxNameAgentA.Visible = false;
                this.textBoxNameTelecast.Visible = true;
                this.textBoxNameCustomer.Visible = true;
                this.textBoxSurnameAgent.Visible = true;
                this.textBoxData.ReadOnly = true;
                this.textBoxLenght.ReadOnly = true;
                this.textBoxNameTelecast.ReadOnly = true;
                this.textBoxNameCustomer.ReadOnly = true;
                this.textBoxSurnameAgent.ReadOnly = true;
                this.writeInComboBoxCodeAdvertisement();
            }

        }

        private void writeInComboBoxSurnameAgent(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT фамилия " + "FROM агенты ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(this.reader["фамилия"]);
            }
            reader.Close();
            this.connection.Close();
            comboBox.Text = Convert.ToString(comboBox.Items[0]);
        }

        private void comboBoxSurnameAgent_TextChanged(object sender, EventArgs e)
        {
            string selected = "'" + this.comboBoxSurnameAgent.Text + "'";
            this.connection.Open();
            this.command.CommandText = "SELECT код_агента, имя, отчество " + "FROM агенты " + "WHERE фамилия = " + selected;
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBoxNameAgent.Text = Convert.ToString(this.reader["имя"]);
                this.textBoxPatronymic.Text = Convert.ToString(this.reader["отчество"]);
                this.codeAlterable = (int)this.reader["код_агента"];
            }
            reader.Close();
            this.connection.Close();
        }

        private void buttonEditAgent_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxNameAgent.ReadOnly = false;
                this.textBoxPatronymic.ReadOnly = false;
                this.edit = true;
                this.buttonSaveAgent.Enabled = true;
                this.buttonCancelEditAgent.Enabled = true;
            }
            else
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.edit = false;
                this.buttonSaveAgent.Enabled = false;
                this.buttonCancelEditAgent.Enabled = false;
            }
            this.add = false;
        }


        private void buttonNewAgent_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxSurnameAgent.Text = "";
                this.textBoxNameAgent.ReadOnly = false;
                this.textBoxNameAgent.Text = "";
                this.textBoxPatronymic.ReadOnly = false;
                this.textBoxPatronymic.Text = "";
                this.add = true;
                this.buttonSaveAgent.Enabled = true;
                this.buttonCancelEditAgent.Enabled = true;
            }
            else
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.add = false;
                this.buttonSaveAgent.Enabled = false;
                this.buttonCancelEditAgent.Enabled = false;
            }
            this.edit = false;
        }

        private void buttonSaveAgent_Click(object sender, EventArgs e)
        {
            string newSurname = "'" + this.comboBoxSurnameAgent.Text + "'";
            string newName = "'" + this.textBoxNameAgent.Text + "'";
            string newPatronymic = "'" + this.textBoxPatronymic.Text + "'";
            if (newSurname != "''" && newName != "''")
            {
                this.connection.Open();
                if (this.edit)
                {
                    this.command.CommandText = "UPDATE агенты SET фамилия = " + newSurname +
                                               ", имя = " + newName +
                                               ", отчество = " + newPatronymic +
                                               " WHERE код_агента = " + this.codeAlterable;
                    this.buttonEditAgent_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                }
                else if(this.add)
                {
                    this.command.CommandText = "INSERT INTO агенты (фамилия, имя, отчество) VALUES (" + newSurname +
                                               ", " + newName +
                                               ", " + newPatronymic +")";
                    this.buttonNewAgent_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый агент добавлен");
                }

                this.connection.Close();
                this.writeInComboBoxSurnameAgent(this.comboBoxSurnameAgent);
            }
            else
            {
                MessageBox.Show("фамилия и имя должны быть обязательно заполнены");
            }
        }

        private void buttonCancelEditAgent_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditAgent_Click();
            if(this.add)
                this.buttonNewAgent_Click();
            this.writeInComboBoxSurnameAgent(this.comboBoxSurnameAgent);
        }

        private void buttonDeleteAgent_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM агенты WHERE (код_агента = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Агент удалён");
                this.connection.Close();
                this.writeInComboBoxSurnameAgent(this.comboBoxSurnameAgent);
            }

        }

        private void writeInComboBoxNameFirm(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT название " + "FROM заказчики ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(this.reader["название"]);
            }
            reader.Close();
            this.connection.Close();
            comboBox.Text = Convert.ToString(comboBox.Items[0]);
        }

        private void comboBoxNameFirm_TextChanged(object sender, EventArgs e)
        {
            string selected = "'" + this.comboBoxNameFirm.Text + "'";
            this.connection.Open();
            this.command.CommandText = "SELECT код_заказчика, название, банковские_реквизиты, телефон, контактное_лицо " + 
                                       "FROM заказчики " + 
                                       "WHERE название = " + selected;
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBoxRequisites.Text = Convert.ToString(this.reader["банковские_реквизиты"]);
                this.textBoxTelephone.Text = Convert.ToString(this.reader["телефон"]);
                this.textBoxContact.Text = Convert.ToString(this.reader["контактное_лицо"]);
                this.codeAlterable = (int)this.reader["код_заказчика"];
            }
            reader.Close();
            this.connection.Close();
        }

        private void buttonEditCustomer_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxRequisites.ReadOnly = false;
                this.textBoxTelephone.ReadOnly = false;
                this.textBoxContact.ReadOnly = false;
                this.edit = true;
                this.buttonSaveCustomer.Enabled = true;
                this.buttonCancelEditCustomer.Enabled = true;
            }
            else
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.edit = false;
                this.buttonSaveCustomer.Enabled = false;
                this.buttonCancelEditCustomer.Enabled = false;
            }
            this.add = false;
        }

        private void buttonNewCustomer_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxNameFirm.Text = "";
                this.textBoxRequisites.ReadOnly = false;
                this.textBoxRequisites.Text = "";
                this.textBoxTelephone.ReadOnly = false;
                this.textBoxTelephone.Text = "";
                this.textBoxContact.ReadOnly = false;
                this.textBoxContact.Text = "";
                this.add = true;
                this.buttonSaveCustomer.Enabled = true;
                this.buttonCancelEditCustomer.Enabled = true;
            }
            else
            {
                this.textBoxRequisites.ReadOnly = true;
                this.textBoxTelephone.ReadOnly = true;
                this.textBoxContact.ReadOnly = true;
                this.add = false;
                this.buttonSaveCustomer.Enabled = false;
                this.buttonCancelEditCustomer.Enabled = false;
            }
            this.edit = false;
        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            string newName = "'" + this.comboBoxNameFirm.Text + "'";
            string newRequisites = "'" + this.textBoxRequisites.Text + "'";
            string newTelephone = "'" + this.textBoxTelephone.Text + "'";
            string newContact = "'" + this.textBoxContact.Text + "'";
            if (newName != "''" && newRequisites != "''" && newTelephone != "''" && newContact != "''")
            {
                this.connection.Open();
                if (this.edit)
                {
                    this.command.CommandText = "UPDATE заказчики SET название = " + newName +
                                               ", банковские_реквизиты = " + newRequisites +
                                               ", телефон = " + newTelephone +
                                               ", контактное_лицо = " + newContact +
                                               " WHERE код_заказчика = " + this.codeAlterable;
                    this.buttonEditCustomer_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                }
                else if (this.add)
                {
                    this.command.CommandText = "INSERT INTO заказчики (название, банковские_реквизиты, телефон, контактное_лицо) VALUES (" + 
                                               newName +
                                               ", " + newRequisites +
                                               ", " + newTelephone +
                                               ", " + newContact + ")";
                    this.buttonNewCustomer_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый заказчик добавлен");
                }

                this.connection.Close();
                this.writeInComboBoxNameFirm(this.comboBoxNameFirm);
            }
            else
            {
                MessageBox.Show("все поля должны быть обязательно заполнены");
            }
        }

        private void buttonCancelEditCustomer_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditCustomer_Click();
            if (this.add)
                this.buttonNewCustomer_Click();
            this.writeInComboBoxNameFirm(this.comboBoxNameFirm);
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM заказчики WHERE (код_заказчика = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Заказчик удалён");
                this.connection.Close();
                this.writeInComboBoxNameFirm(this.comboBoxNameFirm);
            }
        }

        private void writeInComboBoxNameTelecast(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT название " + "FROM передачи ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(this.reader["название"]);
            }
            reader.Close();
            this.connection.Close();
            comboBox.Text = Convert.ToString(comboBox.Items[0]);
        }

        private void comboBoxNameTelecast_TextChanged(object sender, EventArgs e)
        {
            string selected = "'" + this.comboBoxNameTelecast.Text + "'";
            this.connection.Open();
            this.command.CommandText = "SELECT код_передачи, название, рейтинг, стоимость_минуты " +
                                       "FROM передачи " +
                                       "WHERE название = " + selected;
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.textBoxRating.Text = Convert.ToString(this.reader["рейтинг"]);
                this.textBoxСostMinute.Text = Convert.ToString(this.reader["стоимость_минуты"]);
                this.codeAlterable = (int)this.reader["код_передачи"];
            }
            reader.Close();
            this.connection.Close();
        }

        private void buttonEditTelecast_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxRating.ReadOnly = false;
                this.textBoxСostMinute.ReadOnly = false;
                this.edit = true;
                this.buttonSaveEditTelecast.Enabled = true;
                this.buttonCancelEditTelecast.Enabled = true;
            }
            else
            {
                this.textBoxRating.ReadOnly = true;
                this.textBoxСostMinute.ReadOnly = true;
                this.edit = false;
                this.buttonSaveEditTelecast.Enabled = false;
                this.buttonCancelEditTelecast.Enabled = false;
            }
            this.add = false;
        }

        private void buttonNewTelecast_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxNameTelecast.Text = "";
                this.textBoxRating.ReadOnly = false;
                this.textBoxRating.Text = "";
                this.textBoxСostMinute.ReadOnly = false;
                this.textBoxСostMinute.Text = "";
                this.add = true;

                this.buttonSaveEditTelecast.Enabled = true;
                this.buttonCancelEditTelecast.Enabled = true;
            }
            else
            {
                this.textBoxRating.ReadOnly = true;
                this.textBoxСostMinute.ReadOnly = true;
                this.add = false;
                this.buttonSaveEditTelecast.Enabled = false;
                this.buttonCancelEditTelecast.Enabled = false;
            }
            this.edit = false;
        }

        private void buttonSaveEditTelecast_Click(object sender, EventArgs e)
        {
            string newName = "'" + this.comboBoxNameTelecast.Text + "'";
            string newRating = "'" + this.textBoxRating.Text + "'";
            string newCostMinute = "'" + this.textBoxСostMinute.Text + "'";
            if (newName != "''" && newRating != "''" && newCostMinute != "''")
            {
                this.connection.Open();
                if (this.edit)
                {
                    this.command.CommandText = "UPDATE передачи SET название = " + newName +
                                               ", рейтинг = " + newRating +
                                               ", стоимость_минуты = " + newCostMinute +
                                               " WHERE код_передачи = " + this.codeAlterable;
                    this.buttonEditTelecast_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                }
                else if (this.add)
                {
                    this.command.CommandText = "INSERT INTO передачи (название, рейтинг, стоимость_минуты) VALUES (" +
                                               newName +
                                               ", " + newRating +
                                               ", " + newCostMinute + ")";
                    this.buttonNewTelecast_Click();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новая передача добавлена");
                }

                this.connection.Close();
                this.writeInComboBoxNameTelecast(this.comboBoxNameTelecast);
            }
            else
            {
                MessageBox.Show("все поля должны быть обязательно заполнены");
            }
        }

        private void buttonCancelEditTelecast_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditTelecast_Click();
            if (this.add)
                this.buttonNewTelecast_Click();
            this.writeInComboBoxNameTelecast(this.comboBoxNameTelecast);
        }

        private void buttonDeleteTelecast_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM передачи WHERE (код_передачи = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Передача удалёна");
                this.connection.Close();
                this.writeInComboBoxNameTelecast(this.comboBoxNameTelecast);
            }
        }


        private void writeInComboBoxCodeAdvertisement()
        {
            this.comboBoxCodeAdvertisement.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT код_рекламы " + "FROM реклама ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.comboBoxCodeAdvertisement.Items.Add(this.reader["код_рекламы"]);
            }
            reader.Close();
            this.connection.Close();
            this.comboBoxCodeAdvertisement.Text = Convert.ToString(this.comboBoxCodeAdvertisement.Items[0]);
        }

        private void comboBoxCodeAdvertisement_TextChanged(object sender, EventArgs e)
        {
            int codeTelecast = 0;
            int codeCustomer = 0;
            int codeAgent = 0;
            string selected = "-1";

            if(this.comboBoxCodeAdvertisement.Text != "")
                selected = this.comboBoxCodeAdvertisement.Text;

            this.connection.Open();
            this.command.CommandText = "SELECT код_рекламы, код_передачи, код_заказчика, код_агента, left(дата,10) as дата, длительность_в_минутах " +
                                       "FROM реклама " +
                                       "WHERE код_рекламы = " + selected;
            this.reader = command.ExecuteReader();
            while (this.reader.Read())
            {
                this.textBoxData.Text = Convert.ToString(this.reader["дата"]);
                this.textBoxLenght.Text = Convert.ToString(this.reader["длительность_в_минутах"]);
                this.codeAlterable = (int)this.reader["код_рекламы"];

                codeTelecast = (int)this.reader["код_передачи"];
                codeCustomer = (int)this.reader["код_заказчика"];
                codeAgent = (int)this.reader["код_агента"];
            }
            reader.Close();

            this.command.CommandText = "SELECT название " +
                                       "FROM передачи " +
                                       "WHERE код_передачи = " + codeTelecast;
            this.reader = command.ExecuteReader();
            if (this.reader.Read())
                this.textBoxNameTelecast.Text = Convert.ToString(this.reader["название"]);
            this.reader.Close();

            this.command.CommandText = "SELECT название " +
                                       "FROM заказчики " +
                                       "WHERE код_заказчика = " + codeCustomer;
            this.reader = command.ExecuteReader();
            if(this.reader.Read())
                this.textBoxNameCustomer.Text = Convert.ToString(this.reader["название"]);
            this.reader.Close();

            this.command.CommandText = "SELECT фамилия " +
                                       "FROM агенты " +
                                       "WHERE код_агента = " + codeAgent;
            this.reader = command.ExecuteReader();
            if(this.reader.Read())
                this.textBoxSurnameAgent.Text = Convert.ToString(this.reader["фамилия"]);
            this.reader.Close();

            this.connection.Close();
        }

        private void buttonEditAdvertisement_Click(object sender = null, EventArgs e = null)
        {
            if (this.edit == false)
            {
                this.textBoxData.ReadOnly = false;
                this.textBoxLenght.ReadOnly = false;
                this.edit = true;
                this.buttonSaveEditAdvertisement.Enabled = true;
                this.buttonCancelEditAdvertisement.Enabled = true;

                this.writeInComboBoxSurnameAgent(this.comboBoxNameAgentA);
                this.writeInComboBoxNameTelecast(this.comboBoxNameTelecastA);
                this.writeInComboBoxNameFirm(this.comboBoxNameCustomerA);

                this.comboBoxNameTelecastA.Text = this.textBoxNameTelecast.Text;
                this.comboBoxNameCustomerA.Text = this.textBoxNameCustomer.Text;
                this.comboBoxNameAgentA.Text = this.textBoxSurnameAgent.Text;

                this.textBoxSurnameAgent.Visible = false;
                this.textBoxNameCustomer.Visible = false;
                this.textBoxNameTelecast.Visible = false;

                this.comboBoxNameTelecastA.Visible = true;
                this.comboBoxNameCustomerA.Visible = true;
                this.comboBoxNameAgentA.Visible = true;
            }
            else
            {
                this.textBoxData.ReadOnly = true;
                this.textBoxLenght.ReadOnly = true;
                this.edit = false;
                this.buttonSaveEditAdvertisement.Enabled = false;
                this.buttonCancelEditAdvertisement.Enabled = false;

                this.textBoxSurnameAgent.Visible = true;
                this.textBoxNameCustomer.Visible = true;
                this.textBoxNameTelecast.Visible = true;
                this.comboBoxNameTelecastA.Visible = false;
                this.comboBoxNameCustomerA.Visible = false;
                this.comboBoxNameAgentA.Visible = false;
            }
            this.add = false;
        }

        private void buttonNewAdvertisement_Click(object sender = null, EventArgs e = null)
        {
            if (this.add == false)
            {
                this.comboBoxCodeAdvertisement.Enabled = false;
                this.comboBoxCodeAdvertisement.Text = "";
                this.textBoxData.ReadOnly = false;
                this.textBoxData.Text = "";
                this.textBoxLenght.ReadOnly = false;
                this.textBoxLenght.Text = "";
                this.add = true;
                this.buttonSaveEditAdvertisement.Enabled = true;
                this.buttonCancelEditAdvertisement.Enabled = true;

                this.writeInComboBoxSurnameAgent(this.comboBoxNameAgentA);
                this.writeInComboBoxNameTelecast(this.comboBoxNameTelecastA);
                this.writeInComboBoxNameFirm(this.comboBoxNameCustomerA);

                this.comboBoxNameTelecastA.Text = "";
                this.comboBoxNameCustomerA.Text = "";
                this.comboBoxNameAgentA.Text = "";

                this.textBoxSurnameAgent.Visible = false;
                this.textBoxNameCustomer.Visible = false;
                this.textBoxNameTelecast.Visible = false;

                this.comboBoxNameTelecastA.Visible = true;
                this.comboBoxNameCustomerA.Visible = true;
                this.comboBoxNameAgentA.Visible = true;
            }
            else
            {
                this.comboBoxCodeAdvertisement.Enabled = true;
                this.textBoxData.ReadOnly = true;
                this.textBoxLenght.ReadOnly = true;
                this.add = false;
                this.buttonSaveEditAdvertisement.Enabled = false;
                this.buttonCancelEditAdvertisement.Enabled = false;

                this.textBoxSurnameAgent.Visible = true;
                this.textBoxNameCustomer.Visible = true;
                this.textBoxNameTelecast.Visible = true;
                this.comboBoxNameTelecastA.Visible = false;
                this.comboBoxNameCustomerA.Visible = false;
                this.comboBoxNameAgentA.Visible = false;
            }
            this.edit = false;
        }

        private void buttonSaveEditAdvertisement_Click(object sender, EventArgs e)
        {
            string newNameTelecast = "'" + this.comboBoxNameTelecastA.Text + "'";
            string newNameCustomer = "'" + this.comboBoxNameCustomerA.Text + "'";
            string newNameAgent = "'" + this.comboBoxNameAgentA.Text + "'";
            string newData = "'" + Convert.ToDateTime(this.textBoxData.Text) + "'";
            string newLenght = "'" + this.textBoxLenght.Text + "'";
            if (newNameTelecast != "''" && newNameCustomer != "''" && newNameAgent != "''" && newData != null && newLenght != "''")
            {
                this.connection.Open();

                int codeTelecast = 0;
                int codeCustomer = 0;
                int codeAgent = 0;

                this.command.CommandText = "SELECT код_передачи " +
                                       "FROM передачи " +
                                       "WHERE название = " + newNameTelecast;
                this.reader = command.ExecuteReader();
                if (this.reader.Read())
                    codeTelecast = (int)this.reader["код_передачи"];
                this.reader.Close();

                this.command.CommandText = "SELECT код_заказчика " +
                                       "FROM заказчики " +
                                       "WHERE название = " + newNameCustomer;
                this.reader = command.ExecuteReader();
                if (this.reader.Read())
                    codeCustomer = (int)this.reader["код_заказчика"];
                this.reader.Close();

                this.command.CommandText = "SELECT код_агента " +
                                       "FROM агенты " +
                                       "WHERE фамилия = " + newNameAgent;
                this.reader = command.ExecuteReader();
                if (this.reader.Read())
                    codeAgent = (int)this.reader["код_агента"];
                this.reader.Close();

                if (this.edit)
                {
                    this.command.CommandText = "UPDATE реклама SET код_передачи = " + codeTelecast +
                                               ", код_заказчика = " + codeCustomer +
                                               ", код_агента = " + codeAgent +
                                               ", дата = " + newData +
                                               ", длительность_в_минутах = " + newLenght +
                                               " WHERE код_рекламы = " + this.codeAlterable;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новые данные сохранены");
                    this.connection.Close();
                    this.buttonEditAdvertisement_Click();
                }
                else if (this.add)
                {
                    this.command.CommandText = "INSERT INTO реклама (код_передачи, код_заказчика, код_агента, дата, длительность_в_минутах) VALUES (" +
                                               codeTelecast +
                                               ", " + codeCustomer +
                                               ", " + codeAgent +
                                               ", " + newData +
                                               ", " + newLenght + ")";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новая реклама добавлена");
                    this.connection.Close();
                    this.buttonNewAdvertisement_Click();
                }

                this.writeInComboBoxCodeAdvertisement();
            }
            else
            {
                MessageBox.Show("все поля должны быть обязательно заполнены");
            }
        }

        private void buttonCancelEditAdvertisement_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditAdvertisement_Click();
            if (this.add)
                this.buttonNewAdvertisement_Click();
            this.writeInComboBoxCodeAdvertisement();
        }

        private void buttonDeleteAdvertisement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.connection.Open();

                this.command.CommandText = "DELETE FROM реклама WHERE (код_рекламы = " + this.codeAlterable + ")";
                command.ExecuteNonQuery();

                MessageBox.Show("Реклама удалёна");
                this.connection.Close();
                this.writeInComboBoxCodeAdvertisement();
            }
        }
    }

}
