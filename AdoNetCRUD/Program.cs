using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

public  class Program  
{  
    static string connectionString = "server=(localdb)\\MSSQLLOCALDB; Initial Catalog = EmployeeDB1; Integrated Security = SSPI";
    public  static void Main(string[] args)
    {
       

        SqlConnection connection = new SqlConnection(connectionString);
        //string Create = "Create table Employeess(EmployeeId int primary key identity(1,1),Name varchar(50),Address varchar(20),Salary decimal(10,2),JoinDate Date,City varchar(20) );";
        //SqlCommand command = new SqlCommand(Create, connection);
        //connection.Open();
        //command.ExecuteNonQuery();
        //Console.WriteLine("successfully table is created");

        //string InsertTables = @"insert into Employeess values ('saikat' , 'bangalore', 70000.00 , null,'bangalore'); ";

        //SqlCommand command = new SqlCommand(InsertTables, connection);
        //connection.Open();
        //command.ExecuteNonQuery();
        //Console.WriteLine("successfully inserted into table ");

        //string InsertTables = @"insert into Employeess values ('saikat' , 'bangalore', 70000.00 , null,'bangalore'); ";


        string UpdateTables = @"update Employeess set Name='sai' where EmployeeId = 1  ";

        SqlCommand command = new SqlCommand(UpdateTables, connection);
        connection.Open();
        command.ExecuteNonQuery();
        Console.WriteLine("successfully updated the value ");
        //string display = "select * from Employee1";
        //SqlCommand cmd = new SqlCommand(display, connection );
        //connection.Open();
        //SqlDataReader reader = cmd.ExecuteReader();


        //while (reader.Read())
        //{
        //    Console.WriteLine($" Id : {reader["EmployeeId"]},Name :{reader["Name"]},Address : {reader["Address"]},Salary : {reader["Salary"]},Joindate: {reader["JoinDate"]},City : {reader["City"]}");

        //}
        //    string deleteData = "delete Employeess where EmployeeId = @ID";
        //SqlCommand sqlCommand = new(deleteData, connection);
        //connection.Open();
        //sqlCommand.Parameters.AddWithValue("@ID", 1);
        //sqlCommand.ExecuteNonQuery();
        //Console.WriteLine("Deleted!");


        connection.Close(); 


    }
}