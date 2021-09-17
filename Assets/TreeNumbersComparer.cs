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
                    text.text = "������� �����!";
                    result.text = "";
                }
                else
                {
                    text.text = "������� ������ � ������ �����!";
                    result.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "������� ������ � ������ �����!";
                    result.text = "";
                }
                else
                {
                    text.text = "������� ������ �����!";
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
                    text.text = "������� ������ � ������ �����!";
                    result.text = "";
                }
                else
                {
                    text.text = "������� ������ �����!";
                    result.text = "";
                }
            }
            else if (secondInputField.text != "")
            {
                if (thirdInputField.text == "")
                {
                    text.text = "������� ������ �����!";
                    result.text = "";
                }
                else
                {
                    if (firstInputField.text.Equals(secondInputField.text))
                    {
                        if (firstInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "����� �����";
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "���������� �����: " + Convert.ToDouble(thirdInputField.text) + ", ������ � ������ ����� �����";
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "���������� �����: " + Convert.ToDouble(thirdInputField.text) + ", ������ � ������ ����� �����";
                            text.text = "";
                        }
                    }
                    else if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(secondInputField.text))
                    {
                        if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "��������� �����: " + Convert.ToDouble(firstInputField.text) + ", ���������� �����: " + Convert.ToDouble(thirdInputField.text);
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            if (Convert.ToDouble(firstInputField.text) == Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "���������� �����: " + Convert.ToDouble(secondInputField.text) + ", ������ � ������ ����� �����";
                                text.text = "";
                            }
                            if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "��������� �����: " + Convert.ToDouble(firstInputField.text) + ", ���������� �����: " + Convert.ToDouble(secondInputField.text);
                                text.text = "";
                            }
                            else if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "��������� �����: " + Convert.ToDouble(thirdInputField.text) + ", ���������� �����: " + Convert.ToDouble(secondInputField.text);
                                text.text = "";
                            }
                        }
                        else if (secondInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "��������� �����: " + Convert.ToDouble(firstInputField.text) + ", ������ � ������ ����� �����";
                            text.text = "";
                        }
                    }
                    else if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(secondInputField.text))
                    {
                        if (Convert.ToDouble(firstInputField.text) == Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "���������� �����: " + Convert.ToDouble(secondInputField.text) + ", ������ � ������ ����� �����";
                            text.text = "";
                        }
                        if (Convert.ToDouble(secondInputField.text) < Convert.ToDouble(thirdInputField.text))
                        {
                            result.text = "��������� �����: " + Convert.ToDouble(thirdInputField.text) + ", ���������� �����: " + Convert.ToDouble(firstInputField.text);
                            text.text = "";
                        }
                        else if (Convert.ToDouble(secondInputField.text) > Convert.ToDouble(thirdInputField.text))
                        {
                            if (Convert.ToDouble(firstInputField.text) < Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "��������� �����: " + Convert.ToDouble(secondInputField.text) + ", ���������� �����: " + Convert.ToDouble(firstInputField.text);
                                text.text = "";
                            }
                            else if (Convert.ToDouble(firstInputField.text) > Convert.ToDouble(thirdInputField.text))
                            {
                                result.text = "��������� �����: " + Convert.ToDouble(secondInputField.text) + ", ���������� �����: " + Convert.ToDouble(thirdInputField.text);
                                text.text = "";
                            }
                        }
                        else if (secondInputField.text.Equals(thirdInputField.text))
                        {
                            result.text = "���������� �����: " + Convert.ToDouble(firstInputField.text) + ", ������ � ������ ����� �����";
                            text.text = "";
                        }
                    }
                }
            }
        }
    }

}