using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentStage : MonoBehaviour
{
    [SerializeField] Text StageText;
    int stageDepth = 0;

    private void Start()
    {
        StageText.text = ("Stage : " + stageDepth);
    }

    public void OnNextButton()
    {
        stageDepth++;
    }
}
