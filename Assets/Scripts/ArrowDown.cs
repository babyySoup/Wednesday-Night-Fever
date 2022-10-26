using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDown : MonoBehaviour
{
    public bool canBeHit;
    Score playerscore;
    public GameObject score;

    public GameObject DiskParticle;


    Combo CN;
    //public GameObject Combo;

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
        if (canBeHit && Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("hitting D arrow key");
            
            DiskParticle.GetComponent<ParticleSystem>().Play();

            gameObject.SetActive(false);
            Destroy(this.gameObject);
            playerscore.scoreCount += 1;
            //CN.ComboNumber += 1;
            Combo comboScript = GameObject.Find("Combo System").GetComponent<Combo>();
            comboScript.ComboNumber += 1;
            Debug.Log("combo!");

            if (comboScript.ComboNow == true)
            {
                playerscore.scoreCount += 3;
            }

        }
    }
    void Start()
    {
        playerscore = score.GetComponent<Score>();
        //CN = Combo.GetComponent<Combo>();
    }
}
