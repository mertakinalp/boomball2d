using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameScript : MonoBehaviour {

    public TextMesh _Skor;
    int Sayac;
    int can=3;
    public Camera cam;
    private float maxWidth;
    public GameObject kalp1;
    public GameObject kalp2;
    public GameObject kalp3;
    public AudioSource patlama;
    public AudioSource toplama;


   


    void OnTriggerEnter2D(Collider2D other)
    {


        bool top = false;

        if (other.name.Contains("deneme"))
        {
            top = false;
        }
        if (other.name.Contains("poke"))
        {
            top = true;
        }

        Destroy(other.gameObject);

        if (top)
        {
            toplama.Play();
            Sayac++;
        }
        else
        {
          //  Sayac--;
            can--;
            patlama.Play();
            Renderer krender = new Renderer();
            switch (can)
            {
                default:
                    break;
                case 0:
                    krender = kalp1.GetComponent<Renderer>();
                    break;
                case 1:
                    krender = kalp2.GetComponent<Renderer>();
                    break;
                case 2:
                    krender = kalp3.GetComponent<Renderer>();
                    break;
            }

            krender.material.color = Color.clear;
        }

        if (Sayac < 0)
        {
            Sayac = 0;
        }
        if (can<=0)
        {
            string eskortxt = "";

            LoadSkor lds = new LoadSkor();

            int eskorint = 0;

            eskortxt = lds.Oku();

            int.TryParse(eskortxt, out eskorint);

            if (Sayac > eskorint)
            {
                Kaydet(Sayac);
            }
            SceneManager.LoadScene(0);

            
        }

      

            
        _Skor.text = Sayac.ToString();

     
      

        // GetComponent<TextMesh>().text = "test";
        // _Skor.text = "hrfr";

        
    }

 

    private void Kaydet(int Skor)
    {
      
            string fileLoc = Application.persistentDataPath + "/KolUnitySkor.dat";

     

            if (!File.Exists(fileLoc))
            {
                using (FileStream fs = File.Create(fileLoc))
                {

                }
            }

            if (File.Exists(fileLoc))
            {
                using (StreamWriter sw = new StreamWriter(fileLoc))
                {
                    sw.Write(Skor.ToString());
                }
            }

     
              
            
        
 

        
    }
}
