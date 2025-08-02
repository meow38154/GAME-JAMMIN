using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeAttack : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText; // Reference to a TextMeshProUGUI
    [SerializeField] private float timeLimit = 60f; // Time limit in seconds
    private float timeRemaining;
    private bool isTimeUp = false;

    private void Start()
    {
        timeRemaining = timeLimit;
    }
    private void Update()
    {
        if (!isTimeUp)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = Mathf.Ceil(timeRemaining).ToString(); // Update the timer text
            if (timeRemaining <= 0)
            {
                timerText.text = "0"; // Ensure the text shows 0 when time is up
                timeRemaining = 0;
                isTimeUp = true;
                OnTimeUp();
            }
        }
    }
    private void OnTimeUp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
