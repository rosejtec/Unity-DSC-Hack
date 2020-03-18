using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    
public AudioClip[] clips;
private AudioSource audioSource;

// Start is called before the first frame update
void Start()
{
    audioSource = FindObjectOfType<AudioSource>();
    audioSource.loop = false;

}
private AudioClip GetRandomCip()
{

        
    AudioClip music = null;
    music = clips[Random.Range(0, clips.Length)];

    while (music == audioSource.clip)
    {
        music = clips[Random.Range(0, clips.Length)];
    }
    return music;


}
// Update is called once per frame
void Update()
{
    if (!audioSource.isPlaying)
    {
        audioSource.clip = GetRandomCip();
        audioSource.Play();
    }

}
}