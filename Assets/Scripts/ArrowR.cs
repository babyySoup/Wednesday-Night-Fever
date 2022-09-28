using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowR : MonoBehaviour
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
        if (canBeHit && Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("hitting r arrow key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
