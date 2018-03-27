using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Beauty
{
    public static class DatabaseHelper
    {
        private static OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.mdb");

        public static DataTable getMasterDataSource()
        {
            return getDataTableByQuery("SELECT `id`, `number` as Номер, (`secondName` & ' ' & `firstName` & ' ' & `patronymic`) as ФИО, `experience` as Стаж, `position` as Должность FROM masters"); //id, number, (secondName & ' ' & firstName & ' ' & patronymic) as ФИО, experience, position 
        }

        public static DataTable getClientDataSource()
        {
            return getDataTableByQuery("SELECT `id`, `number` as Номер, (`secondName` & ' ' & `firstName` & ' ' & `patronymic`) as ФИО, `phone` as Телефон, `age` as Возраст FROM clients");
        }

        public static DataTable getEntriesDataSource()
        {
            return getDataTableByQuery("SELECT `id`, (SELECT (`secondName` & ' ' & `firstName` & ' ' & `patronymic`) FROM `masters` WHERE `id` = `id_master`) as Мастер, (SELECT (`secondName` & ' ' & `firstName` & ' ' & `patronymic`) FROM `clients` WHERE `id` = `id_client`) as Клиент, `date` as Дата, `time` as Время, `price` as Стоимость FROM `entries`");
        }

        private static DataTable getDataTableByQuery(string query)
        {
            DataTable dataTable = new DataTable();

            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);

            oleDbConnection.Open();

            oleDbCommand.ExecuteNonQuery();
            oleDbDataAdapter.Fill(dataTable);

            oleDbConnection.Close();

            return dataTable;
        }

        public static bool addNewMaster(Master master)
        {
            return addByQuery($"INSERT INTO masters (`id`, `number`, `secondName`, `firstName`, `patronymic`, `experience`, `position`) VALUES ({master.id}, {master.number}, '{master.secondName}', '{master.firstName}', '{master.patronymic}', {master.experience}, '{master.position}');");
        }

        public static bool addNewClient(Client client)
        {
            return addByQuery($"INSERT INTO clients (`id`, `number`, `secondName`, `firstName`, `patronymic`, `phone`, `age`) VALUES ({ client.id }, { client.number }, '{ client.secondName }','{ client.firstName }','{ client.patronymic }','{ client.phone }', { client.age });");
        }

        private static bool addByQuery(string query)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

            try
            {
                oleDbConnection.Open();
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public static int getClientId()
        {
            return getId("SELECT MAX(id) FROM clients");
        }

        public static int getMasterId()
        {
            return getId("SELECT MAX(id) FROM masters");
        }

        private static int getId(string query)
        {
            int id = 0;

            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

            oleDbConnection.Open();

            using (OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader())
            {
                while (oleDbDataReader.Read()){
                    try
                    {
                        id = Convert.ToInt32(oleDbDataReader[0]);
                    }
                    catch(InvalidCastException e)
                    {
                        id = -1;
                    }  
                }
            }

            oleDbConnection.Close();

            return id+1;
        }

        public static List<Master> getMasters()
        {
            List<Master> masters = new List<Master>();

            OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM masters", oleDbConnection);

            oleDbConnection.Open();

            using (OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader())
            {
                while (oleDbDataReader.Read())
                {
                    Master master = new Master();
                    master.id = Convert.ToInt32(oleDbDataReader[0]);
                    master.number = Convert.ToInt32(oleDbDataReader[1]);
                    master.secondName = oleDbDataReader[2].ToString();
                    master.firstName = oleDbDataReader[3].ToString();
                    master.patronymic = oleDbDataReader[4].ToString();
                    master.experience = Convert.ToInt32(oleDbDataReader[5].ToString());
                    master.position = oleDbDataReader[6].ToString();
                    masters.Add(master);
                }
            }

            oleDbConnection.Close();

            return masters;
        }

        public static List<Client> getClients()
        {
            List<Client> clients = new List<Client>();

            OleDbCommand oleDbCommand = new OleDbCommand("SELECT * FROM clients", oleDbConnection);

            oleDbConnection.Open();

            using (OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader())
            {
                while (oleDbDataReader.Read())
                {
                    Client client = new Client();
                    client.id = Convert.ToInt32(oleDbDataReader[0]);
                    client.number = Convert.ToInt32(oleDbDataReader[1]);
                    client.secondName = oleDbDataReader[2].ToString();
                    client.firstName = oleDbDataReader[3].ToString();
                    client.patronymic = oleDbDataReader[4].ToString();
                    client.phone = oleDbDataReader[5].ToString();
                    client.age = Convert.ToInt32(oleDbDataReader[6]);
                    clients.Add(client);
                }
            }

            oleDbConnection.Close();

            return clients;
        }

        public static void deleteMaster(Master master)
        {
            delete($"DELETE FROM masters WHERE id = {master.id}");
        }

        public static void deleteClient(Client client)
        {
            delete($"DELETE FROM clients WHERE id = {client.id}");
        }

        public static void deleteEntry(string id)
        {
            delete($"DELETE FROM entries WHERE id = { id }");
        }

        private static void delete(string query)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        public static void editMaster(Master master)
        {
            edit($"UPDATE masters SET `secondName` = '{ master.secondName }', `firstName` = '{ master.firstName }', `patronymic` = '{ master.patronymic }', `experience` = '{ master.experience }', `position` = '{ master.position }' WHERE id = {master.id}");
        }

        public static void editClient(Client client)
        {
            edit($"UPDATE clients SET `secondName` = '{ client.secondName }', `firstName` = '{ client.firstName }', `patronymic` = '{ client.patronymic }', `phone` = '{ client.phone }', `age` = { client.age } WHERE id = { client.id }");
        }

        private static void edit(string query)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);

            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        public static bool CheckUniqueNumberClient(int number)
        {
            return checkUnique("masters", number);
        }

        public static bool CheckUniqueNumberMaster(int number)
        {
            return checkUnique("clients", number);
        }

        private static bool checkUnique(string table, int number)
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"SELECT number FROM { table } WHERE number = { number }", oleDbConnection);

            oleDbConnection.Open();

            using (OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader())
            {
                while (oleDbDataReader.Read())
                {
                    oleDbConnection.Close();
                    return false;
                }
            }

            oleDbConnection.Close();

            return true;
        }

        public static void addEntry(Entry entry)
        {
            int id = DatabaseHelper.getId("SELECT MAX(id) FROM entries");
            OleDbCommand oleDbCommand = new OleDbCommand($"INSERT INTO entries(`id`,`id_master`, `id_client`, `date`, `time`, `price`) VALUES ({ id }, {entry.master.id}, {entry.client.id}, '{ entry.date }', '{ entry.time }', { entry.price }) ", oleDbConnection);
            MessageBox.Show(oleDbCommand.CommandText);
            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }
    }
}
