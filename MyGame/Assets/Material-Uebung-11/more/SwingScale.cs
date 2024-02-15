using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rudimentäre Animation durch Anwendung einer Sinus-Kurve 
/// auf die Skalierung des Objekts.
/// </summary>
public class SwingScale : MonoBehaviour
{
    private float t = 0f;
    private void Update()
    {
        t += Time.deltaTime*8f;
        transform.localScale = new Vector3(1f,1f+(Mathf.Sin(t)*0.5f),1f);
    }
}
