using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Multiplication : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickMultiplication()
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
        else
        {
            text.text = "";
            double mul = Convert.ToDouble(firstInputField.text) * Convert.ToDouble(secondInputField.text);
            result.text = Convert.ToString(mul);
        }
    }
}