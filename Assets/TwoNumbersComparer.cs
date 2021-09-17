using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickTwoNumbersComparer()
    {
        if (firstInputField.text == "")
        {
            if (secondInputField.text == "")
            {
                text.text = "¬ведите числа!";
                result.text = "";
            }
            else
            {
                text.text = "¬ведите первое число!";
                result.text = "";
            }
        }
        else if (secondInputField.text == "")
        {
            if (firstInputField.text != "")
            {
                text.text = "¬ведите второе число!";
                result.text = "";
            }
        }
        else if (firstInputField.text.Equals(secondInputField.text))
        {
            result.text = "„исла равны";
            text.text = "";
        }
        else if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(secondInputField.text))
        {
            result.text = "„исло " + Convert.ToDouble(firstInputField.text) + " больше числа " + Convert.ToDouble(secondInputField.text);
            text.text = "";
        }
        else if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(secondInputField.text))
        {
            result.text = "„исло " + Convert.ToDouble(firstInputField.text) + " меньше числа " + Convert.ToDouble(secondInputField.text);
            text.text = "";
        }
    }
}