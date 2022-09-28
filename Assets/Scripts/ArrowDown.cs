using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDown : MonoBehaviour
{
    public bool canBeHit;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HitDisk")
        {
            canBeHit = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "HitDisk")
        {
            canBeHit = false;
        }
    }


    void Update()
    {
        if (canBeHit && Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("hitting D arrow key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
