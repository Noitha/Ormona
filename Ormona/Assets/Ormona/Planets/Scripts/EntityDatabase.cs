using System.Collections.Generic;
using UnityEngine;

namespace Ormona.Planets.Scripts
{
    [CreateAssetMenu(menuName = "Planet/Entity Database", fileName = "New EntityDatabase")]
    public class EntityDatabase : ScriptableObject
    {
        public List<BaseEntity> entities = new List<BaseEntity>();
        
        public BaseEntity GetEntityByLabel(string label)
        {
            return entities.Find(entity => entity.label == label);
        }

        public BaseEntity GetEntityById(int id)
        {
            return entities.Find(entity => entity.id == id);
        }
    }
}