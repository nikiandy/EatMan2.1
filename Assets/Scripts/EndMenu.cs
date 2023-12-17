using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour {

    private string Menu = "Start Menu";

    void Start() {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }

    
    public void RetryGame() {
        
        SceneManager.LoadScene(1);
    }

    public void LoadMenu() {

        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }

    public void ExitGame() {
        
        Debug.Log("Exiting Game!");
        Application.Quit();
    }

}
