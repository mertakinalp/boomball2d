using UnityEngine;
using System.Collections;

public class RandomScript : MonoBehaviour
{

    public Camera cam;
    public GameObject dogrutop;
    public GameObject yanlistop;
    private float maxWidth;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    GameObject[] dogrutoplar;
    GameObject[] yanlistoplar;
    public GameObject kalp1;
    public GameObject kalp2;
    public GameObject kalp3;
    

    public RandomScript()
    {
       
    }

    // Use this for initialization
    void Start()
    {

       
        dogrutoplar = new GameObject[5] { dogrutop, t1, t2, t3, t4 };
        yanlistoplar = new GameObject[4] { yanlistop, b1, b2, b3 };


        if (cam == null)
        {
            cam = Camera.main;
        }

        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float mwidth = GetComponent<Renderer>().bounds.extents.x;
        mwidth = targetWidth.x - mwidth;
        maxWidth = mwidth;
        StartCoroutine(Spawn());
    }

 
    public void ThrowBall(GameObject top)
    {
        int rgrav = 0;

        rgrav = Random.Range(1, 10);

        float rgravf = (rgrav / 10f);


        if (top.name != "can")
        {
            top.gameObject.GetComponent<Rigidbody2D>().gravityScale = rgravf;
        }
       
        Vector3 sp = new Vector3(Random.Range(-maxWidth + 3, maxWidth - 5), transform.position.y, 0.0f);
        Quaternion sr = Quaternion.identity;
        Instantiate(top, sp, sr);
    }

 

    IEnumerator Spawn()
    {




        int r1 = 0;

      

        int r2 = 0;

       
        yield return new WaitForSeconds(2.0f);
        while (true)
        {
            


            r1 = Random.Range(0, 4);

            r2 = Random.Range(0, 3);

            float x = Random.Range(1, 2);

            for (int i = 0; i < x; i++)
            {

                ThrowBall(dogrutoplar[r1]);
            }

            float y = Mathf.Ceil(x / 2);

            for (int i = 0; i < y; i++)
            {

              
                ThrowBall(yanlistoplar[r2]);
            }

           

         
          


            yield return new WaitForSeconds(1.0f);
        }

        

    }

    // Update is called once per frame
    void Update()
    {


        

    }

    void FixedUpdate()
    {
       
    }
}

