using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    public static MenuManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
