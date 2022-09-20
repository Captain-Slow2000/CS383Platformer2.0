using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID); //loading the scene ID of the scene we want to move to
    }
    void Update()
    {
        if (Input.GetKeyDown("o"))
        {
            SceneManager.LoadScene(1);
        }
    }
    //function called when ever quit button is pressed
    public void Quit()
    {
        Application.Quit();
    }
}
