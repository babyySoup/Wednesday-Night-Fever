using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public bool canBeHit;
    Score playerscore;
    public GameObject score;
    //public GameObject Combo;

    public GameObject noteParticle;
    //Combo CN;

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



    void Update()
    {
        if (canBeHit && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hitting space key");
            gameObject.SetActive(false);
            Destroy(this.gameObject);
            playerscore.scoreCount += 1;

            noteParticle = GameObject.Find("yellowParticle");
            noteParticle.GetComponent<ParticleSystem>().Play();

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
