using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BaseTestLib;
using BaseTestLib.Classes;
using AutoMapper;
using WCFLogic.DTO;
using BaseTestLib.Interfaces;

namespace WCFLogic
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class TestService : ITestService
    {
        IWrapper<Teasher> wrapper;
      //  WrapperTeacher wrapper = null;
        IMapper mapper = null;
        public TestService(WrapperTeacher wrap)
        {
            wrapper = wrap;
            var config = new MapperConfiguration(x=>
            {
                x.CreateMap<TeacherDTO, Teasher>();
                x.CreateMap<Teasher, TeacherDTO>();
            }
            );
            mapper = config.CreateMapper();
        }
        public TestService()
        {

        }

        public void AddTeacher(TeacherDTO teasher)
        {
            wrapper.AddItem(mapper.Map<TeacherDTO, Teasher>(teasher));
        }

        public void DeleteTeacher(TeacherDTO teasher)
        {
            wrapper.Delete(mapper.Map<TeacherDTO, Teasher>(teasher));
        }

        public IEnumerable<TeacherDTO> GetTeachers()
        {
            return mapper.Map<IEnumerable<Teasher>,IEnumerable<TeacherDTO>>(wrapper.GetItems());
        }
    }
}
