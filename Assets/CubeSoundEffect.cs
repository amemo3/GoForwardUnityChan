using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSoundEffect : MonoBehaviour
{
    public AudioSource audios;

    public AudioClip clip;
    void Start()
    {
        audios = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "unitychan")
        {
           
        }
        else
        {
            audios.Play();
        }

    }
}
