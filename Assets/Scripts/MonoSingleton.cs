using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;
    private static object _syncobj = new object();
    private static bool _isAppClosing = false;

    public static T Instance
    {
        get
        {
            if (_isAppClosing == true)
            {
                return null;
            }

            lock (_syncobj)
            {
                if (_instance == null)
                {
                    T[] activateObjs = FindObjectsOfType<T>();

                    if (activateObjs.Length > 0)
                        _instance = activateObjs[0];

                    if (activateObjs.Length > 1)
                        Debug.LogError("There is more than one" + typeof(T).Name + "in the scene.");

                    if (_instance == null)
                    {
                        var objName = typeof(T).ToString();
                        var obj = GameObject.Find(objName);

                        if (obj == null)
                            obj = new GameObject(objName);
                        _instance = obj.AddComponent<T>();
                    }
                }
            }

            return _instance;
        }
    }
	
    protected virtual void OnApplicationQuit()
    {
        _isAppClosing = true;
    }
}
