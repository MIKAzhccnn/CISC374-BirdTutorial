using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [SerializeField] AudioSource audioSource;
    
    [Header("clips")]
    public AudioClip background;
    public AudioClip gameOver;
    public AudioClip score;


    private void Start()
    {
        audioSource.clip = background;
        audioSource.loop = true;
        audioSource.Play();
    }
    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    // public void playBackground()
    // {
    //     playSound(background);
    // }

}
