using UnityEngine;
using System.Collections;

public class TabanScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.name != "karakter")
        {
            Destroy(other.gameObject);
        }
       
    }
}
