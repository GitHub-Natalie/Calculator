using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TreeNumbersComparer : MonoBehaviour
{
    [SerializeField] private InputField firstInputField;
    [SerializeField] private InputField secondInputField;
    [SerializeField] private InputField thirdInputField;
    [SerializeField] private Text result;
    [SerializeField] private Text text;

    public void onClickTreeNumbersComparer()
    {
        if (firstInputField.text == "")
        {
            if (secondInputField.text == "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите числа!";
                    result.text = "";
                }
                else
                {
                    text.text = "Введите первое и второе числа!";
                    result.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите первое и третье числа!";
                    result.text = "";
                }
                else
                {
                    text.text = "Введите первое число!";
                    result.text = "";
                }
            }
        }
        else if (firstInputField.text != "")
        {
            if (secondInputField.text == "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите второе и третье числа!";
                    result.text = "";
                }
                else
                {
                    text.text = "Введите второе число!";
                    result.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "Введите третье число!";
                    result.text = "";
                }
                else
                {
                    if (firstInputField.text.Equals(secondInputField.text))
                    {
                        if (firstInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "Числа равны";
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "Наименьшее число: " + Convert.ToDouble(thirdInputField.text) + ", первое и второе числа равны";
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "Наибольшее число: " + Convert.ToDouble(thirdInputField.text) + ", первое и второе числа равны";
                            text.text = "";
                        }
                    }
                    else if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(secondInputField.text))
                    {
                        if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "Наибольше число: " + Convert.ToDouble(firstInputField.text) + ", наименьшее число: " + Convert.ToDouble(thirdInputField.text);
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            if (Convert.ToDouble(firstInputField.text) == Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "Наименьшее число: " + Convert.ToDouble(secondInputField.text) + ", первое и третье числа равны";
                                text.text = "";
                            }
                            if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "Наибольше число: " + Convert.ToDouble(firstInputField.text) + ", наименьшее число: " + Convert.ToDouble(secondInputField.text);
                                text.text = "";
                            }
                            else if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "Наибольше число: " + Convert.ToDouble(thirdInputField.text) + ", наименьшее число: " + Convert.ToDouble(secondInputField.text);
                                text.text = "";
                            }
                        }
                        else if (secondInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "Наибольше число: " + Convert.ToDouble(firstInputField.text) + ", второе и третье числа равны";
                            text.text = "";
                        }
                    }
                    else if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(secondInputField.text))
                    {
                        if (Convert.ToDouble(firstInputField.text) == Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "Наибольшее число: " + Convert.ToDouble(secondInputField.text) + ", первое и третье числа равны";
                            text.text = "";
                        }
                        if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "Наибольше число: " + Convert.ToDouble(thirdInputField.text) + ", наименьшее число: " + Convert.ToDouble(firstInputField.text);
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "Наибольше число: " + Convert.ToDouble(secondInputField.text) + ", наименьшее число: " + Convert.ToDouble(firstInputField.text);
                                text.text = "";
                            }
                            else if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "Наибольше число: " + Convert.ToDouble(secondInputField.text) + ", наименьшее число: " + Convert.ToDouble(thirdInputField.text);
                                text.text = "";
                            }
                        }
                        else if (secondInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "Наименьшее число: " + Convert.ToDouble(firstInputField.text) + ", второе и третье числа равны";
                            text.text = "";
                        }
                    }
                }
            }
        }
    }

}