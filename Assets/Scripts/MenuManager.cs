using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour{

    public static MenuManager sharedInstance;
    public Canvas menuCanvas;

    //Permitira gestionar el canvas

    public Canvas gameCanvas;
    public Canvas gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if(sharedInstance == null){
            sharedInstance = this;
        }
    }

    public void ShowMainMenu(){
        menuCanvas.enabled = true;
    }

    public void HideMainMenu(){
        menuCanvas.enabled = false;
    }

    public void ShowGameMenu(){
        gameCanvas.enabled = true;
    }

    public void HideGameMenu(){
        gameCanvas.enabled = true;
    }

    public void ShowGameOverMenu(){
        gameOverCanvas.enabled = false;
    }

    public void ExitGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update(){
        
    }
}
