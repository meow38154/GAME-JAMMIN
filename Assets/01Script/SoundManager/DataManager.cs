using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DataManager : MonoBehaviour
{
    [field: SerializeField] public int Coin { get; set; }
    public float Volume { get; set; }

    [field: SerializeField] public int Language { get; set; }

    [SerializeField] AudioClip[] audioClips;
    [SerializeField] int maxSources = 10;

    [field: SerializeField] public TMP_FontAsset[] Font { get; private set; }

    public static DataManager Instance;

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
