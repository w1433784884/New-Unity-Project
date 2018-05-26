using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartScene : MonoBehaviour {

    public Button btnStart;
    public Button btnExit;
    // Use this for initialization
    void Start (){
        btnStart.onClick.AddListener(PlayGame);
        btnExit.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
    private void PlayGame(){
        Application.LoadLevel("Game");
    }
	// Update is called once per frame
	void Update () {
		
	}
 
}
