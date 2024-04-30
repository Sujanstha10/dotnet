using System;
using MySql.Data.MySqlClient;
class CRUD
{
    void Connection()
    {
        string connstr = "server=localhost;Database=db;Uid=crud;Password=asdf";
        conn = new MySqlConnection(connstr);
        conn.Open();
    }


    void ExecuteQuery(string query)
    {
        try
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("inserted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine("error occured" + ex);
        }
        finally
        {
            conn.Close();
        }
    }
    void Insert()
    {
        string acc_num;
        string address;
        string name;

        Console.WriteLine("enter account number");
        acc_num = Console.ReadLine();
        Console.WriteLine("enter account holder name");
        name = Console.ReadLine();
        Console.WriteLine("enter account holder address");
        address = Console.ReadLine();
        string query = "insert into table accounts (acc_num,name,address) values (acc_num,name,address)";
        ExecuteQuery(query);
    }
    void Delete()
    {
        Console.WriteLine("enter id to delete");
        int id = Convert.ToInt32(Console.ReadLine());
        string query = "delete from table account where id = " + id;
        ExecuteQuery(query);
    }

    void Update()
    {
        string acc_num;
        string address;
        string name;
        int id;

        Console.WriteLine("enter id to be updated");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter account number");
        acc_num = Console.ReadLine();
        Console.WriteLine("enter account holder name");
        name = Console.ReadLine();
        Console.WriteLine("enter account holder address");
        address = Console.ReadLine();
        string query = "update table account set name="name",address="address",acc_num="acc_num"where id =" + id;
        ExecuteQuery(query);

    }
    void Read()
    {
        try
        {
            Console.WriteLine("\nAccounts:");

            string query = "SELECT * FROM accounts";
            ExecuteQuery(query);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(reader["id"] + "\t" + reader["acc_num"] + "\t" + reader["name"] + "\t" + reader["address"]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while reading data: " + ex.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    public static void main(string[] args)
    {
        try
        {
            CRUD crud = new CRUD();
            CRUD.Connection();
            Console.WriteLine("enter your choice 1.insert,2.read,3.update,4.delete");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    crud.Insert();
                    break;
                case "2":
                    crud.Read();
                    break;
                case "3":
                    crud.Update();
                    break;
                case "4":
                    crud.Delete();
                    break;
            }
        }
    }
}