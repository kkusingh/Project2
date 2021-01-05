using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using Business.abc;

namespace Business1
{
    public class Business
    {
        public static List<Studentdata> GetIndividualStudentData()
        {

            Studentdata Indivstudent = new Studentdata();
            var Indivstudentlist = new List<Studentdata>();
            DataSet dsGetstudentReport = new DataSet();
           

            DataSet dsGetstudentdatareport = new DataSet();



            // 2nd assignment

            dsGetstudentdatareport = DAstudentdata.GetstudentdatausingDBwithconfig();

            // third assignment

            //var testService = new StudentdataserviceClient();
            //dsGetstudentdatareport = testService.GetstudentdatausingDBwithconfig();


            if (dsGetstudentdatareport.Tables.Count > 0)
            {
                Indivstudentlist = dsGetstudentdatareport.Tables[0].AsEnumerable().Select(m => new Studentdata
                {

                    Studentid = Convert.ToString(m["Studentid"]),
                    StudentName = Convert.ToString(m["Name"]),
                    ISEM1 = Convert.ToString(m["ISEM1"]),
                    ISEM2 = Convert.ToString(m["ISEM2"]),
                    ISEM3 = Convert.ToString(m["ISEM3"])


                }).ToList();

                return Indivstudentlist;
            }

            else
            {
                return null;
            }
        }

    }
}

