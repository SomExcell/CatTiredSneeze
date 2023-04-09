using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVolume : MonoBehaviour
{
    public AudioSource FX;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public void hoverSound()
    {
        FX.PlayOneShot(hoverFX);
    }

    public void clickSound()
    {
        FX.PlayOneShot(clickFX);
    }
}
