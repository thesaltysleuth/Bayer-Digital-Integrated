using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInstructions : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] Panels;
    public AudioSource audioSource;
    public AudioClip[] audios;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayButton(string panelname)
    {
        foreach (GameObject panel in Panels)
        {
            if (panel.name == panelname)
            {
                panel.SetActive(true);
            }
        }
    }

    public void PlaySound(string clipname)
    {
        foreach (AudioClip audio in audios)
        {
            if (audio.name == clipname)
            {
                audioSource.clip = audio;
            }
        }
        audioSource.Play();
    }
}
