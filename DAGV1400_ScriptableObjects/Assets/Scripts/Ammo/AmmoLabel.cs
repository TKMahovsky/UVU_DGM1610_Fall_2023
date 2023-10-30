using System.Globalization;
using Ammo;
using UnityEngine;
using UnityEngine.UI;



[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{
    public Text labelInt;
    public IntData dataObjInt;
    
    private void Start()
    {
        labelInt = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        labelInt.text = dataObjInt.value.ToString(CultureInfo.InvariantCulture);
    }
}