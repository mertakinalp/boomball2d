using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string message = "Where we're going, we don't need roads.";
   

    

    public void OnMouseDown()
    {
        switch (this.name)
        {
            case "":
            default:
                break;
            case "oyna":
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
                break;
            case "cikis":
                Application.Quit();
               
                break;
            case "kredits":
                SceneManager.LoadScene(2);
                break;
        }
      
    }

  



}