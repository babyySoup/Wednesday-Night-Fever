using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    public bool canBeHit;
    Score playerscore;
    public GameObject score;

    public GameObject noteParticle;

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
        }
    }

    void Start()
    {
        playerscore = score.GetComponent<Score>();
    }
}
