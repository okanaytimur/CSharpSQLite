
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite; //SQL Connector
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;  
using Microsoft.Office.Interop.Excel;
using IronXL;

namespace yeni;

public partial class Form1 : Form{
        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;
   
    private void insertad(){
            
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Student(FirstName,LastName) values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
         }
private void updateTablo()
{
 con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
 for (int item=0;item<dataGridView1.Rows.Count-1;item++){
 
cmd=new SQLiteCommand("UPDATE Student SET FirstName=@firstname, LastName=@lastname WHERE id=@id",con);
cmd.Parameters.AddWithValue("@firstname",dataGridView1.Rows[item].Cells[1].Value);
cmd.Parameters.AddWithValue("@lastname",dataGridView1.Rows[item].Cells[2].Value);
cmd.Parameters.AddWithValue("@id",dataGridView1.Rows[item].Cells[0].Value);
con.Open();
cmd.ExecuteNonQuery();
con.Close();
 }
GetList();
MessageBox.Show("Güncellendi");
}
private void sil()
{


   
var result = MessageBox.Show("Satır silinecek!", "Sil",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

if (result == DialogResult.Yes){

cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Student where id=@id";
            cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedCells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
            
           }

     
}


private void GetList()
        {
            con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            da = new SQLiteDataAdapter("Select *From Student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"];
            WorkBook workBook= WorkBook.Load(ds);
            con.Close();
            
        }
private void copyAlltoClipboard()
    {

        dataGridView1.SelectAll();
        DataObject dataObj = dataGridView1.GetClipboardContent();
        if (dataObj != null)
            Clipboard.SetDataObject(dataObj);
    }
void exceleat(){
        
        if(dataGridView1.Rows.Count>0){

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xcelapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object misdata=System.Reflection.Missing.Value;
            xlbook=xcelapp.Workbooks.Add(misdata);  
            xcelapp.Visible = true;
            xlsheet=(Microsoft.Office.Interop.Excel.Worksheet)xlbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr=(Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1,1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr,Type.Missing,Type.Missing,Type.Missing,Type.Missing,Type.Missing,true);

        }
        
      }
public Form1()
    {
        InitializeComponent();
        button1.Click += button1_Click;
        button2.Click += button2_Click;
        button3.Click += button3_Click;
        button4.Click += button4_Click;
        Load += new EventHandler(Form1_Load);
        
        
    }
private void Form1_Load(object sender, System.EventArgs e)
{
     if (!File.Exists("MyDatabase.sqlite"))
            {
                SQLiteConnection.CreateFile("MyDatabase.sqlite");
 
                string sql = @"CREATE TABLE Student(
                               ID INTEGER PRIMARY KEY AUTOINCREMENT ,
                               FirstName           TEXT      NOT NULL,
                               LastName            TEXT       NOT NULL
                            );";
                con = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
 
            }
   GetList();
}
private void button3_Click(object sender, EventArgs e) {
        sil();
        GetList();
    }
private void button2_Click(object sender, EventArgs e) {
        updateTablo();
    }
private void button4_Click(object sender,EventArgs e) { 

            exceleat();
         
    }
private void button1_Click(object sender, EventArgs e){
       
       form2= new Hello.Form1();
       form2.ShowDialog();
        insertad();
    }
}
