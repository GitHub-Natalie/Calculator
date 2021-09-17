using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuadraticEquation : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;
    [SerializeField] private InputField thirdInputField;
    [SerializeField] private Text disResult;
    [SerializeField] private Text solResult;
    [SerializeField] private Text text;

    public void onClickSolutionEquation()
    {
        // Проверка заполненности полей

        if (firstInputField.text == "")
        {
            if (secondInputField.text == "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите коэффициенты!";
                    disResult.text = "";
                    solResult.text = "";
                }
                else
                {
                    text.text = "Введите коэффициенты a и b!";
                    disResult.text = "";
                    solResult.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите коэффициенты a и c!";
                    disResult.text = "";
                    solResult.text = "";
                }
                else
                {
                    text.text = "Введите коэффициент a!";
                    disResult.text = "";
                    solResult.text = "";
                }
            }
        }
        else if (firstInputField.text != "")
        {
            if (secondInputField.text == "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите коэффициенты b и c!";
                    disResult.text = "";
                    solResult.text = "";
                }
                else
                {
                    text.text = "Введите коэффициент b!";
                    disResult.text = "";
                    solResult.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите коэффициент c!";
                    disResult.text = "";
                    solResult.text = "";
                }
                else if (thirdInputField.text != "")
                {
                    if (Convert.ToDouble(firstInputField.text) == 0)
                    {
                        text.text = "Задайте другое значение коэффициенту a, a ≠ 0!";
                        disResult.text = "";
                        solResult.text = "";
                    }
                    else
                    {
                        double a = Convert.ToDouble(firstInputField.text);
                        double b = Convert.ToDouble(secondInputField.text);
                        double c = Convert.ToDouble(thirdInputField.text);

                        double D = b * b - 4 * a * c;
                        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                        if (D < 0)
                        {
                            disResult.text = "D < 0";
                            solResult.text = "Корней нет";
                        }
                        else if (D == 0)
                        {
                            disResult.text = "D = 0";
                            solResult.text = "Один корень: x = " + x1;
                        }
                        else if (D > 0)
                        {
                            disResult.text = "D = " + D;
                            solResult.text = "x1 = " + x1 + ", x2 = " + x2;
                        }
                    }
                }
            }
        }
    }
}