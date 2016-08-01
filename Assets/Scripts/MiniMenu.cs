using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MiniMenu : MonoBehaviour {

    public void OnMouseDown()
    {

        switch (this.name)
        {
            case "":
            default:

                break;
            case "pl":
                Time.timeScale = 1;
                break;
            case "ps":
                Time.timeScale = 0;
                
                break;
            case "ex":
                SceneManager.LoadScene(0);
                break;
        }


    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
