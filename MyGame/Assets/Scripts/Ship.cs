using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Ship : MonoBehaviour
{
    [Range(0f, 1f)]
    public float duration;

    private GameObject tileCopy;
    private void OnDestroy()
    {
        Game.events.tileSelected -= GetTile;
    }

    private void Start()
    {
        Game.events.tileSelected += GetTile;
    }

    public void GetTile(GameObject tile)
    {
        tileCopy = tile;

        Vector3 moveTarget = new Vector3(tile.transform.position.x, transform.position.y + tile.transform.position.y, tile.transform.position.z);
        Vector3 lookTarget = new Vector3(transform.position.x, tile.transform.position.y + transform.position.y, transform.position.z);
        iTween.MoveTo(gameObject, iTween.Hash("position", moveTarget, "speed", duration, "easeType", "easeInOutQuad", "looktarget", lookTarget));
    }
}
