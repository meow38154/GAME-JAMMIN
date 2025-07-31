using UnityEngine;

public class TimeAttack : MonoBehaviour
{
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
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                isTimeUp = true;
                OnTimeUp();
            }
        }
    }
    private void OnTimeUp()
    {
        // Handle what happens when time is up
        Debug.Log("Time is up!");
        // You can add more logic here, like ending the game or showing a message
    }
}
