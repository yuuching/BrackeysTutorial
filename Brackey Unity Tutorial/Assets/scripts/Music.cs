
using UnityEngine;

public class Music : MonoBehaviour {

    public AudioSource infiniteloops;

    public void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        infiniteloops = GetComponent<AudioSource>();
    }

    public void PlayMusic()

    {
        if (infiniteloops.isPlaying) return;
        infiniteloops.Play();
    }

    public void StopMusic()
    {
        infiniteloops.Stop();
    }

}
