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

            connectionString = "provider=Microsoft.Jet.OLEDB.4.0;" + "data source=C:\\DB\\DB.mdb";
            connection = new OleDbConnection(connectionString);
            command = connection.CreateCommand();
        }

        private void tabSwitch_Selecting(object sender, TabControlCancelEventArgs e)
        {
            string nameNewPage = e.TabPage.Name;
            if (nameNewPage == this.customers.Name)
            {

            }
            else if (nameNewPage == this.telecasts.Name)
            {

            }
            else if (nameNewPage == this.agents.Name)
            {
                this.textBoxNameAgent.ReadOnly = true;
                this.textBoxPatronymic.ReadOnly = true;
                this.writeInComboBoxSurnameAgent();
            }
            else if (nameNewPage == this.advertisement.Name)
            {

            }

        }

        private void writeInComboBoxSurnameAgent()
        {
            this.comboBoxSurnameAgent.Items.Clear();
            this.connection.Open();
            this.command.CommandText = "SELECT фамилия " + "FROM агенты ";
            this.reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.comboBoxSurnameAgent.Items.Add(this.reader["фамилия"]);
            }
            reader.Close();
            this.connection.Close();
            this.comboBoxSurnameAgent.Text = Convert.ToString(this.comboBoxSurnameAgent.Items[0]);
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
                    this.add = false;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Новый агент добавлен");
                }

                this.connection.Close();
                this.writeInComboBoxSurnameAgent();
            }
            else
            {
                MessageBox.Show("фамилия и имя должны быть обязательно");
            }
        }

        private void buttonCancelEditAgent_Click(object sender, EventArgs e)
        {
            if (this.edit)
                this.buttonEditAgent_Click();
            else
                this.buttonNewAgent_Click();
            this.writeInComboBoxSurnameAgent();
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
                this.writeInComboBoxSurnameAgent();
            }

        }

    }

}
