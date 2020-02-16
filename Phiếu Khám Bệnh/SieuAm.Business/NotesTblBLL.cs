using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SieuAm.DataAccess;
namespace SieuAm.Business
{
    public class NotesTblBLL
    {
        public void Add(NotesTblInfo note)
        {
            string sql = "INSERT INTO [dbo].[notesTbl]"
                       + "([noteName]"
                       + ",[clinicName]"
                       + ",[clinicAddress]"
                       + ",[doctorName]"
                       + ",[doctorPhone]"
                       + ",[patientName]"
                       + ",[patientAge]"
                       + ",[patientGender]"
                       + ",[patientCode]"
                       + ",[patientPhone]"
                       + ",[patientAddress]"
                       + ",[reason]"
                       + ",[suggest]"
                       + ",[imagePath1]"
                       + ",[imagePath2]"
                       + ",[templateID]"
                       + ",[dayCreate])"
                       + " VALUES "
                       + "(N'" + note.NoteName + "'"
                       + ",N'" + note.ClinicName + "'"
                       + ",N'" + note.ClinicAddress + "'"
                       + ",N'" + note.DoctorName + "'"
                       + ",'" + note.DoctorPhone + "'"
                       + ",N'" + note.PatientName + "'"
                       + "," + note.PatientAge
                       + "," + note.PatientGender
                       + ",N'" + note.PatientCode + "'"
                       + ",'" + note.PatientPhone + "'"
                       + ",N'" + note.PatientAddress + "'"
                       + ",N'" + note.Reason + "'"
                       + ",N'" + note.Suggest + "'"
                       + ",N'" + note.ImagePath1 + "'"
                       + ",N'" + note.ImagePath2 + "'"
                       + "," + note.TemplateID
                       + ",'" + Convert.ToDateTime(note.DayCreate) + "')";
            SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
        }
        public void Update(NotesTblInfo note)
        {
            if (note.NoteID > 0)
            {
                string sql = "UPDATE [dbo].[notesTbl]"
                           + " SET [noteName] = N'" + note.NoteName + "'"
                           + ",[clinicName] = N'" + note.ClinicName + "'"
                           + ",[clinicAddress] = N'" + note.ClinicAddress + "'"
                           + ",[doctorName] = N'" + note.DoctorName + "'"
                           + ",[doctorPhone] = '" + note.DoctorPhone + "'"
                           + ",[patientName] = N'" + note.PatientName + "'"
                           + ",[patientAge] = " + note.PatientAge
                           + ",[patientGender] = " + note.PatientGender
                           + ",[patientCode] = N'" + note.PatientCode + "'"
                           + ",[patientPhone] = '" + note.PatientPhone + "'"
                           + ",[patientAddress] = N'" + note.PatientAddress + "'"
                           + ",[reason] = N'" + note.Reason + "'"
                           + ",[suggest] = N'" + note.Suggest + "'"
                           + ",[imagePath1] = N'" + note.ImagePath1 + "'"
                           + ",[imagePath2] = N'" + note.ImagePath2 + "'"
                           + ",[templateID] = " + note.TemplateID
                           + ",[dayCreate] = '" + Convert.ToDateTime(note.DayCreate) + "'"
                           + " WHERE noteID = " + note.NoteID;
                SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
            }
        }
        public DataTable GetNotes()
        {
            string sql = "SELECT [noteID]"
                       + ",[noteName]"
                       + ",[clinicName]"
                       + ",[clinicAddress]"
                       + ",[doctorName]"
                       + ",[doctorPhone]"
                       + ",[patientName]"
                       + ",[patientAge]"
                       + ",[patientGender]"
                       + ",[patientCode]"
                       + ",[patientPhone]"
                       + ",[patientAddress]"
                       + ",[reason]"
                       + ",[suggest]"
                       + ",[imagePath1]"
                       + ",[imagePath2]"
                       + ",[templateID]"
                       + ",[dayCreate]"
                       + " FROM [dbo].[notesTbl]"
                       + " WHERE 1=1";
            sql += " ORDER BY noteID ASC";
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }
        public DataTable GetNotes(NotesTblInfo note)
        {
            string sql = "SELECT [noteID]"
                       + ",[noteName]"
                       + ",[clinicName]"
                       + ",[clinicAddress]"
                       + ",[doctorName]"
                       + ",[doctorPhone]"
                       + ",[patientName]"
                       + ",[patientAge]"
                       + ",[patientGender]"
                       + ",[patientCode]"
                       + ",[patientPhone]"
                       + ",[patientAddress]"
                       + ",[reason]"
                       + ",[suggest]"
                       + ",[imagePath1]"
                       + ",[imagePath2]"
                       + ",[templateID]"
                       + ",[dayCreate]"
                       + " FROM [dbo].[notesTbl]"
                       + " WHERE 1=1";
            sql += " ORDER BY noteID ASC";
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }
        public DataTable GetSearchedNotes(NotesTblInfo note)
        {
            string sql = "SELECT [noteID]"
                       + ",[noteName]"
                       + ",[clinicName]"
                       + ",[clinicAddress]"
                       + ",[doctorName]"
                       + ",[doctorPhone]"
                       + ",[patientName]"
                       + ",[patientAge]"
                       + ",[patientGender]"
                       + ",[patientCode]"
                       + ",[patientPhone]"
                       + ",[patientAddress]"
                       + ",[reason]"
                       + ",[suggest]"
                       + ",[imagePath1]"
                       + ",[imagePath2]"
                       + ",[templateID]"
                       + ",[dayCreate]"
                       + " FROM [dbo].[notesTbl]"
                       + " WHERE 1=1";
            if (note.NoteID > 0)
            {
                sql += " AND noteID like %" + note.NoteID + "%";
            }
            if (note.NoteName.Length > 0)
            {
                sql += " AND noteName like %'" + note.NoteName + "'%";
            }
            if (note.ClinicName.Length > 0)
            {
                sql += " AND clinicName like %'" + note.ClinicName + "'%";
            }
            if (note.DoctorName.Length > 0)
            {
                sql += " AND doctorName like %'" + note.DoctorName + "'%";
            }
            if (note.PatientName.Length > 0)
            {
                sql += " AND patientName like %'" + note.PatientName + "'%";
            }
            if (note.PatientCode.Length > 0)
            {
                sql += " AND patientCode like %'" + note.PatientCode + "'%";
            }
            if (note.DayCreate.Length > 0)
            {
                sql += " AND dayCreate like %" + Convert.ToDateTime(note.DayCreate) + "%";
            }
            sql += " ORDER BY noteID ASC";
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }

