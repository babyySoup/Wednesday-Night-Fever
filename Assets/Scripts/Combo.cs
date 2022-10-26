using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    
    public int ComboNumber;
    public GameObject ComboImage;
    public float HitTime;
    public bool ComboNow;

    public GameObject Mid;
    public GameObject High;
    void Start()
    {
        ComboNumber = 0;
        ComboImage.SetActive(false);
        ComboNow = false;


        Mid.SetActive(false);
        High.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ComboNumber >= HitTime)
        {
            ComboImage.SetActive(true);
            ComboNow = true;
            Mid.SetActive(true);

        }
        if (ComboNumber >= 10)
        {
            High.SetActive(true);
        }
        else
        {
            ComboImage.SetActive(false);
            High.SetActive(false);
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
