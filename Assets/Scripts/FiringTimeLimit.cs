using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FiringTimeLimit : MonoBehaviour
{
    [SerializeField]
    private float startingTime = 30.0f;

    [SerializeField]
    private TextMeshProUGUI timerText;

    private float timeRemaining;

    private void Start()
    {
        timeRemaining = startingTime;
        if(timerText)
        {
            timerText.text = timeRemaining.ToString("0.0");
        }
    }

    private void Update()
    {
        timeRemaining -= Time.deltaTime;
        timeRemaining = Mathf.Clamp(timeRemaining, 0, startingTime);

        if (timerText)
        {
            timerText.text = timeRemaining.ToString("0.0");
        }
    }
}
