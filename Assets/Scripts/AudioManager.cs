using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource BGMSource;
    [SerializeField] private AudioSource SFXSource;
    [SerializeField] private AudioClip BGClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayBGM();
    }

    // Update is called once per frame
    public void PlayBGM()
    {
        BGMSource.clip = BGClip;
        BGMSource.Play();
    } 
    public void PlayJumpSFX()
    {
        SFXSource.PlayOneShot(jumpClip);
    }
    public void PlayCoinSFX()
    {
        SFXSource.PlayOneShot(coinClip);
    }

}
