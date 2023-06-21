using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaperClue : MonoBehaviour
{
    [SerializeField] private string value;
    [SerializeField] private TextMeshProUGUI textValue;
    private bool once;

    public string Value { get { return value; } }
    public bool Once { get { return once; } set { once = value; } }


    void Start()
    {
        textValue.text = value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
