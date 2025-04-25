using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private FiringTimeLimit _gameTime;

    private void Update()
    {
        //If this timer isn't assigned, does nothing
        if (!_gameTime)
        {
            return;
        }


    }
}
