using System.Windows;
using System;

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        public WpfMailSender()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, RoutedEventArgs e)
        {

            EmailSendServiceClass em = new EmailSendServiceClass(tbSubject.Text, tbBody.Text, passwordBox.SecurePassword);

            try
            {
                em.Send();
                SendEndWindow sew = new SendEndWindow();
                sew.ShowDialog();
            }
            catch (Exception ex)
            {
                SendErrorWindow sw = new SendErrorWindow();
                sw.textInfo.Text = $"Невозможно отправить письмо {ex.ToString()}";
                sw.ShowDialog();                
            }   
        }
    }
}
