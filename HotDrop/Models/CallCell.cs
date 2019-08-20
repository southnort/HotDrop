using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HotDrop.Models
{
    public class CallCell
    {
        public int Id { get; set; }     //ид для базы данных
        public string Inn { get; set; }     //инн организации
        public string ClientName { get; set; }      //ФИО звонящего
        public string PhoneNumber { get; set; }     //телефон, откуда звонит
        public string Descr { get; set; }      //описание проблемы

        public string CallDateTime { get; set; }        //дата, время обращения

        public int Logged { get; set; }     //занесено ли в контроль. 1 - да, 0 - нет


        public CallCell()
        {
        }

        public CallCell(string inn, string clientName,
            string phoneNumber, string descr, bool control)
        {
            Inn = inn + " ";
            ClientName = clientName + " ";
            PhoneNumber = phoneNumber + " ";
            Descr = descr + " ";

            CallDateTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            Logged = control ? 1 : 0;

        }

    }
}
