using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class Ship : MonoBehaviour
{
    [Range(0f, 1f)]
    public float duration = 0f;

    private GameObject tileCopy;
    private void OnDestroy()
    {
        Game.events.tileSelected -= GetTile;
    }

    private void Start()
    {
        Game.events.tileSelected += GetTile;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, tileCopy.transform.position, duration);
        duration += Time.deltaTime;
    }
    public void GetTile(GameObject tile)
    {
        duration = 0f;
        tileCopy = tile;
    }
}
