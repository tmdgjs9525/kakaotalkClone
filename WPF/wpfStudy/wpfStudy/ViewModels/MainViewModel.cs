using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using wpfStudy.Models;
using wpfStudy.Views;

namespace wpfStudy.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private int progressValue;
        public ICommand TestClick { get; set; }
        public ICommand SecondShow { get; set; }
        public ICommand SelectClick { get; set; }
        public ICommand InsertClick { get; set; }

        private List<USERINFO> myListUser;

        private string name;
        private string img;
        private int age;

        #region property
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged(nameof(name));
            }
        }



        public string Img
        {
            get { return img; }
            set
            {
                img = value;
                NotifyPropertyChanged(nameof(img));
            }
        }



        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                NotifyPropertyChanged(nameof(age));
            }
        }
        #endregion
        public List<USERINFO> MyListUser
        {
            get { return myListUser; }
            set {
                myListUser = value;
                NotifyPropertyChanged(nameof(myListUser));
            }
        }

        

        public MainViewModel()
        {
            //TestClick = new RelayCommand<object>(ExecuteMyButton,CanMyButton);
            TestClick = new AsyncRelayCommand(ExecuteMyButton2);
            SecondShow = new AsyncRelayCommand(ExecuteMyButton3);
            SelectClick = new AsyncRelayCommand(SelectDataBase);
            InsertClick = new AsyncRelayCommand(InsertDataBase);
        }
        public int ProgressValue
        {
            get { return progressValue; }
            set {
                progressValue = value;
                NotifyPropertyChanged(nameof(progressValue));
            }
        }


        bool CanMyButton(object param)
        {
            if (param == null) return true;
            return !param.ToString().Equals("");
        }

        void ExecuteMyButton(object param)
        {
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 30; i++)
                {
                    ProgressValue = i;
                    Thread.Sleep(100);
                }
            });
          
            MessageBox.Show("a");
        }
        public async Task ExecuteMyButton2()
        {
            Task<int> task1 = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    ProgressValue = i;
                    Thread.Sleep(100);
                }
                return 5;
            });
            int w = await task1;
            MessageBox.Show("a");
        }

        public async Task ExecuteMyButton3()
        {
            SecondView secondVIew = new SecondView();
            SecondViewModel aa = new SecondViewModel();
            aa.ProgressValue = 70;
            secondVIew.DataContext = aa;
            secondVIew.ShowDialog();
            await Task.Delay(0);
        }

        public async Task SelectDataBase()
        {
            DataSet ds = new DataSet();
            List<USERINFO> listUserTEmp = new List<USERINFO>();
            Exception exception = null;
            Task t=  Task.Run(() =>
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionStr))
                    {
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                        sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM USERINFO;",sqlConnection);
                        sqlDataAdapter.Fill(ds);
                    }
                  
                    if (ds.Tables.Count != 0)
                    {
                        DataTable dt = ds.Tables[0];
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            
                            USERINFO userinfo = new USERINFO();
                            userinfo.USERNAME = dt.Rows[i]["USERNAME"].ToString();
                            userinfo.USERIMG = dt.Rows[i]["USERIMG"].ToString();
                            userinfo.USERAGE = int.Parse(dt.Rows[i]["USERAGE"].ToString());
                            listUserTEmp.Add(userinfo);
                        }
                        
                    }
                }
                catch(Exception ex)
                {
                    exception = ex;
                }
            });
            await t;
            if (exception !=null)
            {
                MessageBox.Show(exception.Message.ToString());
            }

            MyListUser = listUserTEmp;
        }
        public async Task InsertDataBase()
        {
            DataSet ds = new DataSet();
            List<USERINFO> listUserTEmp = new List<USERINFO>();
            Exception exception = null;
            Task t = Task.Run(() =>
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionStr))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = sqlConnection.CreateCommand();
                        sqlCommand.CommandText = $"INSERT INTO USERINFO(USERNAME,USERIMG,USERAGE) VALUES ('{Name}','{Img}','{Age}')";
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    exception = ex;
                }
            });
            await t;
            if (exception != null)
            {
                MessageBox.Show(exception.Message.ToString());
            }

            await SelectDataBase();
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
