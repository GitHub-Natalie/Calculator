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
                text.text = "������� �����!";
                result.text = "";
            }
            else
            {
                text.text = "������� ������ �����!";
                result.text = "";
            }
        }
        else if (secondInputField.text == "")
        {
            if (firstInputField.text != "")
            {
                text.text = "������� ������ �����!";
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