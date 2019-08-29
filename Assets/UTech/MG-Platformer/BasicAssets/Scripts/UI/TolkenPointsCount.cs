using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TolkenPointsCount : MonoBehaviour
{
    [SerializeField] private PlayerPoints playerPoints;

    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        UpdateTolkenPoints();
    }

    private void UpdateTolkenPoints()
    {
        textMesh.text = playerPoints.tokens.ToString();
    }
}
