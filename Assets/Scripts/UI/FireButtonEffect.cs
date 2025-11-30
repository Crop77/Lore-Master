using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FireButtonEffect : MonoBehaviour
{
    public TMP_Text label;          
    public Image background;    
    public float pulseSpeed = 2f;
    public float pulseScale = 0.05f;
    public float flickerIntensity = 0.2f;

    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void Update()
    {
        FireScalePulse();
        FireColorFlicker();
    }

    private void FireScalePulse()
    {
        float scale = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseScale;
        transform.localScale = originalScale * scale;
    }

    private void FireColorFlicker()
    {
        if (label != null)
        {
            float flicker = Random.Range(-flickerIntensity, flickerIntensity);
            label.color = new Color(1f, 0.4f + flicker, 0f); 
        }

        if (background != null)
        {
            float flicker = Random.Range(-flickerIntensity, flickerIntensity);
            background.color = new Color(0.5f + flicker, 0.15f, 0f);
        }
    }
}
