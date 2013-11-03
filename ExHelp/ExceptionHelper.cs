using System;
using System.Collections.Generic;
using System.Linq;
using ExHelp.Exceptions;

namespace ExHelp
{
    public class ExceptionHelper
    {
        /// <summary>
        /// Check any object to see if it is null.
        /// </summary>
        /// <param name="obj">The target object</param>
        /// <exception cref="ArgumentNullException">Thrown is obj is null.</exception>
        public static void CheckForNull(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();
        }

        /// <summary>
        /// Check a generic Dictionary to see if it contains any values.
        /// </summary>
        /// <typeparam name="T">Generic parameter type</typeparam>
        /// <typeparam name="TF">Generic parameter type</typeparam>
        /// <param name="objList">The dictionary of objects.</param>
        /// <exception cref="EmptyCollectionException">Thrown if the Dictionary contains no entries.</exception>
        public static void CheckForEmpty<T, TF>(IDictionary<T, TF> objList)
        {
            if (!objList.Any())
                throw new EmptyCollectionException();
        }

        /// <summary>
        /// Check generic List to see if it contains any values.
        /// </summary>
        /// <typeparam name="T">Generic parameter type</typeparam>
        /// <param name="objList"></param>
        /// <exception cref="EmptyCollectionException">Thrown if the Collection contains no entries.</exception>
        public static void CheckForEmptyList<T>(IEnumerable<T> objList)
        {
            if (!objList.Any())
                throw new EmptyCollectionException();
        }

        /// <summary>
        /// Check a string for an Empty of null value.
        /// </summary>
        /// <param name="stringToCheck">The string that is to be checked.</param>
        /// <exception cref="ArgumentNullException">thrown if the string is Null or Empty.</exception>
        public static void CheckForEmptyString(string stringToCheck)
        {
            if (string.IsNullOrEmpty(stringToCheck))
                throw new ArgumentNullException("stringToCheck");
        }

        /// <summary>
        /// Check a Dictionary to see if it contains a specific Key.
        /// </summary>
        /// <typeparam name="T">Generic parameter type</typeparam>
        /// <typeparam name="TF">Generic parameter type</typeparam>
        /// <param name="dictionary">The Dictionary to check</param>
        /// <param name="key">The key to find</param>
        /// <exception cref="KeyNotFoundException">Thrown if the Key cannot be found in the Dictionary.</exception>
        public static void CheckContainsKey<T, TF>(Dictionary<T, TF> dictionary, T key)
        {
            if (!dictionary.ContainsKey(key))
                throw new KeyNotFoundException();
        }
    }
}
