using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;

    [SerializeField] private AudioClip backGround;

    private void Start()
    {
        this.musicSource.clip = backGround;
        this.musicSource.Play();
    }

}
