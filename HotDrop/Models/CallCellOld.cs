using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotDrop.Models
{
    /// <summary>
    /// класс описывает звонок.
    /// Кто звонил, с какого телефона, краткое описание проблемы
    /// </summary>
    public class CallCellOld : IDataBased
    {
        public int id { get; set; }     //ид для базы данных
        public string inn { get; set; }     //инн организации
        public string clientName { get; set; }      //ФИО звонящего
        public string phoneNumber { get; set; }     //телефон, откуда звонит
        public string descr { get; set; }      //описание проблемы

        public string callDateTime { get; set; }        //дата, время обращения

        public int logged { get; set; }     //занесено ли в контроль. 1 - да, 0 - нет



        public CallCellOld(string inn, string clientName,
            string phoneNumber, string descr, bool control)
        {
            this.inn = inn + " ";
            this.clientName = clientName + " ";
            this.phoneNumber = phoneNumber + " ";
            this.descr = descr + " ";

            callDateTime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            logged = control ? 1 : 0;

        }

        public CallCellOld(DataRow row)
        {
            id = GetInt(row[0]);
            inn = GetStr(row[1]);
            clientName = GetStr(row[2]);
            phoneNumber = GetStr(row[3]);
            descr = GetStr(row[4]);
            callDateTime = GetStr(row[5]);
            logged = GetInt(row[6]);

        }




        public string ToDataBaseString()
        {
            if (id == 0)
            {
                return ToNew();
            }

            else
            {
                return ToUpdate();
            }
        }

        private string ToNew()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO CallCells (");
            sb.Append("'inn', 'clientName', 'phoneNumber', ");
            sb.Append("'descr', 'callDateTime', 'logged'");

            sb.Append(") VALUES (");

            sb.Append("'");
            sb.Append(inn);
            sb.Append("', ");

            sb.Append("'");
            sb.Append(clientName);
            sb.Append("', ");

            sb.Append("'");
            sb.Append(phoneNumber);
            sb.Append("', ");

            sb.Append("'");
            sb.Append(descr);
            sb.Append("', ");

            sb.Append("'");
            sb.Append(callDateTime);
            sb.Append("', ");

            sb.Append("'");
            sb.Append(logged);
            sb.Append("')");

            return sb.ToString();
        }

        private string ToUpdate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE CallCells SET ");
            sb.Append($"inn = '{inn}', ");
            sb.Append($"clientName = '{clientName}', ");
            sb.Append($"phoneNumber = '{phoneNumber}', ");
            sb.Append($"descr = '{descr}', ");
            sb.Append($"callDateTime = '{callDateTime}', ");
            sb.Append($"logged = '{logged}'");

            sb.Append($" WHERE id = {id}");

            return sb.ToString();
        }

        private int GetInt(object val)
        {
            return CommonMethods.GetInt(val);
        }

        private string GetStr(object val)
        {
            return CommonMethods.GetStr(val);
        }





    }
}
