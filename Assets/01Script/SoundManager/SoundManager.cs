using UnityEngine;
using UnityEngine.InputSystem;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClips;
    [SerializeField] int maxSources = 10;

    public static SoundManager Instance;

    private void Awake()
    {
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
