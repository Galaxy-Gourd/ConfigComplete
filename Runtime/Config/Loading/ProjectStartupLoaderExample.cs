using System.Collections;
using System.Collections.Generic;
using GGUnityRoot;
using UnityEngine;

namespace GGProjectRoot
{
    /// <summary>
    /// Overwrite this class with the startup scene functionality for your specific project; as long as it uses
    /// IProjectStartupLoader and is attached to the PF_ProjectLoader prefab, it will automatically be executed
    /// when the startup scene is loaded.
    /// </summary>
    public class ProjectStartupLoaderExample : MonoBehaviour, IProjectStartupLoader
    {
        #region VARIABLES

        [Header("References")]
        [SerializeField] private List<GameObject> _objectsToSpawnAtLoad;

        public float TestWaitTime;

        #endregion VARIABLES
    

        #region LOAD

        IEnumerator IProjectStartupLoader.LoadStartup()
        {
            // Spawn all of our spawn objects
            foreach (GameObject obj in _objectsToSpawnAtLoad)
            { 
                GameObject g = Instantiate(obj);
                DontDestroyOnLoad(g);
            }

            yield return new WaitForSeconds(TestWaitTime);
        }
 
        #endregion LOAD
    }
}

