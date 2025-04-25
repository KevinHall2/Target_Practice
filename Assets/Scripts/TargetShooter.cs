using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{
    [SerializeField]
    Camera _cam;

    [SerializeField]
    private TextMeshProUGUI _gameScoreUI;

    private int _startingScore = 0;
    private int _gameScoreCount;

    public int GameScoreCount { get { return _gameScoreCount; } }

    private void Start()
    {
        _gameScoreCount = _startingScore;

        if (_gameScoreUI)
        {
            _gameScoreUI.text = _gameScoreCount.ToString();
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Fires at whatever the camera is pointing at
            Ray ray = _cam.ViewportPointToRay(new Vector3(0.5f, 0.5f));

            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();

                //Registers the hit, destroys & replaces the target, and increases score
                if(target != null)
                {
                    target.Hit();
                    _gameScoreCount++;
                }
            }
        }

        if(_gameScoreUI)
        {
            _gameScoreUI.text = _gameScoreCount.ToString();
        }
    }
}
