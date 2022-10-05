using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowL : MonoBehaviour
{
    public bool canBeHit;
    Score playerscore;
    public GameObject score;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HitDisk")
        {
            canBeHit = true;
            Debug.Log("can hit left arrow key");
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
        if (canBeHit && Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("hitting left arrow key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
            playerscore.scoreCount += 1;
        }
    }

    void Start()
    {
        playerscore = score.GetComponent<Score>();
    }
}
