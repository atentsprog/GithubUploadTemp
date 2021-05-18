using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public void SetTimePauseToggle(bool isPause)
    {
        if (isPause)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}