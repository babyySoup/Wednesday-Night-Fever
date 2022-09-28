using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song1Manager : MonoBehaviour
{
    public AudioSource song1;

    public bool startPlaying;

    public BeatScoller BS;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                BS.hasStarted = true;

                song1.Play();
            }
        }
    }
}
