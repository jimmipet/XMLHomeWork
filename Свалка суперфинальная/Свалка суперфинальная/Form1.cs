using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Свалка_суперфинальная
{
    public partial class Свалка : Form
    {
        public Свалка()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Xml
         
            {
           Dump DumpXML = new Dump();

                XmlSerializer serial = new XmlSerializer(typeof(Dump));
                string pathXML = "..\\..\\Files\\XMlFile1.xml";
                using (FileStream fs = new FileStream(pathXML, FileMode.Open, FileAccess.Read))
                {
                    DumpXML = serial.Deserialize(fs) as Dump;
                }

                for (int i = 0; i < DumpXML.Wastes.WastesArray.Length; i++)
                {
                    WastesDGV.Rows.Add(DumpXML.Wastes.WastesArray[i].vCondition, DumpXML.Wastes.WastesArray[i].vType,
                          DumpXML.Wastes.WastesArray[i].vState, DumpXML.Wastes.WastesArray[i].Decompositionperiod.fage);
                }
                for (int i = 0; i < DumpXML.Equipments.EquipmentsArray.Length; i++)
                {
                    EquipmentsDGV.Rows.Add(DumpXML.Equipments.EquipmentsArray[i].tName,
                        DumpXML.Equipments.EquipmentsArray[i].tyear, DumpXML.Equipments.EquipmentsArray[i].tCondition, DumpXML.Equipments.EquipmentsArray[i].Repairs.gStatus);
                }
                for (int i = 0; i < DumpXML.Workers.WorkersArray.Length; i++)
                {
                    WorkersDGV.Rows.Add(DumpXML.Workers.WorkersArray[i].sName,
                        DumpXML.Workers.WorkersArray[i].ssurname, DumpXML.Workers.WorkersArray[i].spost, DumpXML.Workers.WorkersArray[i].sSalary);
                }
            }
           


        }
        
    }
}
