using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public bool canBeHit;

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HitLine")
        {
            canBeHit = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "HitLine")
        {
            canBeHit = false;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
