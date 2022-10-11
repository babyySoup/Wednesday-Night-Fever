using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowUp : MonoBehaviour
{
    public bool canBeHit;
    Score playerscore;
    public GameObject score;
    public GameObject Combo;
    Combo CN;
    
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
        if (canBeHit && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("hitting up arrow key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
            playerscore.scoreCount += 1;
            CN.ComboNumber += 1;
            if(CN.ComboNow == true)
            {
                playerscore.scoreCount += 3;
            }
        }

    }

    void Start()
    {
        playerscore = score.GetComponent<Score>();
        CN = Combo.GetComponent<Combo>();
        
    }
}
