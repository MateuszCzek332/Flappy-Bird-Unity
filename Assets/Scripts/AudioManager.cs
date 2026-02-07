using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip jumpAudioClip;
    [SerializeField] private AudioClip deathhAudioClip;
    [SerializeField] private AudioClip scoreAudioClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
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
}
