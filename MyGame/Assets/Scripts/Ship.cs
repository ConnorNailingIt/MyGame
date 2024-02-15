using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    private void OnDestroy()
    {
        Game.events.tileSelected -= Move;
    }

    private void Start()
    {
        Game.events.tileSelected += Move;
    }

    public void Move(GameObject tile)
    {

    }
}
