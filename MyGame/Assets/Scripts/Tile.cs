using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(MeshCollider))]
public class Tile : MonoBehaviour
{
    private void OnMouseDown()
    {
        Game.events.publishSelectedTile(gameObject);
    }
}
