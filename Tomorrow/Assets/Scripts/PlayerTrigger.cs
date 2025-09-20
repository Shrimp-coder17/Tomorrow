using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private LevelBarManager levelBarManager;
    private AudioSource [] sounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        levelBarManager = GetComponent<LevelBarManager>();
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ReviveOrb"))
        {
            PlaySoundsOrb();
            levelBarManager.SetRevBar();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("SinOrb"))
        {
            PlaySoundsOrb();
            levelBarManager.SetSinBar(10);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("FlyTrigger"))
        {
            PlaySoundsOrb();
            levelBarManager.SetSinBar(15);
            Destroy(other.gameObject);
        }
    }

    private void PlaySoundsOrb()
    {
        sounds[1].Play();
    }

}




   

