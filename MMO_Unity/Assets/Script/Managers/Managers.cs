using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers  : MonoBehaviour
{
    static Managers s_Instance;
    static Managers Instance { get { init();  return s_Instance; } }

    InputManager _Input = new InputManager();
    public static InputManager Input { get { return Instance._Input; } }

    ResourceManager _Resource = new ResourceManager();
    public static ResourceManager Resource { get { return Instance._Resource; } }

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        _Input.OnUpdate();
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
