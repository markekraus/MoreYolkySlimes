using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MoreYolkySlimes
{
    internal class Utility
    {
        public static IEnumerable<T> GetAll<T>(string name) where T : UnityEngine.Object
        {
            return Resources.FindObjectsOfTypeAll<T>().Where((T found) => found.name.Equals(name));
        }
    }
}
