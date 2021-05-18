using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button playButton;
    protected RawImage buttonImage;
    void Start()
    {
        playButton.onClick.AddListener(TogglePause); //   <- 이부분 주목. onClick.AddListener 기본형, 버튼에 어떤 클래스 에서 호출했는지 남지 않는다.
        buttonImage = playButton.GetComponentInChildren<RawImage>();
    }


    public Texture playImage;
    public Texture pauseImage;
    protected void TogglePause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;

            //플레이 이미지 보여주자
            buttonImage.texture = playImage;
        }
        else
        {
            Time.timeScale = 1;

            //pause 이미지 보여주자
            buttonImage.texture = pauseImage;
        }
    }
}
