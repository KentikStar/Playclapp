using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControl : MonoBehaviour
{
    private float speed;
    public float Speed{
        get{
            return speed;
        }
        private set{
            speed = value;
        }
    }
    private float time;
    public float Time{
        get{
            return time;
        }
        private set{
            time = value;
        }
    }
    private float distance;
    public float Distance{
        get{
            return distance;
        }
        private set{
            distance = value;
        }
    }

    void Start()
    {
        Distance = 5;
        Speed = 3;
        Time = 3;
    }

    public void SaveSpeed(TMP_InputField field){
        Speed = Convert.ToSingle(field.text);
    }

    public void SaveTime(TMP_InputField field){
        Time = Convert.ToSingle(field.text);
    }

    public void SaveDistance(TMP_InputField field){
        Distance = Convert.ToSingle(field.text);
    }
}
