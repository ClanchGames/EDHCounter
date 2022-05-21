using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlusMinus : MonoBehaviour
{
    private Button button;
    private TextMeshProUGUI parentText;
    private int parentNum;

    // Start is called before the first frame update
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        parentText = transform.parent.gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void OnClick()
    {
        if (gameObject.name == "Plus")
        {
            parentNum = int.Parse(parentText.text);
            parentNum++;
            parentText.text = parentNum.ToString();
        }
        else if (gameObject.name == "Minus")
        {
            parentNum = int.Parse(parentText.text);
            parentNum--;
            parentText.text = parentNum.ToString();
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}