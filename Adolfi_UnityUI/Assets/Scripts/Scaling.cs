using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaling : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Slider slider;
    float orgScale = 1F;

    public void ChangeHeight(float val)
    {
        target.transform.localScale = new Vector3(target.transform.localScale.x, orgScale * val, target.transform.localScale.z);
    }
    public void ChangeWidth(float val)
    {
        target.transform.localScale = new Vector3(orgScale * val, target.transform.localScale.y, target.transform.localScale.z);
    }
}
