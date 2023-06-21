using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
    public static InGameManager Instance { get; private set; }
    [SerializeField] private SOEssay essays;
    [SerializeField] private List<string> values;
    private int valuesCount;

    //Getter And Setter
    public List<string> Values { get { return values; } set { values = value; } }
    void Start()
    {
        Instance = this;
    }

    void Update()
    {

    }

    public void Validation()
    {

        for (int i = valuesCount; i < values.Count; i++)
        {
            if (!values[i].Equals(essays.answer[i]))
            {
                Debug.Log("salah");
            }
            else
            {
                valuesCount++;
            }
            if (valuesCount == essays.answer.Count)
            {
                Debug.Log("Anda berhasil menjawab soal");
            }
        }
    }
}
