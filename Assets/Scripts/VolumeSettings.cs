using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer musicMixer;
    [SerializeField] private Slider musicSlider;

    [SerializeField] private AudioMixer soundsMixer;
    [SerializeField] private Slider soundsSlider;

    private void Start()
    {
        SetBGMVolume();
        SetSFXVolume();
    }

    public void SetBGMVolume()
    {
        float volume = musicSlider.value;
        musicMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }
    public void SetSFXVolume()
    {
        float volume = soundsSlider.value;
        soundsMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
