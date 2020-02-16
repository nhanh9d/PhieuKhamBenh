using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuAm.Business
{
    public class TemplateTblInfo
    {
        private int _templateID;
        private string _templateName;
        private string _resultDetail;
        private string _analysis;
        private string _diagnosis;

        public int TemplateID { get => _templateID; set => _templateID = value; }
        public string TemplateName { get => _templateName; set => _templateName = value; }
        public string ResultDetail { get => _resultDetail; set => _resultDetail = value; }
        public string Analysis { get => _analysis; set => _analysis = value; }
        public string Diagnosis { get => _diagnosis; set => _diagnosis = value; }

        public TemplateTblInfo()
        {
        }
    }
}
