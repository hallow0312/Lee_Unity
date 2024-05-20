using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource scenerySource;
    public AudioSource effectSource;

    public AudioClip[] audioClip;
    public Slider slider;

    //[0] Click
    //[1] Quest Clear
    //[2] Level UP
   public void Control(float volume)
    {
        scenerySource.volume = volume;
    }
    public void Sound(int audioValue)
    {

        //PlayOneShot() : ���ÿ� ���� �������� ���带 ����ϴ� �Լ�.

        effectSource.PlayOneShot(audioClip[audioValue]);
    }
    private void Awake()
    {
        
        scenerySource.volume = slider.value; 

    }
}
