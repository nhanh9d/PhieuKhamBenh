using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuAm.Business
{
    public class NotesTblInfo
    {
        private int noteID;
        private string noteName;
        private string clinicName;
        private string clinicAddress;
        private string doctorName;
        private string doctorPhone;
        private string patientName;
        private int patientAge;
        private int patientGender;
        private string patientCode;
        private string patientPhone;
        private string patientAddress;
        private string reason;
        private string suggest;
        private string imagePath1;
        private string imagePath2;
        private int templateID;
        private string dayCreate;

        public int NoteID { get => noteID; set => noteID = value; }
        public string NoteName { get => noteName; set => noteName = value; }
        public string ClinicName { get => clinicName; set => clinicName = value; }
        public string ClinicAddress { get => clinicAddress; set => clinicAddress = value; }
        public string DoctorName { get => doctorName; set => doctorName = value; }
        public string DoctorPhone { get => doctorPhone; set => doctorPhone = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public int PatientAge { get => patientAge; set => patientAge = value; }
        public int PatientGender { get => patientGender; set => patientGender = value; }
        public string PatientCode { get => patientCode; set => patientCode = value; }
        public string PatientPhone { get => patientPhone; set => patientPhone = value; }
        public string PatientAddress { get => patientAddress; set => patientAddress = value; }
        public string Reason { get => reason; set => reason = value; }
        public string Suggest { get => suggest; set => suggest = value; }
        public string ImagePath1 { get => imagePath1; set => imagePath1 = value; }
        public string ImagePath2 { get => imagePath2; set => imagePath2 = value; }
        public int TemplateID { get => templateID; set => templateID = value; }
        public string DayCreate { get => dayCreate; set => dayCreate = value; }

        public NotesTblInfo()
        {
            noteID = -1;
        }
    }
}
