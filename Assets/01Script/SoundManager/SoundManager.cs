using UnityEngine;
using UnityEngine.InputSystem;

public class SoundManager : MonoBehaviour
{
    public float Volume { get; set; }

    [SerializeField] AudioClip[] audioClips;
    [SerializeField] int maxSources = 10;

    public static SoundManager Instance;

    private void Awake()
    {
        Volume = 1;

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void PlaySound(int soundNumber)
    {
        if (soundNumber < 0 || soundNumber >= audioClips.Length) return;

        AudioSource newSource = gameObject.AddComponent<AudioSource>();
        newSource.clip = audioClips[soundNumber];
        newSource.Play();
        newSource.volume = Volume / 1;

        Destroy(newSource, audioClips[soundNumber].length);
    }

    private void Update()
    {
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            PlaySound(0);
        }
    }
}
