using System;
using MySql.Data.MySqlClient;
class CRUD{
    void Connection(){
        string connstr = "server=localhost;Database=db;Uid=crud;Password=asdf";
        conn = new MySqlConnection(connstr);
        conn.Open();
    }

    void insert(){
        string acc_num;
        string address;
        string name;
        Console.WriteLine("enter account number");
        acc_num = Console.ReadLine();
        Console.WriteLine("enter account holder name");
        name = Console.ReadLine();
        Console.WriteLine("enter account holder address");
        address = Console.ReadLine();
        try{
        string query = "insert into table accounts (acc_num,name,address) values (acc_num,name,address)";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        cmd.ExecuteNonQuery();
        Console.WriteLine("inserted successfully");        
        }catch(Exception ex){
            Console.WriteLine("error occured"ex);
        }finally
        {
            conn.Close();
        }
    }

    public static void main(string[] args){

        try{
        CRUD crud = new CRUD();
        CRUD.Connection();
        Console.WriteLine("enter your choice 1.insert,2.read,3.update,4.delete");
        string choice = Console.ReadLine();
        switch(choice){
            case "1":   
        crud.Insert();
        break;
        }
        }
    }
}