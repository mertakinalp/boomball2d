using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class LoadSkor : MonoBehaviour {
    public TextMesh _Skor;
    public TextMesh kredits;
    public float scrollSpeed = 1f;
    public string Oku()
    {
     
        string sonuc = "0";

        string fileLoc = Application.persistentDataPath + "/KolUnitySkor.dat";

        if (File.Exists(fileLoc))
        {
            using (TextReader tr = new StreamReader(fileLoc))
            {
                sonuc = tr.ReadLine();
            }
        }

        return sonuc;
    }

    void OnGUI()
    {
      
            


       

    }

    // Use this for initialization
    void Start () {

        _Skor.text = Oku();
       

    }

  
	
	// Update is called once per frame
	void Update () {
       
    }

    void FixedUpdate()
    {
       
    }
}
