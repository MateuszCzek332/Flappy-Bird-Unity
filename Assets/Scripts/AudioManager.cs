using UnityEngine;
using static Unity.VisualScripting.Member;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip jumpAudioClip;
    [SerializeField] private AudioClip deathhAudioClip;
    [SerializeField] private AudioClip scoreAudioClip;
    
    [SerializeField] private AudioClip backgroundAudioClip;
    private AudioSource backgroundAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        GameManager.RegisterAudio(this);
        audioSource = GetComponent<AudioSource>();
        backgroundAudioSource = GetComponent<AudioSource>();
        backgroundAudioSource.clip = backgroundAudioClip;
        backgroundAudioSource.loop = true;
    }

    public void playJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClip);
    }

    public void playDeathSound()
    {
        audioSource.PlayOneShot(deathhAudioClip);
    }

    public void playScoreSound()
    {
        audioSource.PlayOneShot(scoreAudioClip);
    }

    public void playBackgroundMusic()
    {
        backgroundAudioSource.Play();
    }

    public void stopbackgroundMusic()
    {
        backgroundAudioSource.Stop();
    }
}
