using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviour : MonoBehaviour
{
    public List<int> PrintedIntegers;
    public int ItemPrintDelay;
    public int Rows;
    public int Columns;

    public IEnumerator PrintIntegersWithAFixedDelay(List<int> list, int D)
    {
        foreach (var item in list)
        {
            Debug.Log(item);
            yield return new WaitForSeconds(D);
        }
    }
    public void PrintIntegersListInRowsAndColumns(List<int> list, int R, int C)
    {
        string resultString = "";

        for (int i = 0; i < R; i++)
        {
            for (int j = 0; j < C; j++)
            {
                int currentIndex = (R * i) + j;
                if (currentIndex < list.Count)
                    resultString += (list[currentIndex] + "\t");
                else
                    resultString += ("  \t");
            }
            resultString += ("\n");
        }
        Debug.Log("\n--------Printed Result--------\n" + resultString + "----------------");
    }

    public void Start()
    {
        PrintIntegersListInRowsAndColumns(PrintedIntegers, Rows, Columns);
        StartCoroutine(PrintIntegersWithAFixedDelay(PrintedIntegers, ItemPrintDelay));
    }

    // Commenting out because it's not needed and will eat up cycles despite being empty
    // 	public void Update()
    // {
    // //default Unity method
    // }

}
