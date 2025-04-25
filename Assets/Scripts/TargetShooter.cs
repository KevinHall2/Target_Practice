using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    private TextMeshProUGUI gameScoreUI;

    private int startingScore = 0;
    private int gameScoreCount;

    private void Start()
    {
        gameScoreCount = startingScore;

        if (gameScoreUI)
        {
            gameScoreUI.text = gameScoreCount.ToString();
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Fires at whatever the camera is pointing at
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                //Registers the hit, destroys & replaces the target, and increases score
                if(target != null)
                {
                    target.Hit();
                    gameScoreCount++;
                }
            }
        }

        if(gameScoreUI)
        {
            gameScoreUI.text = gameScoreCount.ToString();
        }

        Debug.Log(gameScoreUI == null);
    }
}
