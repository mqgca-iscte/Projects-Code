using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void CloseScene()
    {
       // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
