using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DataManager : MonoBehaviour
{
    [field: SerializeField] public bool[] HiddenStage { get; set; }

    [field: SerializeField] public int Coin { get; set; }
    public float Volume { get; set; }

    [field: SerializeField] public int Language { get; set; }

    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private int maxSources = 10;

    [field: SerializeField] public TMP_FontAsset[] Font { get; private set; }

    public static DataManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        SaveData();
    }

    public void PlaySound(int soundNumber)
    {
        if (soundNumber < 0 || soundNumber >= audioClips.Length) return;

        AudioSource newSource = gameObject.AddComponent<AudioSource>();
        newSource.clip = audioClips[soundNumber];
        newSource.Play();
        newSource.volume = Volume;

        Destroy(newSource, audioClips[soundNumber].length);
    }

    private void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame && Keyboard.current.sKey.isPressed)
        {
            for (int i = 0; i < HiddenStage.Length; i++)
            {
                HiddenStage[i] = false;
                Coin = 0;
            }
        }

        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            PlaySound(0);
        }
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("Coin", Coin);
        PlayerPrefs.SetInt("Language", Language);
        PlayerPrefs.SetFloat("Volume", Volume);

        for (int i = 0; i < HiddenStage.Length; i++)
        {
            PlayerPrefs.SetInt("HiddenStage_" + i, HiddenStage[i] ? 1 : 0);
        }

        PlayerPrefs.Save();
    }

    private void LoadData()
    {
        Coin = PlayerPrefs.GetInt("Coin", 0);
        Language = PlayerPrefs.GetInt("Language", 0);
        Volume = PlayerPrefs.GetFloat("Volume", 1f);

        for (int i = 0; i < HiddenStage.Length; i++)
        {
            HiddenStage[i] = PlayerPrefs.GetInt("HiddenStage_" + i, 0) == 1;
        }
    }
}
