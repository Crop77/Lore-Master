using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    private void Start()
    {
        if (MusicManager.Instance != null)
            musicSlider.SetValueWithoutNotify(MusicManager.Instance.musicVolume);

        if (SfxManager.Instance != null)
            sfxSlider.SetValueWithoutNotify(SfxManager.Instance.sfxVolume);
    }

    public void OnMusicSliderChanged(float value)
    {
        Debug.Log("Music slider changed: " + value);

        if (MusicManager.Instance != null)
            MusicManager.Instance.SetMusicVolume(value);
    }


    public void OnSfxSliderChanged(float value)
    {
        if (SfxManager.Instance != null)
            SfxManager.Instance.SetSfxVolume(value);
    }
}
