using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetCanselButton : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        if (gameObject.name == "Reset")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (gameObject.name == "Cansel")
        {
            MainController.main.MentionBoard.SetActive(false);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}