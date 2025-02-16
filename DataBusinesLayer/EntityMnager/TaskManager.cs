using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;

namespace DataBusinesLayer
{

    public static class TaskManager
    {
        public static TasksList GetAll()
        {
           DataTable dt= DBManager.GetQueryResult("Select * from Tasks");
            return MapFromDtToTaskList(dt);
            
        }

        public static Task GetById(int id)
        {
            DataTable dt =  DBManager.GetQueryResult($"Select * from Tasks Where id={id}");
            return MapFromDtToTaskList(dt).FirstOrDefault()??new Task();

        }

        public static int AddTask(string title,string status,DateTime from,DateTime to ,string description)
        {
            int AffectedRows=DBManager.ExcuteNonQuery("insert into Tasks (Title,T_State,Dur_From,Dur_To,T_Description)" +
                                                       $"values('{title}','{status}','{from}','{to}','{description}') ");
            return AffectedRows;
        }

        public static int UpdateTask(int id,string Title)
        {
            int AffectedRows = DBManager.ExcuteNonQuery($"update Tasks set Title='{Title}' where Id={id} ");
            return AffectedRows;
        }

        public static int DeleteTask(int id)
        {
            int AffectedRows = DBManager.ExcuteNonQuery($"Delete from Tasks Where Id='{id}'");
            return AffectedRows;
        }
        static TasksList MapFromDtToTaskList(DataTable dt)
        {
            TasksList tasks = new TasksList();
            foreach (DataRow dr in dt.Rows)
            {
                tasks.Add(MapFromDataTableRowToTask(dr));
            }
            return tasks;
        }
       static Task MapFromDataTableRowToTask(DataRow dr)
        {
           
            Task task = new Task();
            task.id = (int)dr[0];
            task.Title = dr[1].ToString();
            task.T_State = dr[2].ToString();
            task.Dur_From = (DateTime)dr[3];
            task.Dur_To = (DateTime)dr[4];
            task.T_Description = dr[5].ToString();
            return task;
        }

       
    }
}
