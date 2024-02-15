using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(MeshCollider))]
public class Tile : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log(transform.position);
        Game.events.publishSelectedTile(gameObject);
    }
}
