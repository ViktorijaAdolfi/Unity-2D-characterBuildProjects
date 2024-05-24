using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Dropdown : MonoBehaviour

{
    [SerializeField] private GameObject garmentGO;
    public void switchGarments(int index)
    {
        foreach (Transform child in garmentGO.transform)
        {
            child.gameObject.SetActive(false);
        }
        garmentGO.transform.Find(index + "").gameObject.SetActive(true);
    }
}
