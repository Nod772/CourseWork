using BaseTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFLogic.DTO;

namespace WCFLogic
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        void AddTeacher(TeacherDTO teasher);
          [OperationContract]
        void DeleteTeacher(TeacherDTO teasher);
          [OperationContract]
        IEnumerable<TeacherDTO> GetTeachers();

        // TODO: Добавьте здесь операции служб
    }

   
}
