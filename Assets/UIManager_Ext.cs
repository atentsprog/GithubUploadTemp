using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager_Ext : UIManager
{
    void Start()
    {
        //playButton.onClick.AddListener(TogglePause); // 부모함수버전   <- 이부분 주목. onClick.AddListener 기본형, 버튼에 어떤 클래스 에서 호출했는지 남지 않는다. <- 

        playButton.AddListener(this, TogglePause); //   <- 이부분 주목.Button 확장 AddListener 함수 새로 만듬, 버튼에 어떤 클래스 에서 호출했는지 인스펙터에 기록이 남아서 분석할때 하기 쉽다.
        buttonImage = playButton.GetComponentInChildren<RawImage>();
    }
}
