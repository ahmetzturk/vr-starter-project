using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMesh textMesh;
    // Start is called before the first frame update

    public void ShowScore(int score)
    {
        textMesh.text = score.ToString();
    }
}

