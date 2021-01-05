using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    const float gridSize = 10f;

    TextMesh textMesh;
    Vector3 gridPos;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        gridPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        gridPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(gridPos.x, 0f, gridPos.z);

        textMesh = GetComponentInChildren<TextMesh>();
        string labelText = gridPos.x / gridSize + "," + gridPos.z / gridSize;
        textMesh.text = labelText;
        gameObject.name = "Cube " + labelText;

    }
}
