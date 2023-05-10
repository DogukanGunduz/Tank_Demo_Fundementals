using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public void TurnLeft()
    {
        Vector3 rotationToAdd = new Vector3(0, -4, 0);
        transform.Rotate(rotationToAdd);
    }

    public void TurnRight()
    {
        Vector3 rotationToAdd = new Vector3(0, 4, 0);
        transform.Rotate(rotationToAdd);
    }
}
