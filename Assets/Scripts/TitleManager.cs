using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{

    [SerializeField]
    ToggleGroup group1;

    [SerializeField]
    ToggleGroup group2;


    public void ToggleChange(bool change) {
        // var toggle1 = group1.GetFirstActiveToggle();
        // var toggle2 = group2.GetFirstActiveToggle();
        // Debug.Log($"value: {change}. Group1: {toggle1.name}. Group2 {toggle2.name}");
    }
}
