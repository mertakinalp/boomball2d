using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
    public TextMesh kredits;
    private void Kaydir()
    {
        //0.88 -4.9 -2
        kredits.transform.position = new Vector3(-1f, kredits.transform.position.y + Time.deltaTime * 1.5f, -2f);

        // If message has moved past the right side, move it back to the left.
        if (kredits.transform.position.y >= GetComponent<Renderer>().bounds.extents.y + 5)
        {

            kredits.transform.position = new Vector3(-1f, -4.9f, -2f);
            SceneManager.LoadScene(0);
        }
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        Kaydir();
    }

    void Update () {
      //  Kaydir();
	}
}
