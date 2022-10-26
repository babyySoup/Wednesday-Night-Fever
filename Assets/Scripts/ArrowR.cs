using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowR : MonoBehaviour
{
    public bool canBeHit;
    Score playerscore;
    public GameObject score;
    public GameObject DiskParticle;

    //public GameObject Combo;
    //Combo CN;

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
        if (canBeHit && Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("hitting r arrow key");
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
