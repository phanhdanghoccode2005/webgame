using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource BackGroundAudioSource;
    [SerializeField] private AudioSource EffectAudioSource;

    [SerializeField] private AudioClip backgroundClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip coinClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayBackGroundMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBackGroundMusic()
    {
        BackGroundAudioSource.clip = backgroundClip;
        BackGroundAudioSource.Play();
    }
    public void PlayCoinSound()
    {
        EffectAudioSource.PlayOneShot(coinClip);
    }
    public void PlayJumpSound()
    {
        EffectAudioSource.PlayOneShot(jumpClip);
    }
}
