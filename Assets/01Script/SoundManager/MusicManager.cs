using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance; 

    [field: SerializeField] public AudioClip[] Music { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (TryGetComponent(out AudioSource audio))
        {
            audio.volume = SoundManager.Instance.Volume;
        }
    }

    public void PlayMusic(int num)
    {
        if (TryGetComponent(out AudioSource audio))
        {
            Destroy(audio);
        }

        AudioSource source = gameObject.AddComponent<AudioSource>();
        source.resource = Music[num];
        source.loop = true;
        source.Play();
    }
}
