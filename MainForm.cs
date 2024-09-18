/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/18/2024
 * Time: 10:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace splitXToZUntilY
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public double x = 0;
		public double z = 0;
		public double y = 0;
		public double c = 0;
		public double r = 0;
		public double eps = 1;
		public int coutnerofops = 0;
		
		public void resetxyz()
		{
			x = z = y = c = r =  0;
			coutnerofops=0;
		}
		public void textbox2double(ref TextBox t, ref double d )
		{
			try{
				d = double.Parse(t.Text);
			}
			catch{};
		}
		public string double2textbox(ref double d)
		{
			return d.ToString();
		}
		
		public void addLine2TextBoxOutput()
		{
			coutnerofops++;
			this.textBox4.Text += coutnerofops.ToString() +"\r\t" + double2textbox(ref x) ;
			this.textBox4.Text += "\r\t" + double2textbox(ref z) ;
			this.textBox4.Text += "\r\t" + double2textbox(ref y) ;
			this.textBox4.Text += "\r\t" + double2textbox(ref c) ;
			this.textBox4.Text += "\r\t" + double2textbox(ref r) ;
			this.textBox4.Text += "\r\n" ;
			textBox4.Refresh();
		}
		public void run()
		{
			textbox2double(ref textBox1, ref x);
			textbox2double(ref textBox2, ref z);
			textbox2double(ref textBox3, ref y);
			
			while( x>=eps )
			{
				c = x / z;
				addLine2TextBoxOutput();
				
				x = c ;
				
			};
		}
		void Button1Click(object sender, EventArgs e)
		{
			run();
		}
	
		void Button2Click(object sender, EventArgs e)
		{
			resetxyz();
		}
		public void clearResults()
		{
			textBox4.Text = "";
		}
		void Button3Click(object sender, EventArgs e)
		{
			clearResults();
		}
	}
}
