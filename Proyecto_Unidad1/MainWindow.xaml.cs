﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Unidad1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string UserResult;
                string PasswordResult;

                UserResult = txtUser.Text;
                PasswordResult = txtPassword.Text;

                using (var _context = new Context.AplicationdbContext())
                {
                    var result = _context.Usuario.FirstOrDefault(x => x.User == UserResult && x.Password == PasswordResult);

                    if(result != null)
                    {
                        Sistema sistema = new Sistema();
                        sistema.Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error interno"+ex.Message);
            }
        }
    }
}
