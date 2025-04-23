using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    //Creates the illusion of the target being destroyed by moving it to a different random position
    public void Hit()
    {
        transform.position = TargetBounds.Instance.GetRandomPosiiton();
    }
}
