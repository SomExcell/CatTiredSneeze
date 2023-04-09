using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource audio;
    [SerializeField] private Slider slider;

    [Header("Keys")]
    [SerializeField] private string saveVolumeKey;

    [Header("Tag")]
    [SerializeField] private string sliderTag;

    [Header("Options")]
    [SerializeField] private float volume;

    private void Awake()
    {
        if (PlayerPrefs.HasKey(saveVolumeKey))
        {
            volume = PlayerPrefs.GetFloat(saveVolumeKey);
            audio.volume = volume;

            GameObject sliderObj = GameObject.FindWithTag(sliderTag);
            if (sliderObj != null)
            {
                slider = sliderObj.GetComponent<Slider>();
                slider.value = volume;
            }
        }
        else
        {
            volume = 0.5f;
            PlayerPrefs.SetFloat(saveVolumeKey, volume);
            audio.volume = volume;
        }
    }

    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(sliderTag);
        if (sliderObj != null)
        {
            slider = sliderObj.GetComponent<Slider>();
            volume = slider.value;
            
            if (audio.volume != volume)
                PlayerPrefs.SetFloat(saveVolumeKey, volume);
            
        }

        audio.volume = volume;
    }
}
