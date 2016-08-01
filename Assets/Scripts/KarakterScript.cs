using UnityEngine;
using System.Collections;

public class KarakterScript : MonoBehaviour
{

    public float moveSpeed = 0.2f;
    private float minX, maxX, minY, maxY;


    private float hSliderValue = 0.1f;

    void OnGUI()
    {
        hSliderValue = GUI.HorizontalSlider(new Rect(1710, 100, 50, 50), hSliderValue, 10.0f, 0.0f);

        float fl = (Mathf.Floor(hSliderValue) / 10);
        moveSpeed = fl;
        
    }


    // Use this for initialization
    void Start()
    {
        float camDistance = Vector3.Distance(transform.position, Camera.main.transform.position);
        Vector2 bottomCorner = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, camDistance));
        Vector2 topCorner = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, camDistance));

        minX = bottomCorner.x;
        maxX = topCorner.x;
        minY = bottomCorner.y;
        maxY = topCorner.y;

    }

    // Update is called once per frame
    void OnMouseDrag()
    {
      
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(moveSpeed, 0, 0));
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);
        }


        Vector3 pos = transform.position;

        // Horizontal contraint
        if (pos.x < minX) pos.x = minX;
        if (pos.x > maxX) pos.x = maxX;


        // Update position
        transform.position = pos;
    }

    public float speed = 0.2f;
    void Update()
    {




    }
}
