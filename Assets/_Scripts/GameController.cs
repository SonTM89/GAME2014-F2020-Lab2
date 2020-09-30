using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LiveLabel;
    public TMP_Text ScoreLabel;

    private float livesLabelHalfWidth;
    private float livesLabelHalfHeight;

    private float scoreLabelHalfWidth;
    private float scoreLabelHalfHeight;

    public CanvasScaler scaler;
    public Vector2 scale;

    // Start is called before the first frame update
    void Start()
    {
        var currentResolution = new Vector2(Screen.currentResolution.width, Screen.currentResolution.height);
        scale = currentResolution / scaler.referenceResolution;

        livesLabelHalfWidth = LiveLabel.rectTransform.rect.width * 0.5f * scale.x;
        livesLabelHalfHeight = LiveLabel.rectTransform.rect.height * 0.5f * scale.y;
        scoreLabelHalfWidth = ScoreLabel.rectTransform.rect.width * 0.5f * scale.x;
        scoreLabelHalfHeight = ScoreLabel.rectTransform.rect.height * 0.5f * scale.y;
    }

    // Update is called once per frame
    void Update()
    {

        LiveLabel.rectTransform.position = new Vector2(Screen.safeArea.xMin + livesLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);
        ScoreLabel.rectTransform.position = new Vector2(Screen.safeArea.xMax - scoreLabelHalfWidth, Screen.safeArea.yMax - livesLabelHalfHeight);

        /*
        switch (Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //SceneLabel.text = "Portrait";
                LiveLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -200.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -200.0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                //SceneLabel.text = "Landssape Left";
                LiveLabel.rectTransform.anchoredPosition = new Vector2(370.0f, -83.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-353.0f, -83.0f);       
                break;
            case DeviceOrientation.LandscapeRight:
                //SceneLabel.text = "Landscape Right";
                LiveLabel.rectTransform.anchoredPosition = new Vector2(248.0f, -83.0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-500.0f, -83.0f);
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknow";
                break;
            default:
                //SceneLabel.text = "Some other Orientation";
                break;
        }
        */
    }
}
