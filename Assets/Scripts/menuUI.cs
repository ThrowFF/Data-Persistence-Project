using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;


public class menuUI : MonoBehaviour
{
    public static string input;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        EditorApplication.ExitPlaymode();
    }

    public static void ReadStringInput(string name)
    {
        input = name;
        Debug.Log(input);
    }
}
