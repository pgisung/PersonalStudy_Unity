using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers  : MonoBehaviour
{
    static Managers s_Instance;
    public static Managers Instance { get { init();  return s_Instance; } }

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void init()
    {
        if (s_Instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject() { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_Instance = go.GetComponent<Managers>();
        }
    }
}
