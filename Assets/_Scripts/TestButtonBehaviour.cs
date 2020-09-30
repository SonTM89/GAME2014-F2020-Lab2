using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LiveLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTestButtonPressed()
    {
        Debug.Log("Test Button Pressed");
        //SceneLabel.text = "Test";
        LiveLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -83.0f);
        ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -83.0f);
    }
}