        //search notes 
        public DataTable SearchNotes(string sql)
        {
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }
        //get note by noteID
        public DataTable GetNoteByNoteID(int noteID)
        {
            string sql = "SELECT [noteID]"
                       + ",[noteName]"
                       + ",[clinicName]"
                       + ",[clinicAddress]"
                       + ",[doctorName]"
                       + ",[doctorPhone]"
                       + ",[patientName]"
                       + ",[patientAge]"
                       + ",[patientGender]"
                       + ",[patientCode]"
                       + ",[patientPhone]"
                       + ",[patientAddress]"
                       + ",[reason]"
                       + ",[suggest]"
                       + ",[imagePath1]"
                       + ",[imagePath2]"
                       + ",[templateID]"
                       + ",[dayCreate]"
                       + " FROM [dbo].[notesTbl]"
                       + " WHERE [noteID] = " + noteID;
            return SqlExtend.ExecuteDataTable(Data.ConnectionString, CommandType.Text, sql);
        }
        // Delete
        public void Delete(NotesTblInfo note)
        {
            if (note.NoteID > 0)
            {
                string sql = "DELETE FROM [dbo].[notesTbl]"
                           + " WHERE noteID = " + note.NoteID;
                SqlExtend.ExecuteNonQuery(Data.ConnectionString, CommandType.Text, sql);
            }
        }
    }
}
