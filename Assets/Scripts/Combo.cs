using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combo : MonoBehaviour
{
    
    public int ComboNumber;
    void Start()
    {
        ComboNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
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
