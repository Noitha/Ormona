using UnityEngine;

namespace Ormona.Planets
{
    public abstract class BaseEntity : ScriptableObject
    {
        /// <summary>
        /// Unique identifier for the entity.
        /// </summary>
        public int id;

        /// <summary>
        /// Label
        /// </summary>
        public string label;
        
        /// <summary>
        /// Description of the entity.
        /// </summary>
        public string description;

        public bool ignoreDrawing;
        public bool isFluid;
        public bool isVegetable;

        //public bool overrideDrawing;
        
        public bool castShadow;
        
        public BuildType buildType;
        
        /// <summary>
        /// Stability of the entity.
        /// </summary>
        public int stability;
    }
}