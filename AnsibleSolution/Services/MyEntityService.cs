using AnsibleSolution.Abstractions;
using AnsibleSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnsibleSolution.Services
{
    public class MyEntityService : IMyEntityService
    {
        public static List<MyEntity> TestData = new List<MyEntity>()
        {
            new MyEntity(){ MyEntityId = 1, Name = "Object1", Details="Details Object1" },
            new MyEntity(){ MyEntityId = 2, Name = "Object2", Details="Details Object2" },
            new MyEntity(){ MyEntityId = 3, Name = "Object3", Details="Details Object3" },
            new MyEntity(){ MyEntityId = 4, Name = "Object4", Details="Details Object4" },
            new MyEntity(){ MyEntityId = 5, Name = "Object5", Details="Details Object5" },
        };

        public void AddEntity(MyEntity entity)
        {
            int lastId = TestData.Max(e => e.MyEntityId);

            entity.MyEntityId = lastId + 1;

            TestData.Add(entity);
        }

        public void AddListEntitites(IEnumerable<MyEntity> entities)
        {
            foreach (var myEntity in entities)
            {
                AddEntity(myEntity);
            }
        }

        public IEnumerable<MyEntity> GetAllEntities()
        {
            return TestData;
        }

        public MyEntity GetEntityById(int id)
        {
            return TestData.Where(e => e.MyEntityId == id).FirstOrDefault();
        }
    }
}
