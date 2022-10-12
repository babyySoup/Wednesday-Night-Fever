using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    
    public int ComboNumber;
    public GameObject ComboImage;
    public float HitTime;
    public bool ComboNow;
    void Start()
    {
        ComboNumber = 0;
        ComboImage.SetActive(false);
        ComboNow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ComboNumber >= HitTime)
        {
            ComboImage.SetActive(true);
            ComboNow = true;

        }
        else
        {
            ComboImage.SetActive(false);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            Debug.Log("Miss");
            ComboNumber = 0;

        }
    }
}
