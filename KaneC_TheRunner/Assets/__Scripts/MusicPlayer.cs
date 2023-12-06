using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [Header("Music")]
    public AudioClip[] songs;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");
        PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayMusic();
        }
    }

    private void PlayMusic()
    {
        int n = Random.Range(1, songs.Length);
        audioSource.clip = songs[n];
        audioSource.PlayOneShot(audioSource.clip);
        audioSource.volume = PlayerPrefs.GetFloat("MusicVolume");
        // move picked sound to index 0 so it's not picked next time
        songs[n] = songs[0];
        songs[0] = audioSource.clip;
    }
}
