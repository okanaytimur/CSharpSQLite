using System.Reflection;
using System.Windows.Forms;

namespace yeni;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Kullanıcılar";
        this.Icon = new Icon("Resources/favicon.ico");
        this.MaximumSize = this.ClientSize;
        this.MinimumSize = this.ClientSize; 
        this.MaximizeBox = false;
        
        
        
        

        label1=new Label();
        label1.Text="İsim";
        label1.Size=new System.Drawing.Size(40,20);
        this.Controls.Add(label1);
        label1.Location=new System.Drawing.Point(10,5);

        label2=new Label();
        label2.Text="Soyisim";
        label2.Size=new System.Drawing.Size(60,20);
        this.Controls.Add(label2);
        label2.Location=new System.Drawing.Point(10,70);

        button1= new Button();        
        button1.Text="Kaydet";
        this.Controls.Add(button1);
        button1.Size=new System.Drawing.Size(80,40);
        button1.Location=new System.Drawing.Point(10,150);

        button2= new Button();        
        button2.Text="Güncelle";
        this.Controls.Add(button2);
        button2.Size=new System.Drawing.Size(80,40);
        button2.Location=new System.Drawing.Point(100,150);

        button3= new Button();        
        button3.Text="Sil";
        this.Controls.Add(button3);
        button3.Size=new System.Drawing.Size(80,40);
        button3.Location=new System.Drawing.Point(10,200);
        
         button4= new Button();        
        button4.Text="Excel";
        this.Controls.Add(button4);
        button4.Size=new System.Drawing.Size(80,40);
        button4.Location=new System.Drawing.Point(100,200);
        
        textBox1=new TextBox();
        this.Controls.Add(textBox1);      
        textBox1.Location=new System.Drawing.Point(10,40);  

        textBox2=new TextBox();
        this.Controls.Add(textBox2);      
        textBox2.Location=new System.Drawing.Point(10,100); 

        dataGridView1 = new System.Windows.Forms.DataGridView();
        this.Controls.Add(dataGridView1);
        dataGridView1.Location=new System.Drawing.Point(200,0);
        dataGridView1.Size=new System.Drawing.Size(500,200);
        dataGridView1.Dock = DockStyle.Right;
        dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;



    }

   
    private System.Windows.Forms.Label label1;
     private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private DataGridView dataGridView1;
     private Hello.Form1 form2;





    #endregion
}
