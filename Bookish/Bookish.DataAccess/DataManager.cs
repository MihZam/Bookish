using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Dapper;

namespace Bookish.DataAccess
{
    public class DataManager
    {
        private string connectionString = "Server=intdansir;Database=testDB;Integrated Security=True";
        private SqlConnection db;
        
        public DataManager()
        {
            db = new SqlConnection(connectionString);
            db.Open();
        }
        
        public List<Book> GetAllBooks()
        {
            string selectAllBooks = "SELECT TOP (1) [BookName] FROM [testDB].[dbo].[Books]";
            //SqlCommand cmd = new SqlCommand(selectAllBooks, db);
            //SqlDataReader dataReader = cmd.ExecuteReader();
            
            var bookList = db.Query<Book>(selectAllBooks);
            return (List<Book>)db.Query<Book>(selectAllBooks);
        }
    }
}