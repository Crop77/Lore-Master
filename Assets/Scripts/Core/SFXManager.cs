using UnityEngine;

public class SfxManager : MonoBehaviour
{
    public static SfxManager Instance { get; private set; }

    public AudioSource sfxSource;
    [Range(0f, 1f)]
    public float sfxVolume = 1f;

    public AudioClip uiClick;   

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if (sfxSource != null)
            sfxSource.volume = sfxVolume;
    }

    public void SetSfxVolume(float value)
    {
        sfxVolume = value;
        if (sfxSource != null)
            sfxSource.volume = sfxVolume;
    }

    public void PlaySfx(AudioClip clip)
    {
        if (clip == null || sfxSource == null) return;
        sfxSource.PlayOneShot(clip);
    }

    public void PlayClick()
    {
        if (uiClick != null)
            PlaySfx(uiClick);
    }
}
