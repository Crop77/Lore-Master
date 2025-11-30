using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    public AudioSource audioSource; 
    public AudioClip menuMusic;
    public AudioClip quizMusic;

    [Range(0f, 1f)]
    public float musicVolume = 1f;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if (audioSource != null)
            audioSource.volume = musicVolume;
    }

    public void PlayMenuMusic()
    {
        if (audioSource == null || menuMusic == null) return;

        if (audioSource.clip == menuMusic && audioSource.isPlaying) return;

        audioSource.clip = menuMusic;
        audioSource.loop = true;
        audioSource.volume = musicVolume;
        audioSource.Play();
    }

    public void PlayQuizMusic()
    {
        if (audioSource == null || quizMusic == null) return;

        if (audioSource.clip == quizMusic && audioSource.isPlaying) return;

        audioSource.clip = quizMusic;
        audioSource.loop = true;
        audioSource.volume = musicVolume;
        audioSource.Play();
    }

    public void SetMusicVolume(float value)
    {
        Debug.Log("SetMusicVolume called: " + value);  

        musicVolume = value;
        if (audioSource != null)
            audioSource.volume = musicVolume;
    }

}
